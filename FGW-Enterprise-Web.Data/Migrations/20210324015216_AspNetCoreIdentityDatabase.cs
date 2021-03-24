using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FGW_Enterprise_Web.Data.Migrations
{
    public partial class AspNetCoreIdentityDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_User_comment_User",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Permision_Role_per_RoleId",
                table: "Permision");

            migrationBuilder.DropForeignKey(
                name: "FK_RegisterEvent_User_resEvent_UserId",
                table: "RegisterEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Role_ur_RoleId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_ur_UserId",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "role_Id",
                keyValue: "001");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "role_Id",
                keyValue: "002");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "role_Id",
                keyValue: "003");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "role_Id",
                keyValue: "004");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "role_Id",
                keyValue: "005");

            migrationBuilder.DropColumn(
                name: "user_Id",
                table: "User");

            migrationBuilder.DropColumn(
                name: "role_Id",
                table: "Role");

            migrationBuilder.AlterColumn<Guid>(
                name: "ur_RoleId",
                table: "UserRole",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ur_UserId",
                table: "UserRole",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "User",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "User",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "User",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "User",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "User",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Role",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Role",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Role",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedName",
                table: "Role",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "resEvent_UserId",
                table: "RegisterEvent",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<Guid>(
                name: "per_RoleId",
                table: "Permision",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<Guid>(
                name: "comment_User",
                table: "Comment",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_User_comment_User",
                table: "Comment",
                column: "comment_User",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Permision_Role_per_RoleId",
                table: "Permision",
                column: "per_RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegisterEvent_User_resEvent_UserId",
                table: "RegisterEvent",
                column: "resEvent_UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Role_ur_RoleId",
                table: "UserRole",
                column: "ur_RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_ur_UserId",
                table: "UserRole",
                column: "ur_UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_User_comment_User",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Permision_Role_per_RoleId",
                table: "Permision");

            migrationBuilder.DropForeignKey(
                name: "FK_RegisterEvent_User_resEvent_UserId",
                table: "RegisterEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Role_ur_RoleId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_ur_UserId",
                table: "UserRole");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoleClaims");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "User");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "User");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "User");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "User");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "User");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "NormalizedName",
                table: "Role");

            migrationBuilder.AlterColumn<string>(
                name: "ur_RoleId",
                table: "UserRole",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "ur_UserId",
                table: "UserRole",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<string>(
                name: "user_Id",
                table: "User",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "role_Id",
                table: "Role",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "resEvent_UserId",
                table: "RegisterEvent",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "per_RoleId",
                table: "Permision",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "comment_User",
                table: "Comment",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "user_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "role_Id");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "role_Id", "role_Descrpition", "role_Name" },
                values: new object[,]
                {
                    { "001", "ffff", "Admin" },
                    { "002", "ffff", "Marketing Manager" },
                    { "003", "ffff", "Marketing Coordinator" },
                    { "004", "ffff", "Student" },
                    { "005", "ffff", "Guest" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_User_comment_User",
                table: "Comment",
                column: "comment_User",
                principalTable: "User",
                principalColumn: "user_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Permision_Role_per_RoleId",
                table: "Permision",
                column: "per_RoleId",
                principalTable: "Role",
                principalColumn: "role_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegisterEvent_User_resEvent_UserId",
                table: "RegisterEvent",
                column: "resEvent_UserId",
                principalTable: "User",
                principalColumn: "user_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Role_ur_RoleId",
                table: "UserRole",
                column: "ur_RoleId",
                principalTable: "Role",
                principalColumn: "role_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_ur_UserId",
                table: "UserRole",
                column: "ur_UserId",
                principalTable: "User",
                principalColumn: "user_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
