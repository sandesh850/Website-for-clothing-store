using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VelvetVeogue.Migrations
{
    /// <inheritdoc />
    public partial class chnge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "Tbl_CompleteOrders",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "Tbl_CompleteOrders",
                type: "Date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);
        }
    }
}
