using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF02.Data.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneAndOneToManyRelationShipusingFluentAPIs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Employees_ManagerId",
                schema: "dbo",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Department_DepartmentId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Department_ManagerId",
                schema: "dbo",
                table: "Department");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                schema: "dbo",
                table: "Department",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Department_ManagerId",
                schema: "dbo",
                table: "Department",
                column: "ManagerId",
                unique: true,
                filter: "[ManagerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Employees_ManagerId",
                schema: "dbo",
                table: "Department",
                column: "ManagerId",
                principalTable: "Employees",
                principalColumn: "Code",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Department_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalSchema: "dbo",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Employees_ManagerId",
                schema: "dbo",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Department_DepartmentId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Department_ManagerId",
                schema: "dbo",
                table: "Department");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                schema: "dbo",
                table: "Department",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Department_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalSchema: "dbo",
                principalTable: "Department",
                principalColumn: "Id");
        }
    }
}
