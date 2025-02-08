using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF02.Data.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                schema: "dbo",
                table: "Department",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Department_ManagerId",
                schema: "dbo",
                table: "Department",
                column: "ManagerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Employees_ManagerId",
                schema: "dbo",
                table: "Department",
                column: "ManagerId",
                principalTable: "Employees",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Employees_ManagerId",
                schema: "dbo",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_ManagerId",
                schema: "dbo",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                schema: "dbo",
                table: "Department");
        }
    }
}
