using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VelvetVeogue.Migrations
{
    /// <inheritdoc />
    public partial class addingNewColumnForTblItemDetails_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemType",
                table: "Tbl_ItemDetails",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemType",
                table: "Tbl_ItemDetails");
        }
    }
}
