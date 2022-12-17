using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrowdfundingSite.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CampaignId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CrowdUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Stars = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_AspNetUsers_CrowdUserId",
                        column: x => x.CrowdUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ratings_Campaigns_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_CampaignId",
                table: "Ratings",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_CrowdUserId",
                table: "Ratings",
                column: "CrowdUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5207a125-9669-4216-8b8f-9b7bad955cd7",
                column: "ConcurrencyStamp",
                value: "d5de16f3-5afb-4656-abee-439f18db9c23");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbae22d3-d74c-4ec5-9212-512965d5cd86",
                column: "ConcurrencyStamp",
                value: "9b7d12d5-f50b-44bc-a931-bd468b386ad4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a19e0bd9-aea5-4170-9e52-8a4903564910",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b52c6dc5-a557-4b0a-a5ab-d9a4dcf69759", "AQAAAAEAACcQAAAAED8CHsvaUvpt2OqbKZjhV00vjpBACJMhwhxYRzSK9jtAG+/vqVtUdN/Mo4yipzRkBA==" });
        }
    }
}
