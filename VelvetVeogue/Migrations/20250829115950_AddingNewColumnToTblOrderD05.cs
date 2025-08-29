using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VelvetVeogue.Migrations
{
    /// <inheritdoc />
    public partial class AddingNewColumnToTblOrderD05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Tbl_OrderDetails",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "contactNo",
                table: "Tbl_OrderDetails",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Tbl_OrderDetails",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "Tbl_OrderDetails");

            migrationBuilder.DropColumn(
                name: "contactNo",
                table: "Tbl_OrderDetails");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Tbl_OrderDetails");
        }
    }
}
