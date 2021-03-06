// <auto-generated />
using System;
using E_commerce.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_commerce.API.Migrations
{
    [DbContext(typeof(MedicineContext))]
    [Migration("20220224044421_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.1.22076.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClassificationDetailClassify", b =>
                {
                    b.Property<int>("ClassifiesID_phan_loai")
                        .HasColumnType("int");

                    b.Property<int>("ClassificationDetailsID_phan_loai")
                        .HasColumnType("int");

                    b.Property<int>("ClassificationDetailsID_thc")
                        .HasColumnType("int");

                    b.HasKey("ClassifiesID_phan_loai", "ClassificationDetailsID_phan_loai", "ClassificationDetailsID_thc");

                    b.HasIndex("ClassificationDetailsID_phan_loai", "ClassificationDetailsID_thc");

                    b.ToTable("ClassificationDetailClassify");
                });

            modelBuilder.Entity("E_commerce.API.Models.ClassificationDetail", b =>
                {
                    b.Property<int>("ID_phan_loai")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("ID_thc")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.HasKey("ID_phan_loai", "ID_thc");

                    b.ToTable("ClassificationDetails");
                });

            modelBuilder.Entity("E_commerce.API.Models.Classify", b =>
                {
                    b.Property<int>("ID_phan_loai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_phan_loai"), 1L, 1);

                    b.Property<string>("ten_phan_loai")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ID_phan_loai");

                    b.ToTable("Classifies");
                });

            modelBuilder.Entity("E_commerce.API.Models.CusAccount", b =>
                {
                    b.Property<int>("ID_TKKH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_TKKH"), 1L, 1);

                    b.Property<int?>("CustomersID_KH")
                        .HasColumnType("int");

                    b.Property<int>("ID_KH")
                        .HasColumnType("int");

                    b.Property<string>("mat_khau")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("tai_khoan_KH")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ID_TKKH");

                    b.HasIndex("CustomersID_KH");

                    b.ToTable("CusAccounts");
                });

            modelBuilder.Entity("E_commerce.API.Models.Customer", b =>
                {
                    b.Property<int>("ID_KH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_KH"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("SDT")
                        .HasColumnType("int");

                    b.Property<string>("dia_chi")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("ngay_sinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("ten_KH")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ID_KH");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("E_commerce.API.Models.Medicine", b =>
                {
                    b.Property<int>("Id_thc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_thc"), 1L, 1);

                    b.Property<int?>("ClassificationDetailID_phan_loai")
                        .HasColumnType("int");

                    b.Property<int?>("ClassificationDetailID_thc")
                        .HasColumnType("int");

                    b.Property<int>("gia_ban")
                        .HasColumnType("int");

                    b.Property<int>("gia_nhap")
                        .HasColumnType("int");

                    b.Property<string>("gioi_thieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("hinh_anh")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("mo_ta")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("sl_ton")
                        .HasColumnType("int");

                    b.Property<string>("ten_thc")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id_thc");

                    b.HasIndex("ClassificationDetailID_phan_loai", "ClassificationDetailID_thc");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("E_commerce.API.Models.Order", b =>
                {
                    b.Property<int>("ID_Order")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Order"), 1L, 1);

                    b.Property<int?>("CustomersID_KH")
                        .HasColumnType("int");

                    b.Property<int>("ID_KH")
                        .HasColumnType("int");

                    b.Property<int>("ID_TTDH")
                        .HasColumnType("int");

                    b.Property<int?>("OrderStatusID_TTDH")
                        .HasColumnType("int");

                    b.Property<string>("ghi_chu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngay_dat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngay_nhan")
                        .HasColumnType("datetime2");

                    b.Property<int>("ship")
                        .HasColumnType("int");

                    b.Property<int>("tong")
                        .HasColumnType("int");

                    b.HasKey("ID_Order");

                    b.HasIndex("CustomersID_KH");

                    b.HasIndex("OrderStatusID_TTDH");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("E_commerce.API.Models.OrderDetail", b =>
                {
                    b.Property<int>("ID_Order")
                        .HasColumnType("int");

                    b.Property<int>("ID_thc")
                        .HasColumnType("int");

                    b.Property<int>("so_luong")
                        .HasColumnType("int");

                    b.Property<int>("tong_gia")
                        .HasColumnType("int");

                    b.HasKey("ID_Order", "ID_thc");

                    b.HasIndex("ID_thc");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("E_commerce.API.Models.OrderStatus", b =>
                {
                    b.Property<int>("ID_TTDH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_TTDH"), 1L, 1);

                    b.Property<string>("tinh_trang_DH")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_TTDH");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("E_commerce.API.Models.Rating", b =>
                {
                    b.Property<int>("ID_Rating")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Rating"), 1L, 1);

                    b.Property<int>("ID_KH")
                        .HasColumnType("int");

                    b.Property<int>("ID_thc")
                        .HasColumnType("int");

                    b.Property<string>("noi_dung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("so_sao")
                        .HasColumnType("int");

                    b.Property<bool>("tinh_trang")
                        .HasColumnType("bit");

                    b.HasKey("ID_Rating");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("ClassificationDetailClassify", b =>
                {
                    b.HasOne("E_commerce.API.Models.Classify", null)
                        .WithMany()
                        .HasForeignKey("ClassifiesID_phan_loai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_commerce.API.Models.ClassificationDetail", null)
                        .WithMany()
                        .HasForeignKey("ClassificationDetailsID_phan_loai", "ClassificationDetailsID_thc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_commerce.API.Models.CusAccount", b =>
                {
                    b.HasOne("E_commerce.API.Models.Customer", "Customers")
                        .WithMany("CusAccounts")
                        .HasForeignKey("CustomersID_KH");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("E_commerce.API.Models.Medicine", b =>
                {
                    b.HasOne("E_commerce.API.Models.ClassificationDetail", null)
                        .WithMany("Medicines")
                        .HasForeignKey("ClassificationDetailID_phan_loai", "ClassificationDetailID_thc");
                });

            modelBuilder.Entity("E_commerce.API.Models.Order", b =>
                {
                    b.HasOne("E_commerce.API.Models.Customer", "Customers")
                        .WithMany("Orders")
                        .HasForeignKey("CustomersID_KH");

                    b.HasOne("E_commerce.API.Models.OrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusID_TTDH");

                    b.Navigation("Customers");

                    b.Navigation("OrderStatus");
                });

            modelBuilder.Entity("E_commerce.API.Models.OrderDetail", b =>
                {
                    b.HasOne("E_commerce.API.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("ID_Order")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_commerce.API.Models.Medicine", "Medicine")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ID_thc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicine");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("E_commerce.API.Models.ClassificationDetail", b =>
                {
                    b.Navigation("Medicines");
                });

            modelBuilder.Entity("E_commerce.API.Models.Customer", b =>
                {
                    b.Navigation("CusAccounts");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("E_commerce.API.Models.Medicine", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("E_commerce.API.Models.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
