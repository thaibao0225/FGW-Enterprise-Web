using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FGW_Enterprise_Web.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppConfig",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfig", x => x.Key);
                });

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

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    course_Id = table.Column<string>(nullable: false),
                    course_Name = table.Column<string>(nullable: true),
                    course_Descrition = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.course_Id);
                });

            migrationBuilder.CreateTable(
                name: "Deadline",
                columns: table => new
                {
                    dl_Id = table.Column<string>(nullable: false),
                    dl_Name = table.Column<string>(nullable: true),
                    dl_Description = table.Column<string>(nullable: true),
                    dl_TimeDeadline = table.Column<string>(nullable: true),
                    dl_Status = table.Column<string>(nullable: true),
                    dl_CreateBy = table.Column<string>(nullable: true),
                    dl_ModifiedBy = table.Column<string>(nullable: true),
                    dl_CreateDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deadline", x => x.dl_Id);
                });

            migrationBuilder.CreateTable(
                name: "DeadlineCate",
                columns: table => new
                {
                    dlCate_Id = table.Column<string>(nullable: false),
                    dlCate_Name = table.Column<string>(nullable: true),
                    dlCate_Description = table.Column<string>(nullable: true),
                    dlCate_Status = table.Column<string>(nullable: true),
                    dlCate_CreateBy = table.Column<string>(nullable: true),
                    dlCate_ModifiedBy = table.Column<string>(nullable: true),
                    dlCate_CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeadlineCate", x => x.dlCate_Id);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    event_Id = table.Column<string>(nullable: false),
                    event_Name = table.Column<string>(nullable: true),
                    event_Description = table.Column<string>(nullable: true),
                    event_CreateBy = table.Column<string>(nullable: true),
                    event_CreateDate = table.Column<DateTime>(nullable: false),
                    event_ModifiedBy = table.Column<string>(nullable: true),
                    event_Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.event_Id);
                });

            migrationBuilder.CreateTable(
                name: "Function",
                columns: table => new
                {
                    func_Id = table.Column<string>(nullable: false),
                    func_Name = table.Column<string>(nullable: true),
                    func_ParentId = table.Column<string>(nullable: true),
                    func_Status = table.Column<string>(nullable: true),
                    Functionfunc_Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Function", x => x.func_Id);
                    table.ForeignKey(
                        name: "FK_Function_Function_Functionfunc_Id",
                        column: x => x.Functionfunc_Id,
                        principalTable: "Function",
                        principalColumn: "func_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    role_Descrpition = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    user_FirstName = table.Column<string>(nullable: true),
                    user_LastName = table.Column<string>(nullable: true),
                    user_FullName = table.Column<string>(nullable: true),
                    user_DOB = table.Column<DateTime>(nullable: false),
                    user_LastLoginDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserFile",
                columns: table => new
                {
                    file_Id = table.Column<string>(nullable: false),
                    file_Name = table.Column<string>(nullable: true),
                    file_Description = table.Column<string>(nullable: true),
                    file_file = table.Column<string>(nullable: true),
                    file_url = table.Column<string>(nullable: true),
                    file_DeadlineId = table.Column<string>(nullable: true),
                    file_IsSelected = table.Column<string>(nullable: true),
                    file_DateUpload = table.Column<DateTime>(nullable: false),
                    file_CreateBy = table.Column<DateTime>(nullable: false),
                    file_CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFile", x => x.file_Id);
                    table.ForeignKey(
                        name: "FK_UserFile_Deadline_file_DeadlineId",
                        column: x => x.file_DeadlineId,
                        principalTable: "Deadline",
                        principalColumn: "dl_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegisterDeadline",
                columns: table => new
                {
                    rd_DeadlineId = table.Column<string>(nullable: false),
                    rd_DeadineCate = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterDeadline", x => new { x.rd_DeadineCate, x.rd_DeadlineId });
                    table.ForeignKey(
                        name: "FK_RegisterDeadline_DeadlineCate_rd_DeadineCate",
                        column: x => x.rd_DeadineCate,
                        principalTable: "DeadlineCate",
                        principalColumn: "dlCate_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisterDeadline_Deadline_rd_DeadlineId",
                        column: x => x.rd_DeadlineId,
                        principalTable: "Deadline",
                        principalColumn: "dl_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    comment_Id = table.Column<string>(nullable: false),
                    comment_Content = table.Column<string>(nullable: true),
                    comment_User = table.Column<Guid>(nullable: false),
                    comment_DateUpload = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.comment_Id);
                    table.ForeignKey(
                        name: "FK_Comment_User_comment_User",
                        column: x => x.comment_User,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegisterEvent",
                columns: table => new
                {
                    resEvent_CourseId = table.Column<string>(nullable: false),
                    resEvent_UserId = table.Column<Guid>(nullable: false),
                    resEvent_DeadlineCate = table.Column<string>(nullable: false),
                    resEvent_EventId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterEvent", x => new { x.resEvent_CourseId, x.resEvent_UserId, x.resEvent_DeadlineCate, x.resEvent_EventId });
                    table.ForeignKey(
                        name: "FK_RegisterEvent_Course_resEvent_CourseId",
                        column: x => x.resEvent_CourseId,
                        principalTable: "Course",
                        principalColumn: "course_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisterEvent_DeadlineCate_resEvent_DeadlineCate",
                        column: x => x.resEvent_DeadlineCate,
                        principalTable: "DeadlineCate",
                        principalColumn: "dlCate_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisterEvent_Event_resEvent_EventId",
                        column: x => x.resEvent_EventId,
                        principalTable: "Event",
                        principalColumn: "event_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisterEvent_User_resEvent_UserId",
                        column: x => x.resEvent_UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "RegisterComment",
                columns: table => new
                {
                    rescmt_CmtId = table.Column<string>(nullable: false),
                    rescmt_FileId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterComment", x => new { x.rescmt_CmtId, x.rescmt_FileId });
                    table.ForeignKey(
                        name: "FK_RegisterComment_Comment_rescmt_CmtId",
                        column: x => x.rescmt_CmtId,
                        principalTable: "Comment",
                        principalColumn: "comment_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisterComment_UserFile_rescmt_FileId",
                        column: x => x.rescmt_FileId,
                        principalTable: "UserFile",
                        principalColumn: "file_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppConfig",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeTitle", "This is Home Page FWG School" },
                    { "HomeKeyword", "This is Keyword Page FWG School" },
                    { "HomeDescription", "This is description Page FWG School" }
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("360e601e-92f2-4f08-832b-604a21293258"), new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb4fd") });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "role_Descrpition" },
                values: new object[,]
                {
                    { new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb4fd"), "985b5149-2ee6-45b6-9792-514ad24f773c", "Admin", "Admin", "Adminstrator role" },
                    { new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb5ff"), "0116f08a-4c8e-4f4a-8f4c-e928cba2305c", "User", "User", "User role" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DOB", "user_FirstName", "user_FullName", "user_LastLoginDate", "user_LastName" },
                values: new object[] { new Guid("360e601e-92f2-4f08-832b-604a21293258"), 0, "4a52508b-2839-48ec-8b4e-7331b9005bb1", "nhuvtqgcs18612@fpt.edu.vn", true, false, null, "nhuvtqgcs18612@fpt.edu.vn", "Admin", "AQAAAAEAACcQAAAAEP2YHsEHGTbM/zwUswfvrixMDNEpadI7YWX59EBEd2gI9Dn4QnP3kp7kMcpqiKyJDg==", null, false, "", false, "Admin", new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vo Thi Quynh Nhu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_comment_User",
                table: "Comment",
                column: "comment_User");

            migrationBuilder.CreateIndex(
                name: "IX_Function_Functionfunc_Id",
                table: "Function",
                column: "Functionfunc_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterComment_rescmt_FileId",
                table: "RegisterComment",
                column: "rescmt_FileId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterDeadline_rd_DeadlineId",
                table: "RegisterDeadline",
                column: "rd_DeadlineId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterEvent_resEvent_DeadlineCate",
                table: "RegisterEvent",
                column: "resEvent_DeadlineCate");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterEvent_resEvent_EventId",
                table: "RegisterEvent",
                column: "resEvent_EventId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterEvent_resEvent_UserId",
                table: "RegisterEvent",
                column: "resEvent_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFile_file_DeadlineId",
                table: "UserFile",
                column: "file_DeadlineId");

            migrationBuilder.CreateIndex(
                name: "IX_UserImage_UserId",
                table: "UserImage",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppConfig");

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

            migrationBuilder.DropTable(
                name: "Function");

            migrationBuilder.DropTable(
                name: "RegisterComment");

            migrationBuilder.DropTable(
                name: "RegisterDeadline");

            migrationBuilder.DropTable(
                name: "RegisterEvent");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "UserImage");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "UserFile");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "DeadlineCate");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Deadline");
        }
    }
}
