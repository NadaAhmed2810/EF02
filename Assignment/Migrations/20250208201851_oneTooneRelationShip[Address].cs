using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class oneTooneRelationShipAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DetailedAddress_BlockNumber",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DetailedAddress_City",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailedAddress_Country",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailedAddress_Street",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DetailedAddress_BlockNumber",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DetailedAddress_City",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailedAddress_Country",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailedAddress_Street",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailedAddress_BlockNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DetailedAddress_City",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DetailedAddress_Country",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DetailedAddress_Street",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DetailedAddress_BlockNumber",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "DetailedAddress_City",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "DetailedAddress_Country",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "DetailedAddress_Street",
                table: "Instructors");
        }
    }
}
