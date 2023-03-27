using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Migrations
{
    public partial class UpdateEstoque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Estoques",
                keyColumn: "Id",
                keyValue: 1,
                column: "Data",
                value: new DateTime(2023, 3, 27, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Estoques",
                columns: new[] { "Id", "Data", "Fornecedor", "Nome", "Preco", "Quantidade" },
                values: new object[] { 2, new DateTime(2023, 7, 27, 12, 30, 0, 0, DateTimeKind.Unspecified), "Json Json", "Condicionador", 5, 90 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Estoques",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Estoques",
                keyColumn: "Id",
                keyValue: 1,
                column: "Data",
                value: new DateTime(2023, 3, 27, 15, 4, 9, 796, DateTimeKind.Local).AddTicks(4224));
        }
    }
}
