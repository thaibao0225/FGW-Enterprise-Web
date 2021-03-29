using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FGW_Enterprise_Web.Data.Migrations
{
    public partial class NewDateForRegisterDeadline : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RegisterDeadline",
                keyColumns: new[] { "rd_DeadineCate", "rd_DeadlineId" },
                keyValues: new object[] { "a", "a" });

            migrationBuilder.UpdateData(
                table: "Deadline",
                keyColumn: "dl_Id",
                keyValue: "d00001",
                column: "dl_CreateDate",
                value: new DateTime(2021, 4, 11, 0, 1, 18, 967, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Deadline",
                keyColumn: "dl_Id",
                keyValue: "d00002",
                column: "dl_CreateDate",
                value: new DateTime(2021, 4, 11, 0, 1, 18, 967, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "DeadlineCate",
                keyColumn: "dlCate_Id",
                keyValue: "00001",
                column: "dlCate_CreateDate",
                value: new DateTime(2021, 4, 11, 0, 1, 18, 966, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "DeadlineCate",
                keyColumn: "dlCate_Id",
                keyValue: "00002",
                column: "dlCate_CreateDate",
                value: new DateTime(2021, 4, 11, 0, 1, 18, 967, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.InsertData(
                table: "RegisterDeadline",
                columns: new[] { "rd_DeadineCate", "rd_DeadlineId" },
                values: new object[] { "00001", "d00001" });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb4fd"),
                column: "ConcurrencyStamp",
                value: "184a5707-1b18-42e1-baab-c99788b6c791");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb5ff"),
                column: "ConcurrencyStamp",
                value: "efa073ae-eff8-417e-9256-481c8e16ff93");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("360e601e-92f2-4f08-832b-604a21293258"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a0afee89-2bb3-480b-bbc7-4761498c6588", "AQAAAAEAACcQAAAAEPuBvd6r9OwuKAQwfmkVZl5/3fZVBmh+ukhq36o4NDcuDXuG54s+S8dn/56QcugZRQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RegisterDeadline",
                keyColumns: new[] { "rd_DeadineCate", "rd_DeadlineId" },
                keyValues: new object[] { "00001", "d00001" });

            migrationBuilder.UpdateData(
                table: "Deadline",
                keyColumn: "dl_Id",
                keyValue: "d00001",
                column: "dl_CreateDate",
                value: new DateTime(2021, 4, 10, 23, 59, 34, 149, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Deadline",
                keyColumn: "dl_Id",
                keyValue: "d00002",
                column: "dl_CreateDate",
                value: new DateTime(2021, 4, 10, 23, 59, 34, 149, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "DeadlineCate",
                keyColumn: "dlCate_Id",
                keyValue: "00001",
                column: "dlCate_CreateDate",
                value: new DateTime(2021, 4, 10, 23, 59, 34, 148, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "DeadlineCate",
                keyColumn: "dlCate_Id",
                keyValue: "00002",
                column: "dlCate_CreateDate",
                value: new DateTime(2021, 4, 10, 23, 59, 34, 148, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.InsertData(
                table: "RegisterDeadline",
                columns: new[] { "rd_DeadineCate", "rd_DeadlineId" },
                values: new object[] { "a", "a" });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb4fd"),
                column: "ConcurrencyStamp",
                value: "98cf49a3-fd3e-4456-a1ab-186fd736698e");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb5ff"),
                column: "ConcurrencyStamp",
                value: "21e78281-8ee7-4fc2-97b1-39963372bbf7");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("360e601e-92f2-4f08-832b-604a21293258"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1ffbdb8-b73b-4633-ba1d-3a37e9a155d2", "AQAAAAEAACcQAAAAECh0DSDYh4UfGJnxXgP8ekWt+E3UqSMa4uIccxXiJQTKY6K496v2pWu5tBgawBTEyA==" });
        }
    }
}
