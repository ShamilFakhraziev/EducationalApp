using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationalApp.Migrations
{
    public partial class newinitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AspNetUsers_UserId1",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_UserId1",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Blogs");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Blogs",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_AspNetUsers_UserId",
                table: "Blogs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AspNetUsers_UserId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Blogs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba3b6228-b36e-4806-be6b-c6fb40cb3821",
                column: "ConcurrencyStamp",
                value: "20d30ffe-643b-4064-88c0-ad936ffdc701");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9dd2d53-8b9b-4501-af7c-8c5977fb292c",
                column: "ConcurrencyStamp",
                value: "f20cc9d3-72ea-46e2-81b0-316950941aaa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65388652-6daa-4fe5-9571-deec9515067f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a15c965-335c-42e4-a710-86bfcfda74aa", "AQAAAAEAACcQAAAAECR6hquz4BYJH60wnNAl6JogE0K0ZCdtZ4+tBVq/RcAJaH/yedOqe7a+SoLFwYQiNg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88004402-8e7c-4a33-bd0c-277c3b73bb7e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99849e2c-f048-4efe-8b37-d5131666d5fc", "AQAAAAEAACcQAAAAEB4T+Tz7CuwUvk+EUJeGW0o0hNSaxcBRgTwjMkZt6Bui7RvBCOJD6U06s3CT/Oxtug==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae0b4b86-c83c-4718-8de4-96b8a3aa8c11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7ae8443d-f2ae-4163-a779-f962b242bf78", "AQAAAAEAACcQAAAAEGNHONcpxf4Z3pydjOPPOdq+55TxpccbW4bCkoDVIGJacuLJ3EabgNHTy63svYpdqQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_UserId1",
                table: "Blogs",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_AspNetUsers_UserId1",
                table: "Blogs",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
