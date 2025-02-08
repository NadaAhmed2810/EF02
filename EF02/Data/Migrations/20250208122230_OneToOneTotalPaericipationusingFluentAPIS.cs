using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF02.Data.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneTotalPaericipationusingFluentAPIS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DetailedAddress_BlockNumber",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DetailedAddress_City",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailedAddress_Country",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailedAddress_Street",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CreationDate",
                schema: "dbo",
                table: "Department",
                type: "date",
                nullable: false,
                computedColumnSql: "Cast(GETDATE() as Date)",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldComputedColumnSql: "GETDATE()");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailedAddress_BlockNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DetailedAddress_City",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DetailedAddress_Country",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DetailedAddress_Street",
                table: "Employees");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CreationDate",
                schema: "dbo",
                table: "Department",
                type: "date",
                nullable: false,
                computedColumnSql: "GETDATE()",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldComputedColumnSql: "Cast(GETDATE() as Date)");
        }
    }
}
