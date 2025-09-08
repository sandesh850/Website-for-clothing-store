using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VelvetVeogue.Migrations
{
    /// <inheritdoc />
    public partial class Initi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_CompleteOrders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category = table.Column<string>(type: "varchar(20)", nullable: false),
                    ItemType = table.Column<string>(type: "varchar(50)", nullable: false),
                    price = table.Column<decimal>(type: "money", nullable: false),
                    sizes = table.Column<string>(type: "varchar(20)", nullable: false),
                    color = table.Column<string>(type: "varchar(30)", nullable: false),
                    email = table.Column<string>(type: "varchar(50)", nullable: false),
                    address = table.Column<string>(type: "varchar(100)", nullable: false),
                    contactNo = table.Column<string>(type: "varchar(20)", nullable: false),
                    cardDate = table.Column<string>(type: "varchar(10)", nullable: true),
                    img = table.Column<byte[]>(type: "varbinary", nullable: false),
                    CVCNO = table.Column<string>(type: "varchar(100)", nullable: true),
                    date = table.Column<DateTime>(type: "DateTime", nullable: false),
                    CardNo = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_CompleteOrders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ContactUS",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ContactUS", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Inquiries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subject = table.Column<string>(type: "varchar(50)", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ContactNo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Inquiries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ItemDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemCode = table.Column<int>(type: "int", nullable: false),
                    CategoryName = table.Column<string>(type: "varchar(30)", nullable: false),
                    Name = table.Column<string>(type: "varchar(30)", nullable: false),
                    Color = table.Column<string>(type: "varchar(20)", nullable: false),
                    size = table.Column<string>(type: "varchar(10)", nullable: false),
                    AvailableQty = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    img = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ItemType = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ItemDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_OrderDetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category = table.Column<string>(type: "varchar(20)", nullable: false),
                    ItemType = table.Column<string>(type: "varchar(50)", nullable: false),
                    price = table.Column<decimal>(type: "money", nullable: false),
                    sizes = table.Column<string>(type: "varchar(20)", nullable: false),
                    color = table.Column<string>(type: "varchar(30)", nullable: false),
                    email = table.Column<string>(type: "varchar(50)", nullable: false),
                    address = table.Column<string>(type: "varchar(100)", nullable: false),
                    contactNo = table.Column<string>(type: "varchar(20)", nullable: false),
                    paymentMethod = table.Column<string>(type: "varchar(70)", nullable: false),
                    cardDate = table.Column<string>(type: "varchar(10)", nullable: true),
                    img = table.Column<byte[]>(type: "varbinary", nullable: false),
                    CVCNO = table.Column<string>(type: "varchar(100)", nullable: true),
                    date = table.Column<DateTime>(type: "DateTime", nullable: false),
                    CardNo = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_OrderDetails", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TblLogins",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "varchar(10)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblLogins", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_CompleteOrders");

            migrationBuilder.DropTable(
                name: "Tbl_ContactUS");

            migrationBuilder.DropTable(
                name: "Tbl_Inquiries");

            migrationBuilder.DropTable(
                name: "Tbl_ItemDetails");

            migrationBuilder.DropTable(
                name: "Tbl_OrderDetails");

            migrationBuilder.DropTable(
                name: "TblLogins");
        }
    }
}
