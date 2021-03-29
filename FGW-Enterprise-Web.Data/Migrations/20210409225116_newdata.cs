using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FGW_Enterprise_Web.Data.Migrations
{
    public partial class newdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegisterEvent_Course_resEvent_CourseId",
                table: "RegisterEvent");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    course_Id = table.Column<string>(nullable: false),
                    course_Name = table.Column<string>(nullable: true),
                    course_Descrition = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.course_Id);
                });

            migrationBuilder.UpdateData(
                table: "Deadline",
                keyColumn: "dl_Id",
                keyValue: "d00001",
                column: "dl_CreateDate",
                value: new DateTime(2021, 4, 10, 5, 51, 16, 463, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Deadline",
                keyColumn: "dl_Id",
                keyValue: "d00002",
                column: "dl_CreateDate",
                value: new DateTime(2021, 4, 10, 5, 51, 16, 463, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "DeadlineCate",
                keyColumn: "dlCate_Id",
                keyValue: "00001",
                column: "dlCate_CreateDate",
                value: new DateTime(2021, 4, 10, 5, 51, 16, 462, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "DeadlineCate",
                keyColumn: "dlCate_Id",
                keyValue: "00002",
                column: "dlCate_CreateDate",
                value: new DateTime(2021, 4, 10, 5, 51, 16, 462, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb4fd"),
                column: "ConcurrencyStamp",
                value: "5360e231-3ac6-4c43-92af-44f33e65178f");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb5ff"),
                column: "ConcurrencyStamp",
                value: "520d79d4-a5c6-4267-b561-ceffb3cc5469");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("360e601e-92f2-4f08-832b-604a21293258"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "536569bd-a1bf-49d1-aec4-f7ed95772986", "AQAAAAEAACcQAAAAEFO5Im43FtuSFdToyKwvQpX10dpZmNNqVnfAYgG4oJydMdWJ2cdKwniRu3Ly5OHPng==" });

            migrationBuilder.AddForeignKey(
                name: "FK_RegisterEvent_Courses_resEvent_CourseId",
                table: "RegisterEvent",
                column: "resEvent_CourseId",
                principalTable: "Courses",
                principalColumn: "course_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegisterEvent_Courses_resEvent_CourseId",
                table: "RegisterEvent");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    course_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    course_Descrition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    course_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.course_Id);
                });

            migrationBuilder.UpdateData(
                table: "Deadline",
                keyColumn: "dl_Id",
                keyValue: "d00001",
                column: "dl_CreateDate",
                value: new DateTime(2021, 4, 9, 6, 26, 49, 344, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "Deadline",
                keyColumn: "dl_Id",
                keyValue: "d00002",
                column: "dl_CreateDate",
                value: new DateTime(2021, 4, 9, 6, 26, 49, 344, DateTimeKind.Local).AddTicks(5643));

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

            migrationBuilder.AddForeignKey(
                name: "FK_RegisterEvent_Course_resEvent_CourseId",
                table: "RegisterEvent",
                column: "resEvent_CourseId",
                principalTable: "Course",
                principalColumn: "course_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
