using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VelvetVeogue.Migrations
{
    /// <inheritdoc />
    public partial class changingSizeOftheTblItemDetailTableSizeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "size",
                table: "Tbl_ItemDetails",
                type: "varchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "size",
                table: "Tbl_ItemDetails",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)");
        }
    }
}
