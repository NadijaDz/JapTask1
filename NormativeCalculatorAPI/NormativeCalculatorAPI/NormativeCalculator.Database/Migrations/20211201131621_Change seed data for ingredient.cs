using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Infrastructure.Migrations
{
    public partial class Changeseeddataforingredient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Recipes",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "RecipeCategories",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Ingredients",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 2m, false, 0m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 1m, false, 0m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 2m, false, 0m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 2m, false, 0m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 2m, false, 8m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 2m, false, 0m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 2m, false, 8m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 2m, false, 0m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 2m, false, 0m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 2m, false, 0m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 2m, false, 0m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 2m, false, 0m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 2m, false, 8m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 2m, false, 8m });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Recipes",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "RecipeCategories",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Ingredients",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 2000m, null, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 1000m, null, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 500m, null, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 500m, null, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 8m, null, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 500m, null, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 8m, null, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 500m, null, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 500m, null, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 500m, null, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 500m, null, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 500m, null, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 8m, null, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CostIngredient", "IsDeleted", "UnitPrice" },
                values: new object[] { 8m, null, 2m });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }
    }
}
