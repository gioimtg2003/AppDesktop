using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuanLyKho.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrators",
                columns: table => new
                {
                    AdministratorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserName = table.Column<string>(type: "char(20)", nullable: false),
                    Password = table.Column<string>(type: "char(16)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: true),
                    Phone = table.Column<string>(type: "char(10)", nullable: true),
                    Role = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrators", x => x.AdministratorID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    Phone = table.Column<string>(type: "char(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    StockID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.StockID);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    UnitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.UnitID);
                });

            migrationBuilder.CreateTable(
                name: "ExportBills",
                columns: table => new
                {
                    ExportBillID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    AdministratorID = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportBills", x => x.ExportBillID);
                    table.ForeignKey(
                        name: "FK_ExportBills_Administrators_AdministratorID",
                        column: x => x.AdministratorID,
                        principalTable: "Administrators",
                        principalColumn: "AdministratorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExportBills_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImportBills",
                columns: table => new
                {
                    ImportBillID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false),
                    AdministratorID = table.Column<int>(type: "int", nullable: false),
                    StockID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportBills", x => x.ImportBillID);
                    table.ForeignKey(
                        name: "FK_ImportBills_Administrators_AdministratorID",
                        column: x => x.AdministratorID,
                        principalTable: "Administrators",
                        principalColumn: "AdministratorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImportBills_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImportBills_Stocks_StockID",
                        column: x => x.StockID,
                        principalTable: "Stocks",
                        principalColumn: "StockID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockDetails",
                columns: table => new
                {
                    StockDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<long>(type: "bigint", nullable: false),
                    StockID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockDetails", x => x.StockDetailID);
                    table.ForeignKey(
                        name: "FK_StockDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockDetails_Stocks_StockID",
                        column: x => x.StockID,
                        principalTable: "Stocks",
                        principalColumn: "StockID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockDetails_Units_UnitID",
                        column: x => x.UnitID,
                        principalTable: "Units",
                        principalColumn: "UnitID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExportBillDetails",
                columns: table => new
                {
                    ExportBillDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExportBillID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportBillDetails", x => x.ExportBillDetailID);
                    table.ForeignKey(
                        name: "FK_ExportBillDetails_ExportBills_ExportBillID",
                        column: x => x.ExportBillID,
                        principalTable: "ExportBills",
                        principalColumn: "ExportBillID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImportDetail",
                columns: table => new
                {
                    ImportDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImportBillID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportDetail", x => x.ImportDetailID);
                    table.ForeignKey(
                        name: "FK_ImportDetail_ImportBills_ImportBillID",
                        column: x => x.ImportBillID,
                        principalTable: "ImportBills",
                        principalColumn: "ImportBillID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImportDetail_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImportDetail_Units_UnitID",
                        column: x => x.UnitID,
                        principalTable: "Units",
                        principalColumn: "UnitID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExportProductDetails",
                columns: table => new
                {
                    ExportProductDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExportBillDetailID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    StockDetailID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportProductDetails", x => x.ExportProductDetailID);
                    table.ForeignKey(
                        name: "FK_ExportProductDetails_ExportBillDetails_ExportBillDetailID",
                        column: x => x.ExportBillDetailID,
                        principalTable: "ExportBillDetails",
                        principalColumn: "ExportBillDetailID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExportProductDetails_StockDetails_StockDetailID",
                        column: x => x.StockDetailID,
                        principalTable: "StockDetails",
                        principalColumn: "StockDetailID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Administrators",
                columns: new[] { "AdministratorID", "Email", "Name", "Password", "Phone", "Role", "Title", "UserName" },
                values: new object[] { 1, "Conggioi.pro264@gmail.com", "Nguyễn Công Giới", "admin", "0367093723", (byte)1, "Quản lý", "admin" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1L, "Bút bi Thiên Long 20Cây/hộp màu xanh", "Bút bi Thiên Long", 0 },
                    { 2L, "Thước kẻ 20cm hộp 30 cái", "Thước kẻ 20cm", 0 },
                    { 3L, "Giấy in văn phòng 1 thùng 20 xấp", "Giấy in văn phòng", 0 },
                    { 4L, "Bút lông viết bảng (màu xanh) hộp 10 cái", "Bút lông viết bảng (màu xanh)", 0 },
                    { 5L, "Gôm/Bút tẩy xóa", "Gôm/Bút tẩy xóa", 0 },
                    { 6L, "Dao kéo, Băng keo", "Dao kéo, Băng keo", 0 },
                    { 7L, "Túi đựng hồ sơ và tài liệu", "Túi đựng hồ sơ và tài liệu", 0 },
                    { 8L, "Sổ tay học từ vựng", "Sổ tay học từ vựng", 0 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "StockID", "Address", "Name" },
                values: new object[,]
                {
                    { 1, "639 Phạm Văn Bạch, Phường 15, Tân Bình, TPHCM", "Kho A" },
                    { 2, "200 Dương Đình Hội, Phường Phước Long B, Q.9, TPHCM", "Kho B" }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "UnitID", "Name" },
                values: new object[,]
                {
                    { 1, "Hộp" },
                    { 2, "Cái" },
                    { 3, "Thùng" },
                    { 4, "Chiếc" },
                    { 5, "Ram" },
                    { 6, "Xấp" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExportBillDetails_ExportBillID",
                table: "ExportBillDetails",
                column: "ExportBillID");

            migrationBuilder.CreateIndex(
                name: "IX_ExportBills_AdministratorID",
                table: "ExportBills",
                column: "AdministratorID");

            migrationBuilder.CreateIndex(
                name: "IX_ExportBills_CustomerID",
                table: "ExportBills",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ExportProductDetails_ExportBillDetailID",
                table: "ExportProductDetails",
                column: "ExportBillDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_ExportProductDetails_StockDetailID",
                table: "ExportProductDetails",
                column: "StockDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_ImportBills_AdministratorID",
                table: "ImportBills",
                column: "AdministratorID");

            migrationBuilder.CreateIndex(
                name: "IX_ImportBills_CustomerID",
                table: "ImportBills",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ImportBills_StockID",
                table: "ImportBills",
                column: "StockID");

            migrationBuilder.CreateIndex(
                name: "IX_ImportDetail_ImportBillID",
                table: "ImportDetail",
                column: "ImportBillID");

            migrationBuilder.CreateIndex(
                name: "IX_ImportDetail_ProductID",
                table: "ImportDetail",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ImportDetail_UnitID",
                table: "ImportDetail",
                column: "UnitID");

            migrationBuilder.CreateIndex(
                name: "IX_StockDetails_ProductID",
                table: "StockDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_StockDetails_StockID",
                table: "StockDetails",
                column: "StockID");

            migrationBuilder.CreateIndex(
                name: "IX_StockDetails_UnitID",
                table: "StockDetails",
                column: "UnitID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExportProductDetails");

            migrationBuilder.DropTable(
                name: "ImportDetail");

            migrationBuilder.DropTable(
                name: "ExportBillDetails");

            migrationBuilder.DropTable(
                name: "StockDetails");

            migrationBuilder.DropTable(
                name: "ImportBills");

            migrationBuilder.DropTable(
                name: "ExportBills");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Administrators");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
