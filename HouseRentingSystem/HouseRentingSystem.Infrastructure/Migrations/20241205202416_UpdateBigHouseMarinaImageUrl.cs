using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UpdateBigHouseMarinaImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edf8578d-a897-4635-81e0-33262e4ad1d2", "AQAAAAEAACcQAAAAEOrQU7jz8WDE5IzvAERLSoigY0e2/GdGi/KkeEmWVqES9RCCxHqTusMIQr+HtrfzLg==", "b66ed1ed-5e05-40ac-a69e-b2865b836e21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d9d87fe-2017-4008-91b1-05e1fe835956", "AQAAAAEAACcQAAAAEAM74P5XUy1noBszdg3LEpzyml7whkaB/t9EWJv5qxqf55UT2ZTktWszdPlQBTqfhQ==", "e30795bf-5956-4088-b61f-cd0a2c8db002" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5eda86c7-dfce-455f-aa92-b90667d8c513", "AQAAAAEAACcQAAAAENKitQDpfseERDpt9+el6yjQDK17jHV+eFDC21CYFDsh/BNgczSWSeLbJL/OraIbDw==", "5089d317-3018-41d7-bbf6-f644e9049e4d" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://images.squarespace-cdn.com/content/v1/614b8a3ca23b0a1609d011b0/1633600657482-RD46JYBH5UB94DFT8GFI/lofthouseresidences_hero_innovation2.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19eaeaa2-0107-49ae-8b59-5e2f7a926d52", "AQAAAAEAACcQAAAAEEQO5q0J73qKgG9g3JSI0ijX3OjppteN+q94G24+wTwOFBOJ0kITxG560BFtk0n0VA==", "c8e4ca3c-2171-497c-b4c6-f47c762ac668" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4a34659-2e28-4932-99c4-d366f0ae81d0", "AQAAAAEAACcQAAAAECA2bJgucEgBVfbhO9qN0Kb/vMNGPupyGthNiWfMVhodgPCNpboZanCOHvZN1Y6qBw==", "ce39b7ee-8c5c-4a1c-be9c-ee2766d54fae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24005c0f-5f61-4b26-8ec3-68365979f58e", "AQAAAAEAACcQAAAAEMZClwI4zRJcYQhyJ2rPF5xlrqKKo9OWAYFCN4tBapA85aqaq1t4JyMfXjVg+AsBkA==", "1029060d-bcf7-4d7d-9551-f0bb6b9e416f" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.luxury-architecture.net/wp-content/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg");
        }
    }
}
