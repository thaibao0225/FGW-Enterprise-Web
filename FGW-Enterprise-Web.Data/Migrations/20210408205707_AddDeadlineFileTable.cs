using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FGW_Enterprise_Web.Data.Migrations
{
    public partial class AddDeadlineFileTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDefault",
                table: "UserFile",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "file_size",
                table: "UserFile",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "DeadlineCate",
                keyColumn: "dlCate_Id",
                keyValue: "00001",
                column: "dlCate_CreateDate",
                value: new DateTime(2021, 4, 9, 3, 57, 6, 830, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "DeadlineCate",
                keyColumn: "dlCate_Id",
                keyValue: "00002",
                column: "dlCate_CreateDate",
                value: new DateTime(2021, 4, 9, 3, 57, 6, 831, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb4fd"),
                column: "ConcurrencyStamp",
                value: "993a60f6-6625-4959-a26f-4437e7713a38");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb5ff"),
                column: "ConcurrencyStamp",
                value: "644e4d36-b758-4000-a553-ed7d32edf779");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("360e601e-92f2-4f08-832b-604a21293258"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7f15fadb-6973-45cc-8cf3-49c87ab4d3bb", "AQAAAAEAACcQAAAAEPP9cvGxw4ivKiVHAHlpsYc20hAhv2TZP+IkzhUi2phdSvFDWlP5sYXfXKVX0BbKpQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDefault",
                table: "UserFile");

            migrationBuilder.DropColumn(
                name: "file_size",
                table: "UserFile");

            migrationBuilder.UpdateData(
                table: "DeadlineCate",
                keyColumn: "dlCate_Id",
                keyValue: "00001",
                column: "dlCate_CreateDate",
                value: new DateTime(2021, 4, 8, 23, 55, 11, 946, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "DeadlineCate",
                keyColumn: "dlCate_Id",
                keyValue: "00002",
                column: "dlCate_CreateDate",
                value: new DateTime(2021, 4, 8, 23, 55, 11, 946, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb4fd"),
                column: "ConcurrencyStamp",
                value: "cd875d44-5e99-479d-89ee-21e32702375f");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb5ff"),
                column: "ConcurrencyStamp",
                value: "d02f1f24-223b-48d6-9f37-435454f87c47");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("360e601e-92f2-4f08-832b-604a21293258"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb17368c-8a9b-45c3-a174-eeee929ddf7f", "AQAAAAEAACcQAAAAEM94WImkY8Bvuk2c/GrMdgKU6CuK9Jp+zZjd0d1CY0VVsbb6sejKQOU4RtL7TETp3w==" });
        }
    }
}
