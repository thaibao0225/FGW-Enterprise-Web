using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FGW_Enterprise_Web.Data.Migrations
{
    public partial class FileLeghTypet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Deadline",
                columns: new[] { "dl_Id", "ViewCount", "dl_CreateBy", "dl_CreateDate", "dl_Description", "dl_ModifiedBy", "dl_Name", "dl_Status", "dl_TimeDeadline" },
                values: new object[,]
                {
                    { "d00001", 0, null, new DateTime(2021, 4, 9, 6, 26, 49, 344, DateTimeKind.Local).AddTicks(5021), "Web project", null, "Project", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "d00002", 0, null, new DateTime(2021, 4, 9, 6, 26, 49, 344, DateTimeKind.Local).AddTicks(5643), "Web project2", null, "Project2", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "DeadlineCate",
                keyColumn: "dlCate_Id",
                keyValue: "00001",
                column: "dlCate_CreateDate",
                value: new DateTime(2021, 4, 9, 6, 26, 49, 343, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "DeadlineCate",
                keyColumn: "dlCate_Id",
                keyValue: "00002",
                column: "dlCate_CreateDate",
                value: new DateTime(2021, 4, 9, 6, 26, 49, 344, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb4fd"),
                column: "ConcurrencyStamp",
                value: "ba8e2c3e-0157-4dfa-bc63-5d0720886f3f");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb5ff"),
                column: "ConcurrencyStamp",
                value: "c7d69c62-6a2b-484c-b6c5-8b8e497da3d0");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("360e601e-92f2-4f08-832b-604a21293258"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f663295-be33-4713-bfb7-f0d074f96dbe", "AQAAAAEAACcQAAAAEG06zY6ErkRj6PWUba/PwfQgaK/biVz4BU6i1wI1Bq4kQlnzYKVWGMnvL5dObQkgXQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Deadline",
                keyColumn: "dl_Id",
                keyValue: "d00001");

            migrationBuilder.DeleteData(
                table: "Deadline",
                keyColumn: "dl_Id",
                keyValue: "d00002");

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
    }
}
