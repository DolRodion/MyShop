using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MyWorkShop.AppData;
using MyWorkShop.Const;
using MyWorkShop.Entities;
using MyWorkShop.Enums;
using MyWorkShop.Helper;
using MyWorkShop.Interfaces;
using MyWorkShop.Models;
using MyWorkShop.Param;
using MyWorkShop.Repository;

namespace MyWorkShop.Services
{
    public class ProductService : IProductService, ISaveLog
    {
        private readonly IGenericRepository<ShopProducts> _shopProductRepository;

        private readonly IGenericRepository<Files> _filesRepository;

        private readonly IHostingEnvironment _hostingEnvironment;

        private readonly ITransactionLogService _transactionLogService;


        public ProductService(
            IGenericRepository<ShopProducts> genericRepository,
            IHostingEnvironment hostingEnvironment,
            ITransactionLogService transactionLogService,
            IGenericRepository<Files> filesRepository
            )
        {
            _shopProductRepository = genericRepository;
            _hostingEnvironment = hostingEnvironment;
            _filesRepository = filesRepository;
            _transactionLogService = transactionLogService;

        }

        public async Task<List<string>> GetAllManufacturerProduct()
        {
            return await _shopProductRepository.AsQueryable()
                .Select(q => q.ManufacturerProduct)
                .Distinct()
                .ToListAsync();
        }

 
        public async Task<List<ShopProductModel>> GetAllShopProductsAsync(FilterParam param)
        {
            var query = _shopProductRepository.AsQueryable();
                

            if (param.Manufacturer != string.Empty && param.Manufacturer != null && param.Manufacturer != "Не выбрано")
            {
                query = query.Where(s => s.ManufacturerProduct == param.Manufacturer);
            }

            if (param.PriceFrom != null && param.PriceBefore != null)
            {
                query = query.Where(s => s.PriceProduct >= param.PriceFrom && s.PriceProduct <= param.PriceBefore);
            }

            else if (param.PriceFrom == null && param.PriceBefore != null)
            {
                query = query.Where(s => s.PriceProduct >= 0 && s.PriceProduct <= param.PriceBefore);
            }

            else if (param.PriceFrom != null && param.PriceBefore == null)
            {
                query = query.Where(s => s.PriceProduct >= param.PriceFrom && s.PriceProduct <= 99999999);
            }

            if (param.Avaliable == true)
            { 
                query = query.Where(s => s.IsAvaliable == param.Avaliable);
            }

            await query
                .Include(q => q.Files)
                .Include(q => q.Discounts)
                .OrderByDescending(s => s.Id)
                .ToListAsync();

            var result = new List<ShopProductModel>();


            foreach (var item in query)
            {
                result.Add(
                    new ShopProductModel()
                    {
                        Id = item.Id,
                        DescriptionProduct = item.DescriptionProduct,
                        IsAvaliable = item.IsAvaliable,
                        ManufacturerProduct = item.ManufacturerProduct,
                        PriceProduct = item.Discounts == null ? item.PriceProduct : PriceHelper.GetPriceWithDiscount(item.PriceProduct, item.Discounts),
                        ProductName = item.ProductName,
                        TypeProdycts = EnumHelper.GetDescription(item.TypeProdyctsEnum),
                        Discount = PriceHelper.IsDiscountExpired(item.Discounts),
                        FilePatch = item.Files != null? item.Files.FilePatch : string.Empty
                    }
                );
            }

            return result;
        }

        public async Task<List<ShopProductModel>> GetShopProductsForMainPageAsync()
        {
            var entity = await _shopProductRepository.AsQueryable()
                .Include(q=>q.Discounts)
                .Include(q => q.Files)
                .OrderByDescending(s => s.Id)
                .Take(8)
                .ToListAsync();

             var result = new List<ShopProductModel>();

            foreach (var item in entity)
            {
                result.Add(
                    new ShopProductModel()
                    {
                        Id = item.Id,
                        DescriptionProduct = item.DescriptionProduct,
                        IsAvaliable = item.IsAvaliable,
                        ManufacturerProduct = item.ManufacturerProduct,
                        PriceProduct = item.Discounts == null ? item.PriceProduct : PriceHelper.GetPriceWithDiscount(item.PriceProduct, item.Discounts),
                        ProductName = item.ProductName,
                        TypeProdycts = EnumHelper.GetDescription(item.TypeProdyctsEnum),
                        Discount = PriceHelper.IsDiscountExpired(item.Discounts),
                        FilePatch = item.Files != null ? item.Files.FilePatch : "/img/404.jpg"
                    }
                );
            }

            return result;
        }
        public async Task AddNewShopProductAsync(ShopProductParam param)
        {
            Files fileEntity = null;

            try
            {
                if (param.DescriptionProduct == null || param.ManufacturerProduct == null || param.PriceProduct == 0 || param.ProductName == null)
                {
                    throw new ApplicationException(StringConst.NotFilled);
                }

                if (param.FormFile != null)
                {

                    if (param.FormFile.ContentType != "image/jpeg" && param.FormFile.ContentType != "image/png")
                    {
                        throw new ApplicationException(StringConst.ErrorTypeFile);
                    }

                    Guid guid = Guid.NewGuid();
                    string UniquefileName = guid.ToString() + ".jpg";

                    string path = "/img/" + UniquefileName;
                    using (var fileStream = new FileStream(_hostingEnvironment.WebRootPath + path, FileMode.Create))
                    {
                        await param.FormFile.CopyToAsync(fileStream);
                    }

                    fileEntity = new Files()
                    {
                        FileName = param.FormFile.FileName,
                        FilePatch = path,
                        UniqueName = guid
                    };

                    await _filesRepository.AddAsync(fileEntity);

                }


                ShopProducts entity = new ShopProducts
                {
                    ProductName = param.ProductName,
                    PriceProduct = param.PriceProduct,
                    ManufacturerProduct = param.ManufacturerProduct,
                    DescriptionProduct = param.DescriptionProduct,
                    IsAvaliable = param.IsAvaliable == "В наличии",
                    TypeProdyctsEnum = EnumHelper.GetTypeProductsEnum(param.TypeProdycts),
                    ShopId = 1
                };

                if (param.FormFile != null)
                {
                    entity.FilesId = fileEntity.Id;
                }
                await _shopProductRepository.AddAsync(entity);
                await SaveLog(CreateLogParam.GetParamForShopProducts(entity), OperationEnum.AddProduct, null);
            }
            catch (ApplicationException ex)
            {
                await SaveLog(null, OperationEnum.AddProduct, ex);
            }
        }

        public async Task<ShopProductModel> GetShopProductByIdAsync(int id)
        {
            var entity = await _shopProductRepository.AsQueryable()
                .Include(q => q.Files)
                .Include(q => q.Discounts)
                .Where(q => q.Id == id)
                .FirstOrDefaultAsync();

            ShopProductModel result = new ShopProductModel()
            {
                Id = entity.Id,
                DescriptionProduct = entity.DescriptionProduct,
                IsAvaliable = entity.IsAvaliable,
                ManufacturerProduct = entity.ManufacturerProduct,
                PriceProduct = entity.PriceProduct,
                ProductName = entity.ProductName,
                TypeProdycts = EnumHelper.GetDescription(entity.TypeProdyctsEnum),
                Discount = PriceHelper.IsDiscountExpired(entity.Discounts),
                FilePatch = entity.Files != null ? entity.Files.FilePatch : "/img/404.jpg"

            };

            return result;
        }

        public async Task EditShopProductAsync(ShopProductParam param)
        {
            var entity = await _shopProductRepository.GetByIdAsync(param.Id);

            Files fileEntity = null;

            if (param.FormFile != null)
            {
                Guid guid = Guid.NewGuid();
                string UniquefileName = guid.ToString() + ".jpg";

                string path = "/img/" + UniquefileName;
                using (var fileStream = new FileStream(_hostingEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await param.FormFile.CopyToAsync(fileStream);
                }

                var files = await _filesRepository.GetByIdAsync(entity.FilesId);

                if (files != null)
                {
                    files.FileName = param.FormFile.FileName;
                    files.FilePatch = path;
                    files.UniqueName = guid;

                    await _filesRepository.SaveChangesAsync();
                }
                else {
                    fileEntity = new Files()
                    {
                        FileName = param.FormFile.FileName,
                        FilePatch = path,
                        UniqueName = guid
                    };

                    await _filesRepository.AddAsync(fileEntity);
                }

            }

            entity.ProductName = param.ProductName;
            entity.PriceProduct = param.PriceProduct;
            entity.ManufacturerProduct = param.ManufacturerProduct;
            entity.DescriptionProduct = param.DescriptionProduct;
            entity.IsAvaliable = param.IsAvaliable == "В наличии";
            entity.TypeProdyctsEnum = EnumHelper.GetTypeProductsEnum(param.TypeProdycts);

            if (entity.FilesId == null && param.FormFile != null)
            {
                entity.FilesId = fileEntity.Id;
            }
            await _shopProductRepository.SaveChangesAsync();
        }

        public async Task DeleteShopProductAsync(int id)
        {
            var entity =  await _shopProductRepository.GetByIdAsync(id);

            if (entity.Files != null)
            {
                await _filesRepository.DeleteAsync(entity.FilesId);
            }

            await _shopProductRepository.DeleteAsync(id);
        }

        public async Task SaveLog(SaveLogParam? param, OperationEnum operationEvent, ApplicationException? exception)
        {
           await _transactionLogService.AddTransactionLogAsync(param, operationEvent, exception);
        }
    }
}
