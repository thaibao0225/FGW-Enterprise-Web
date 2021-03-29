using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FGW_Enterprise_Web.Data.Migrations
{
    public partial class UserImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserImage",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    UrlImg = table.Column<string>(maxLength: 200, nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserImage_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb4fd"),
                column: "ConcurrencyStamp",
                value: "8a8e7210-ee1d-4e2c-a3be-f10c21558841");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("360e601e-92f2-4f08-832b-604a21293258"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0d89484f-2ec5-4559-a9a0-03b86f315396", "AQAAAAEAACcQAAAAEEZnagQA9MBEstvs2gfcJ9QP+MX1QapWlwgZp5MCEcNsqdwYNqlpniYFwAzF5871NQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_UserImage_UserId",
                table: "UserImage",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserImage");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb4fd"),
                column: "ConcurrencyStamp",
                value: "336c81dc-e827-47bc-891d-9ae0d4206324");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("360e601e-92f2-4f08-832b-604a21293258"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a612f4f1-6aa5-4ba3-b7d0-60d008d25a3c", "AQAAAAEAACcQAAAAEK5XRgo9E+EFER/Z6Uo2oIHvJNnVTb7rumNauUdkVcNp4rr/ZfYxZ4CErk6DofsdYA==" });
        }
    }
}
