using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationalApp.Migrations
{
    public partial class blogsinitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba3b6228-b36e-4806-be6b-c6fb40cb3821",
                column: "ConcurrencyStamp",
                value: "462c9bc8-7440-42d6-a385-5995725943dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9dd2d53-8b9b-4501-af7c-8c5977fb292c",
                column: "ConcurrencyStamp",
                value: "d5520839-68ce-4f51-a896-de808e4ea192");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65388652-6daa-4fe5-9571-deec9515067f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "632976fb-522c-4e99-894d-d170493cc3af", "AQAAAAEAACcQAAAAEAeBdgTS24b2nlu1oxKNuqmiIWMF9jcI25MgvqAsKM69WmpTIsl/nV/LUi2YlJrQMg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88004402-8e7c-4a33-bd0c-277c3b73bb7e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8ab71e3-9a27-4a89-9ed2-70e4e736d94c", "AQAAAAEAACcQAAAAEBGjWf7OCADhGg5xXiTndTM3bBt4NeII5IewYhXFHI7Ao5A/+EmYwK90YaaUUBTsUg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae0b4b86-c83c-4718-8de4-96b8a3aa8c11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8040dd6-fee1-4402-9864-bd67d787e0f3", "AQAAAAEAACcQAAAAEFREKADc10tYvVIlO5AK+ug3jQRijyAB+N+SMuQPMBNpIeUhAIt5ldtTVJ1U52jO6Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba3b6228-b36e-4806-be6b-c6fb40cb3821",
                column: "ConcurrencyStamp",
                value: "5b62bc53-948b-4a42-91f1-52e1d1a59241");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9dd2d53-8b9b-4501-af7c-8c5977fb292c",
                column: "ConcurrencyStamp",
                value: "3d67c7f2-7f40-417d-8ed6-1552ca7c7eb2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65388652-6daa-4fe5-9571-deec9515067f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "73cd6701-676e-496c-a21d-b9397cc4e543", "AQAAAAEAACcQAAAAEPXkRFLU2DmZWfmqUkele9kNPJ9/lkAH5kjjdShsxpIn4H+zDOx+z5FYQuv4ULLRww==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88004402-8e7c-4a33-bd0c-277c3b73bb7e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8f0224d2-7ab5-49dc-a9ee-68fce58876ae", "AQAAAAEAACcQAAAAEHH56+K8lxAPEH8uIIk8mK2w3gXLnMse5TcwzFOWSPM+zmYp0GY33Qt96MhYO2ih1Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae0b4b86-c83c-4718-8de4-96b8a3aa8c11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e2e2271f-ea0b-496c-b80c-0abff28550ad", "AQAAAAEAACcQAAAAEBKtkgUZvfVhsV4Ggl527ABhIIxNu6YLSYRuOZjL2d2tEEAyOmwYqySYzu3SVxKtDA==" });
        }
    }
}
