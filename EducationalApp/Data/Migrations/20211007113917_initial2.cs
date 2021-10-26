using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationalApp.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "Blogs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba3b6228-b36e-4806-be6b-c6fb40cb3821",
                column: "ConcurrencyStamp",
                value: "07aae8e1-ab78-4362-9832-42d69d51b84c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9dd2d53-8b9b-4501-af7c-8c5977fb292c",
                column: "ConcurrencyStamp",
                value: "9e688441-7971-4447-b234-1cb3342a7e39");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65388652-6daa-4fe5-9571-deec9515067f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d53c8427-196e-4179-ae92-8d76a2994bda", "AQAAAAEAACcQAAAAECGLozMp70rfWfCbvSB83jVgPBLi1FoZkxFg8OZot/o30HbX4/R9JyjQN4y3cSDK6g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88004402-8e7c-4a33-bd0c-277c3b73bb7e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2ac8fd52-3603-4722-81bc-7bb60e602429", "AQAAAAEAACcQAAAAELtL6UhViWLZgeV2n9gkuBexL/YVInPrDe3B7PGSEnnAfLfxQG3f/y4a7Bpt2HYfvA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae0b4b86-c83c-4718-8de4-96b8a3aa8c11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1a0c19e-9dea-4107-8058-f905ed4d3cf8", "AQAAAAEAACcQAAAAEJyxlzF8hLTHkGTHMS8p7923OSdRQiJ5deVkWU9NLT9w+tCFas9fvY+EXz+P1K37XA==" });
        }
    }
}
