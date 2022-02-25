using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_commerce.API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassificationDetails",
                columns: table => new
                {
                    ID_thc = table.Column<int>(type: "int", nullable: false),
                    ID_phan_loai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassificationDetails", x => new { x.ID_phan_loai, x.ID_thc });
                });

            migrationBuilder.CreateTable(
                name: "Classifies",
                columns: table => new
                {
                    ID_phan_loai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten_phan_loai = table.Column<string>(type: "nvarchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classifies", x => x.ID_phan_loai);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID_KH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten_KH = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    SDT = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    dia_chi = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    ngay_sinh = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID_KH);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatuses",
                columns: table => new
                {
                    ID_TTDH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tinh_trang_DH = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuses", x => x.ID_TTDH);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    ID_Rating = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_KH = table.Column<int>(type: "int", nullable: false),
                    ID_thc = table.Column<int>(type: "int", nullable: false),
                    noi_dung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    so_sao = table.Column<int>(type: "int", nullable: false),
                    tinh_trang = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.ID_Rating);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    Id_thc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten_thc = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    gioi_thieu = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    mo_ta = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    sl_ton = table.Column<int>(type: "int", nullable: false),
                    gia_nhap = table.Column<int>(type: "int", nullable: false),
                    gia_ban = table.Column<int>(type: "int", nullable: false),
                    hinh_anh = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    ClassificationDetailID_phan_loai = table.Column<int>(type: "int", nullable: true),
                    ClassificationDetailID_thc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.Id_thc);
                    table.ForeignKey(
                        name: "FK_Medicines_ClassificationDetails_ClassificationDetailID_phan_loai_ClassificationDetailID_thc",
                        columns: x => new { x.ClassificationDetailID_phan_loai, x.ClassificationDetailID_thc },
                        principalTable: "ClassificationDetails",
                        principalColumns: new[] { "ID_phan_loai", "ID_thc" });
                });

            migrationBuilder.CreateTable(
                name: "ClassificationDetailClassify",
                columns: table => new
                {
                    ClassifiesID_phan_loai = table.Column<int>(type: "int", nullable: false),
                    ClassificationDetailsID_phan_loai = table.Column<int>(type: "int", nullable: false),
                    ClassificationDetailsID_thc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassificationDetailClassify", x => new { x.ClassifiesID_phan_loai, x.ClassificationDetailsID_phan_loai, x.ClassificationDetailsID_thc });
                    table.ForeignKey(
                        name: "FK_ClassificationDetailClassify_ClassificationDetails_ClassificationDetailsID_phan_loai_ClassificationDetailsID_thc",
                        columns: x => new { x.ClassificationDetailsID_phan_loai, x.ClassificationDetailsID_thc },
                        principalTable: "ClassificationDetails",
                        principalColumns: new[] { "ID_phan_loai", "ID_thc" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassificationDetailClassify_Classifies_ClassifiesID_phan_loai",
                        column: x => x.ClassifiesID_phan_loai,
                        principalTable: "Classifies",
                        principalColumn: "ID_phan_loai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CusAccounts",
                columns: table => new
                {
                    ID_TKKH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tai_khoan_KH = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    mat_khau = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    ID_KH = table.Column<int>(type: "int", nullable: false),
                    CustomersID_KH = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CusAccounts", x => x.ID_TKKH);
                    table.ForeignKey(
                        name: "FK_CusAccounts_Customers_CustomersID_KH",
                        column: x => x.CustomersID_KH,
                        principalTable: "Customers",
                        principalColumn: "ID_KH");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID_Order = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_KH = table.Column<int>(type: "int", nullable: false),
                    ngay_dat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngay_nhan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ghi_chu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ship = table.Column<int>(type: "int", nullable: false),
                    tong = table.Column<int>(type: "int", nullable: false),
                    ID_TTDH = table.Column<int>(type: "int", nullable: false),
                    OrderStatusID_TTDH = table.Column<int>(type: "int", nullable: true),
                    CustomersID_KH = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID_Order);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomersID_KH",
                        column: x => x.CustomersID_KH,
                        principalTable: "Customers",
                        principalColumn: "ID_KH");
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatuses_OrderStatusID_TTDH",
                        column: x => x.OrderStatusID_TTDH,
                        principalTable: "OrderStatuses",
                        principalColumn: "ID_TTDH");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    ID_Order = table.Column<int>(type: "int", nullable: false),
                    ID_thc = table.Column<int>(type: "int", nullable: false),
                    so_luong = table.Column<int>(type: "int", nullable: false),
                    tong_gia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.ID_Order, x.ID_thc });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Medicines_ID_thc",
                        column: x => x.ID_thc,
                        principalTable: "Medicines",
                        principalColumn: "Id_thc",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_ID_Order",
                        column: x => x.ID_Order,
                        principalTable: "Orders",
                        principalColumn: "ID_Order",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassificationDetailClassify_ClassificationDetailsID_phan_loai_ClassificationDetailsID_thc",
                table: "ClassificationDetailClassify",
                columns: new[] { "ClassificationDetailsID_phan_loai", "ClassificationDetailsID_thc" });

            migrationBuilder.CreateIndex(
                name: "IX_CusAccounts_CustomersID_KH",
                table: "CusAccounts",
                column: "CustomersID_KH");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_ClassificationDetailID_phan_loai_ClassificationDetailID_thc",
                table: "Medicines",
                columns: new[] { "ClassificationDetailID_phan_loai", "ClassificationDetailID_thc" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ID_thc",
                table: "OrderDetails",
                column: "ID_thc");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomersID_KH",
                table: "Orders",
                column: "CustomersID_KH");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderStatusID_TTDH",
                table: "Orders",
                column: "OrderStatusID_TTDH");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassificationDetailClassify");

            migrationBuilder.DropTable(
                name: "CusAccounts");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Classifies");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ClassificationDetails");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OrderStatuses");
        }
    }
}
