using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWorkShop.AppData;
using MyWorkShop.Entities;
using MyWorkShop.Enums;
using MyWorkShop.Helper;
using MyWorkShop.Interfaces;
using MyWorkShop.Models;
using MyWorkShop.Param;
using MyWorkShop.Repository;

namespace MyWorkShop.Services
{
    public class MainServices : IMainServices
    {
        /*  private readonly IPurchasesRepository PurchasesRepository;

          private readonly IShopServicesRepository ShopServicesRepository;

          private readonly IServiceApplicationRepository ServiceApplicationRepository;

          private readonly IForumRepository ForumRepository;

          public MainServices(
              IPurchasesRepository purchasesRepository,
              IShopServicesRepository shopServicesRepository,
              IServiceApplicationRepository serviceApplicationRepository,
              IForumRepository forumRepository
              )
          {
              PurchasesRepository = purchasesRepository;
              ShopServicesRepository = shopServicesRepository;
              ServiceApplicationRepository = serviceApplicationRepository;
              ForumRepository = forumRepository;
          }

          public void SendServiceApplication(ServiceApplicationParam param)
          {
              var entity = new ServiceApplication()
              {
                  ApplicationData = DateTime.Now,
                  Fio = param.Fio,
                  Email = param.Email,
                  Description = param.Description,
                  Telephone = param.Telephone,
                  ServiceStatusEnum = ServiceStatusEnum.InConsideration,
                  ShopServicesId = param.Id
              };

              ServiceApplicationRepository.AddServiceApplication(entity);
          }

          public List<ForumMessegeModel> GetAllForumMesseges()
          {
              var entity = ForumRepository.GetAllForumMesseges();

              List<ForumMessegeModel> forumMessegeModel = new List<ForumMessegeModel>();

              foreach (var item in entity)
              {
                  forumMessegeModel.Add(
                      new ForumMessegeModel()
                      {
                          Fio = item.Fio,
                          Text = item.Text,
                          DateText = item.DateText
                      }
                  );

              }

              return forumMessegeModel;
          }

          public void AddNewMessage(ForumMessegeParam param)
          {
              var entity = new Forum()
              {
                  Fio = param.Fio,
                  DateText = DateTime.Now,
                  ShopId = 1,
                  Text = param.Text
              };

              ForumRepository.AddNewMessage(entity);
          }

          private TypeProductsEnum GetTypeProductsEnum(string enumString)
          {
              switch (enumString)
              {
                  case "Клава": return TypeProductsEnum.Klava;
                  case "Ноуты": return TypeProductsEnum.Noyt;
                  case "Колонка": return TypeProductsEnum.Kolonka;
                  case "Мышки": return TypeProductsEnum.Mouse;
                  case "Мониторы": return TypeProductsEnum.Monitor;
              }
              return TypeProductsEnum.Undefined;
          }

          private decimal GetPriceWithDiscount(decimal price, Discounts discount)
          {
             return discount.DiscountAvailability? price - (price / 100) * discount.Discount : price; 
          }

          private int IsDiscountExpired(Discounts discount)
          {
              //Если скидки нет
              if (discount == null) return 0;

              //Если скидка не просрочена
              if (discount.DiscountAvailability)
              {
                  return discount.Discount;
              }
              else
              {
                  return 0;   //Если скидка просрочена
              }
          }
      }
        */
    }
}
