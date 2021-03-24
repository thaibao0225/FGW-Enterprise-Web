using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FGW_Enterprise_Web.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("360e601e-92f2-4f08-832b-604a21293258"), new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb4fd") });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "role_Descrpition", "role_Name" },
                values: new object[] { new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb4fd"), "3dfbc043-4c5d-4ce0-994c-d7384eed197c", null, "admin", "Adminstrator role", "admin" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DOB", "user_Email", "user_FullName", "user_LastLoginDate", "user_Name", "user_Password", "user_PhoneNumber" },
                values: new object[] { new Guid("360e601e-92f2-4f08-832b-604a21293258"), 0, "68aa0634-5c36-4035-ab8d-01e8b0a48999", null, true, false, null, "nhuvtqgcs18612@fpt.edu.vn", "admin", null, null, false, "", false, null, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "nhuvtqgcs18612@fpt.edu.vn", "VoThiQUynhNhu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", "AQAAAAEAACcQAAAAEHe0/o82Fac82YR54Rr/vXvynbKRmLN0bssHx+fyM46r05OxqlYu+Qmq8zPSfl/Kgg==", "0337779292" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("360e601e-92f2-4f08-832b-604a21293258"), new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb4fd") });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb4fd"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("360e601e-92f2-4f08-832b-604a21293258"));
        }
    }
}
