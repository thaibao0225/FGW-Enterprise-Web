﻿// <auto-generated />
using System;
using FGW_Enterprise_Web.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FGW_Enterprise_Web.Data.Migrations
{
    [DbContext(typeof(SchlDBContext))]
    partial class SchlDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.AppConfig", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.ToTable("AppConfig");

                    b.HasData(
                        new
                        {
                            Key = "HomeTitle",
                            Value = "This is Home Page FWG School"
                        },
                        new
                        {
                            Key = "HomeKeyword",
                            Value = "This is Keyword Page FWG School"
                        },
                        new
                        {
                            Key = "HomeDescription",
                            Value = "This is description Page FWG School"
                        });
                });

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.Comment", b =>
                {
                    b.Property<string>("comment_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("comment_Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("comment_DateUpload")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("comment_User")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("comment_Id");

                    b.HasIndex("comment_User");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.Course", b =>
                {
                    b.Property<string>("course_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("course_Descrition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("course_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("course_Id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.Deadline", b =>
                {
                    b.Property<string>("dl_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.Property<string>("dl_CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dl_CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("dl_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dl_ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dl_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dl_Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dl_TimeDeadline")
                        .HasColumnType("datetime2");

                    b.HasKey("dl_Id");

                    b.ToTable("Deadline");

                    b.HasData(
                        new
                        {
                            dl_Id = "d00001",
                            ViewCount = 0,
                            dl_CreateDate = new DateTime(2021, 4, 9, 6, 26, 49, 344, DateTimeKind.Local).AddTicks(5021),
                            dl_Description = "Web project",
                            dl_Name = "Project",
                            dl_TimeDeadline = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            dl_Id = "d00002",
                            ViewCount = 0,
                            dl_CreateDate = new DateTime(2021, 4, 9, 6, 26, 49, 344, DateTimeKind.Local).AddTicks(5643),
                            dl_Description = "Web project2",
                            dl_Name = "Project2",
                            dl_TimeDeadline = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.DeadlineCate", b =>
                {
                    b.Property<string>("dlCate_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("dlCate_CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dlCate_CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("dlCate_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dlCate_ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dlCate_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dlCate_Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("dlCate_Id");

                    b.ToTable("DeadlineCate");

                    b.HasData(
                        new
                        {
                            dlCate_Id = "00001",
                            dlCate_CreateBy = "Vo Thi Quynh Nhu",
                            dlCate_CreateDate = new DateTime(2021, 4, 9, 6, 26, 49, 343, DateTimeKind.Local).AddTicks(4572),
                            dlCate_Description = "Web project",
                            dlCate_Name = "EnterpriseWeb "
                        },
                        new
                        {
                            dlCate_Id = "00002",
                            dlCate_CreateBy = "Vo Thi Quynh Nhu",
                            dlCate_CreateDate = new DateTime(2021, 4, 9, 6, 26, 49, 344, DateTimeKind.Local).AddTicks(3321),
                            dlCate_Description = "Web project",
                            dlCate_Name = "Project"
                        });
                });

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.Event", b =>
                {
                    b.Property<string>("event_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("event_CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("event_CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("event_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("event_ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("event_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("event_Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("event_Id");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.Function", b =>
                {
                    b.Property<string>("func_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Functionfunc_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("func_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("func_ParentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("func_Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("func_Id");

                    b.HasIndex("Functionfunc_Id");

                    b.ToTable("Function");
                });

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.RegisterComment", b =>
                {
                    b.Property<string>("rescmt_CmtId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("rescmt_FileId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("rescmt_CmtId", "rescmt_FileId");

                    b.HasIndex("rescmt_FileId");

                    b.ToTable("RegisterComment");
                });

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.RegisterDeadline", b =>
                {
                    b.Property<string>("rd_DeadineCate")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("rd_DeadlineId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("rd_DeadineCate", "rd_DeadlineId");

                    b.HasIndex("rd_DeadlineId");

                    b.ToTable("RegisterDeadline");
                });

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.RegisterEvent", b =>
                {
                    b.Property<string>("resEvent_CourseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("resEvent_UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("resEvent_DeadlineCate")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("resEvent_EventId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("resEvent_CourseId", "resEvent_UserId", "resEvent_DeadlineCate", "resEvent_EventId");

                    b.HasIndex("resEvent_DeadlineCate");

                    b.HasIndex("resEvent_EventId");

                    b.HasIndex("resEvent_UserId");

                    b.ToTable("RegisterEvent");
                });

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role_Descrpition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb4fd"),
                            ConcurrencyStamp = "ba8e2c3e-0157-4dfa-bc63-5d0720886f3f",
                            Name = "Admin",
                            NormalizedName = "Admin",
                            role_Descrpition = "Adminstrator role"
                        },
                        new
                        {
                            Id = new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb5ff"),
                            ConcurrencyStamp = "c7d69c62-6a2b-484c-b6c5-8b8e497da3d0",
                            Name = "User",
                            NormalizedName = "User",
                            role_Descrpition = "User role"
                        });
                });

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("user_DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("user_FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("user_LastLoginDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("user_LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("360e601e-92f2-4f08-832b-604a21293258"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9f663295-be33-4713-bfb7-f0d074f96dbe",
                            Email = "nhuvtqgcs18612@fpt.edu.vn",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "nhuvtqgcs18612@fpt.edu.vn",
                            NormalizedUserName = "Admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEG06zY6ErkRj6PWUba/PwfQgaK/biVz4BU6i1wI1Bq4kQlnzYKVWGMnvL5dObQkgXQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Admin",
                            user_DOB = new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            user_FullName = "Vo Thi Quynh Nhu",
                            user_LastLoginDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.UserFile", b =>
                {
                    b.Property<string>("file_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<DateTime>("file_CreateBy")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("file_CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("file_DateUpload")
                        .HasColumnType("datetime2");

                    b.Property<string>("file_DeadlineId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("file_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("file_IsSelected")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("file_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("file_file")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("file_size")
                        .HasColumnType("bigint");

                    b.Property<string>("file_url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("file_Id");

                    b.HasIndex("file_DeadlineId");

                    b.ToTable("UserFile");
                });

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.UserImage", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("FileSize")
                        .HasColumnType("int");

                    b.Property<string>("UrlImg")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserImage");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AppUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("360e601e-92f2-4f08-832b-604a21293258"),
                            RoleId = new Guid("f49e4348-718f-43e3-b1f6-6dc89c5bb4fd")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens");
                });

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.Comment", b =>
                {
                    b.HasOne("FGW_Enterprise_Web.Data.Entities.User", "UserC")
                        .WithMany("CommentU")
                        .HasForeignKey("comment_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.Function", b =>
                {
                    b.HasOne("FGW_Enterprise_Web.Data.Entities.Function", null)
                        .WithMany("FunctionsFun")
                        .HasForeignKey("Functionfunc_Id");
                });

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.RegisterComment", b =>
                {
                    b.HasOne("FGW_Enterprise_Web.Data.Entities.Comment", "Comment")
                        .WithMany("RegisterComment")
                        .HasForeignKey("rescmt_CmtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FGW_Enterprise_Web.Data.Entities.UserFile", "UserFile")
                        .WithMany("RegisterComment")
                        .HasForeignKey("rescmt_FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.RegisterDeadline", b =>
                {
                    b.HasOne("FGW_Enterprise_Web.Data.Entities.DeadlineCate", "DealineCate")
                        .WithMany("RegisterDeadline")
                        .HasForeignKey("rd_DeadineCate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FGW_Enterprise_Web.Data.Entities.Deadline", "Dealine")
                        .WithMany("RegisterDeadline")
                        .HasForeignKey("rd_DeadlineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.RegisterEvent", b =>
                {
                    b.HasOne("FGW_Enterprise_Web.Data.Entities.Course", "Course")
                        .WithMany("RegisterEvent")
                        .HasForeignKey("resEvent_CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FGW_Enterprise_Web.Data.Entities.DeadlineCate", "DealineCate")
                        .WithMany("RegisterEvent")
                        .HasForeignKey("resEvent_DeadlineCate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FGW_Enterprise_Web.Data.Entities.Event", "Event")
                        .WithMany("RegisterEvent")
                        .HasForeignKey("resEvent_EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FGW_Enterprise_Web.Data.Entities.User", "User")
                        .WithMany("RegisterEvent")
                        .HasForeignKey("resEvent_UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.UserFile", b =>
                {
                    b.HasOne("FGW_Enterprise_Web.Data.Entities.Deadline", "DeadlineF")
                        .WithMany("UserFileD")
                        .HasForeignKey("file_DeadlineId");
                });

            modelBuilder.Entity("FGW_Enterprise_Web.Data.Entities.UserImage", b =>
                {
                    b.HasOne("FGW_Enterprise_Web.Data.Entities.User", "UserI")
                        .WithMany("UserImageU")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
