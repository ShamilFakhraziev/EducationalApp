using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationalApp.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Blogs",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba3b6228-b36e-4806-be6b-c6fb40cb3821",
                column: "ConcurrencyStamp",
                value: "673e3c08-c960-42c5-838f-c09d326a2faf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9dd2d53-8b9b-4501-af7c-8c5977fb292c",
                column: "ConcurrencyStamp",
                value: "cc2a2fed-f96b-4808-a6d4-fddae952ff30");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65388652-6daa-4fe5-9571-deec9515067f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "571e9241-e058-4cb6-bcda-0d44c72a140f", "AQAAAAEAACcQAAAAECdOZJoI02u5h2w8yRpCsWw8BVYMfR81HJ8SfjYCjNXnTxMzntb0Ya9Skqz62ue48Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88004402-8e7c-4a33-bd0c-277c3b73bb7e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23bd8867-c338-45e3-8d5d-5486fa04a39e", "AQAAAAEAACcQAAAAEG4AuHEs8KOxIVT30ZkZeFqLO/gl0NYBiAzeSadTQe7+TgOIqw74/AywlFx0o0rgeg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae0b4b86-c83c-4718-8de4-96b8a3aa8c11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "897170d3-eb2d-488e-ab3d-6dbd301c8b7f", "AQAAAAEAACcQAAAAEPgU3Qnf4PS+LnyMJfwuo0Efp6+JvQvPU99TByX5U8I5EyoGoQuyzwH+AYepmVzX7Q==" });
        }
    }
}
