using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CursoAspNETCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "10400 Northeast Fourth Street Floor 14 Bellevue, WA 98004", "USA", "Valve Corporation" },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Rua Abdon Batista 342, Centro", "Brazil", "Fulltech Pro Ltda" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[,]
                {
                    { new Guid("4f65bd25-9b59-4ad7-9f8e-a4bf0c38dbba"), 30, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Jana McLeaf", "Software developer" },
                    { new Guid("8eb65ea9-9563-440c-810c-d10f3dcf36c6"), 35, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Kane Miller", "Administrator" },
                    { new Guid("e46cf629-d056-4385-b6c2-0f919ce01c47"), 24, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Bruno Lemos", "Software developer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("4f65bd25-9b59-4ad7-9f8e-a4bf0c38dbba"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("8eb65ea9-9563-440c-810c-d10f3dcf36c6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("e46cf629-d056-4385-b6c2-0f919ce01c47"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));
        }
    }
}
