using Microsoft.EntityFrameworkCore.Migrations;

namespace CrowdfundingSite.Migrations
{
    public partial class init_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5207a125-9669-4216-8b8f-9b7bad955cd7",
                column: "ConcurrencyStamp",
                value: "445e98c8-9f47-4d9a-a1e8-4827b73cdc54");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbae22d3-d74c-4ec5-9212-512965d5cd86",
                column: "ConcurrencyStamp",
                value: "23c077f6-3ecc-4941-8547-9c57c9d2b19d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a19e0bd9-aea5-4170-9e52-8a4903564910",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "607d67c1-5939-4337-80c6-f46e527588ac", "AQAAAAEAACcQAAAAEMhBUBzUqeB6OxQSCJm5H6C8d6Ik4RREQoeZIPgJWqpFMPG6g/mRU/MoO8eN8HtRnA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5207a125-9669-4216-8b8f-9b7bad955cd7",
                column: "ConcurrencyStamp",
                value: "21afe178-cd1d-4f92-8f1a-34f0ee0936b0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbae22d3-d74c-4ec5-9212-512965d5cd86",
                column: "ConcurrencyStamp",
                value: "51c35d9b-9549-441e-b66f-f41620e9a18c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a19e0bd9-aea5-4170-9e52-8a4903564910",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74a79413-169b-4365-aa6c-951bd3d60155", "AQAAAAEAACcQAAAAEK5Mv/LJtSjhDdN4dWqI3dV270PQb+xZNh9/5TqC7WP9PyDPsPW3CCbWstetRDLC/g==" });
        }
    }
}
