using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FGW_Enterprise_Web.Data.Migrations
{
    public partial class FileLeghType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "file_size",
                table: "UserFile",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "DeadlineCate",
                keyColumn: "dlCate_Id",
                keyValue: "00001",
                column: "dlCate_CreateDate",
                value: new DateTime(2021, 4, 9, 4, 54, 48, 196, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "DeadlineCate",
                keyColumn: "dlCate_Id",
                keyValue: "00002",
                column: "dlCate_CreateDate",
                value: new DateTime(2021, 4, 9, 4, 54, 48, 197, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb4fd"),
                column: "ConcurrencyStamp",
                value: "09425123-dfde-4e33-944c-c559f935e0ae");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb5ff"),
                column: "ConcurrencyStamp",
                value: "f186a32f-84c6-4c53-acf4-8249e019075a");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("360e601e-92f2-4f08-832b-604a21293258"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19b9dd58-e947-4b81-94f8-b7a77484a85b", "AQAAAAEAACcQAAAAEPpCUAT2epaJUcHSLnWQtzg6jHDDeafyEj9kSSJIj517ZhV4znGA5UfwM49H88dUYg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "file_size",
                table: "UserFile",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

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
    }
}
