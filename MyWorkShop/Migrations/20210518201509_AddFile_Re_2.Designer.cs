// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWorkShop.AppData;

namespace MyWorkShop.Migrations
{
    [DbContext(typeof(DbWorkShopContext))]
    [Migration("20210518201509_AddFile_Re_2")]
    partial class AddFile_Re_2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyWorkShop.Entities.Buyers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("MyWorkShop.Entities.Discounts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("datetime2");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<bool>("DiscountAvailability")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("MyWorkShop.Entities.Files", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePatch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UniqueName")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("File");
                });

            modelBuilder.Entity("MyWorkShop.Entities.Forum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateText")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("Forum");
                });

            modelBuilder.Entity("MyWorkShop.Entities.Purchases", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuyersId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePurchases")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BuyersId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("MyWorkShop.Entities.ServiceApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ApplicationData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ServiceDeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ServiceStatusEnum")
                        .HasColumnType("int");

                    b.Property<int>("ShopServicesId")
                        .HasColumnType("int");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ShopServicesId");

                    b.ToTable("ServiceApplication");
                });

            modelBuilder.Entity("MyWorkShop.Entities.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ShopAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShopName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShopPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("MyWorkShop.Entities.ShopProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionProduct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DiscountsId")
                        .HasColumnType("int");

                    b.Property<int?>("FilesId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvaliable")
                        .HasColumnType("bit");

                    b.Property<string>("ManufacturerProduct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PriceProduct")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.Property<int>("TypeProdyctsEnum")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DiscountsId");

                    b.HasIndex("FilesId")
                        .IsUnique()
                        .HasFilter("[FilesId] IS NOT NULL");

                    b.HasIndex("ShopId");

                    b.ToTable("ShopProducts");
                });

            modelBuilder.Entity("MyWorkShop.Entities.ShopServices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionService")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DiscountsId")
                        .HasColumnType("int");

                    b.Property<decimal>("PriceService")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ServicesName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DiscountsId");

                    b.HasIndex("ShopId");

                    b.ToTable("ShopServices");
                });

            modelBuilder.Entity("MyWorkShop.Entities.TestTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumberOne")
                        .HasColumnType("int");

                    b.Property<int>("NumberThree")
                        .HasColumnType("int");

                    b.Property<int>("NumberTwo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TestTables");
                });

            modelBuilder.Entity("PurchasesShopProducts", b =>
                {
                    b.Property<int>("PurchasesId")
                        .HasColumnType("int");

                    b.Property<int>("ShopProductsId")
                        .HasColumnType("int");

                    b.HasKey("PurchasesId", "ShopProductsId");

                    b.HasIndex("ShopProductsId");

                    b.ToTable("PurchasesShopProducts");
                });

            modelBuilder.Entity("MyWorkShop.Entities.Forum", b =>
                {
                    b.HasOne("MyWorkShop.Entities.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("MyWorkShop.Entities.Purchases", b =>
                {
                    b.HasOne("MyWorkShop.Entities.Buyers", "Buyers")
                        .WithMany()
                        .HasForeignKey("BuyersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buyers");
                });

            modelBuilder.Entity("MyWorkShop.Entities.ServiceApplication", b =>
                {
                    b.HasOne("MyWorkShop.Entities.ShopServices", "ShopServices")
                        .WithMany()
                        .HasForeignKey("ShopServicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShopServices");
                });

            modelBuilder.Entity("MyWorkShop.Entities.ShopProducts", b =>
                {
                    b.HasOne("MyWorkShop.Entities.Discounts", "Discounts")
                        .WithMany()
                        .HasForeignKey("DiscountsId");

                    b.HasOne("MyWorkShop.Entities.Files", "Files")
                        .WithOne("ShopProducts")
                        .HasForeignKey("MyWorkShop.Entities.ShopProducts", "FilesId");

                    b.HasOne("MyWorkShop.Entities.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discounts");

                    b.Navigation("Files");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("MyWorkShop.Entities.ShopServices", b =>
                {
                    b.HasOne("MyWorkShop.Entities.Discounts", "Discounts")
                        .WithMany()
                        .HasForeignKey("DiscountsId");

                    b.HasOne("MyWorkShop.Entities.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discounts");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("PurchasesShopProducts", b =>
                {
                    b.HasOne("MyWorkShop.Entities.Purchases", null)
                        .WithMany()
                        .HasForeignKey("PurchasesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyWorkShop.Entities.ShopProducts", null)
                        .WithMany()
                        .HasForeignKey("ShopProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyWorkShop.Entities.Files", b =>
                {
                    b.Navigation("ShopProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
