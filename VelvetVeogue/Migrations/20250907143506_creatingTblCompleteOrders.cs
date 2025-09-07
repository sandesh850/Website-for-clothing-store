using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VelvetVeogue.Migrations
{
    /// <inheritdoc />
    public partial class creatingTblCompleteOrders : Migration
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
                    paymentMethod = table.Column<string>(type: "varchar(70)", nullable: false),
                    cardDate = table.Column<string>(type: "varchar(10)", nullable: true),
                    img = table.Column<byte[]>(type: "varbinary", nullable: false),
                    CVCNO = table.Column<string>(type: "varchar(100)", nullable: true),
                    date = table.Column<DateTime>(type: "Date", nullable: true),
                    CardNo = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_CompleteOrders", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_CompleteOrders");
        }
    }
}
