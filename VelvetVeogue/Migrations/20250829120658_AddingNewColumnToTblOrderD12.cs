using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VelvetVeogue.Migrations
{
    /// <inheritdoc />
    public partial class AddingNewColumnToTblOrderD12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CVCNO",
                table: "Tbl_OrderDetails",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "img",
                table: "Tbl_OrderDetails",
                type: "varbinary",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CVCNO",
                table: "Tbl_OrderDetails");

            migrationBuilder.DropColumn(
                name: "img",
                table: "Tbl_OrderDetails");
        }
    }
}
