using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearning.Data.Migrations
{
    public partial class UpdateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_LessonMedias_LessonId",
                table: "LessonMedias");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LessonContents",
                keyColumn: "LessonContentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LessonContents",
                keyColumn: "LessonContentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LessonContents",
                keyColumn: "LessonContentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LessonMedias",
                keyColumn: "LessonMediaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LessonMedias",
                keyColumn: "LessonMediaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "LevelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "LevelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "LevelId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "LevelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "MediaName",
                table: "LessonMedias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 22, 14, 23, 4, 883, DateTimeKind.Local).AddTicks(6839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 19, 17, 37, 52, 56, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.CreateIndex(
                name: "IX_LessonMedias_LessonId",
                table: "LessonMedias",
                column: "LessonId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_LessonMedias_LessonId",
                table: "LessonMedias");

            migrationBuilder.AlterColumn<string>(
                name: "MediaName",
                table: "LessonMedias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 19, 17, 37, 52, 56, DateTimeKind.Local).AddTicks(9296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 22, 14, 23, 4, 883, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "LevelId", "CreatedAt", "DeletedAt", "IsDeleted", "LevelName" },
                values: new object[,]
                {
                    { 1, null, null, false, "Cơ bản" },
                    { 2, null, null, false, "Trung cấp" },
                    { 3, null, null, false, "Nâng cao" },
                    { 4, null, null, false, "Mọi cấp độ" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "f5ec39b0-6ea3-4db6-9673-551860729de5", "Admin", null },
                    { 2, "83a15354-1a27-43bb-8199-e03aafa46efb", "Instructor", null },
                    { 3, "68d691b6-0876-4185-a073-14a34c3eed34", "Student", null }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicId", "CreatedAt", "DeletedAt", "IsDeleted", "TopicDescription", "TopicName" },
                values: new object[,]
                {
                    { 1, null, null, false, null, "Công nghệ thông tin" },
                    { 2, null, null, false, null, "Nhiếp ảnh" },
                    { 3, null, null, false, null, "Mỹ thuật" },
                    { 4, null, null, false, null, "Digital marketing" },
                    { 5, null, null, false, null, "Âm nhạc" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "BirthDate", "ConcurrencyStamp", "CreatedAt", "DeletedAt", "Email", "EmailConfirmed", "FullName", "Gender", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, null, new DateTime(2024, 5, 19, 17, 37, 52, 61, DateTimeKind.Local).AddTicks(6899), "b8438ead-3536-43b7-bc19-84b2d8b8f82f", null, null, "admin01@example.com", true, "Lê Trí", "Male", false, false, null, null, "admin01", "AQAAAAEAACcQAAAAEFRfRVE2FWcPlIhwkW2Op+Hd6hSI3cguEeLDlReIkXbETOwZlurCjf2wX44ZgsnSOw==", "1234567890", false, null, null, false, "admin01@example.com" },
                    { 2, 0, null, new DateTime(2024, 5, 19, 17, 37, 52, 63, DateTimeKind.Local).AddTicks(417), "1617bbde-fcec-4d8d-aa8e-140f43ca0811", null, null, "instructor01@example.com", true, "Lê Lai", "Male", false, false, null, null, "instructor01", "AQAAAAEAACcQAAAAEA1UfAnEDLKyH989lcqb6U4IuXC+caH1aoFR3oQocC+aDVnXfzqWgTqH8xSqUUgpFQ==", "1234567810", false, null, null, false, "instructor01@example.com" },
                    { 3, 0, null, new DateTime(2024, 5, 19, 17, 37, 52, 64, DateTimeKind.Local).AddTicks(4985), "76ec8101-0006-49cc-b3d4-7cf6a03f0c34", null, null, "student01@example.com", true, "Văn Linh", "Male", false, false, null, null, "student01", "AQAAAAEAACcQAAAAEMCKBJlmt5lYzZOpcsjNFi2Y3ijDj2AzXN9MIwZpyWc6gKDwnWsZPEa+5ZNbX4X4Mw==", "1222567890", false, null, null, false, "student01@example.com" },
                    { 12, 0, null, new DateTime(2024, 5, 19, 17, 37, 52, 65, DateTimeKind.Local).AddTicks(8149), "555380b2-d82b-49e3-8643-c3b754336ecf", null, null, "linhlinhins11@example.com", true, "Nguyễn Linh", "Male", false, false, null, "linhlinhins11@example.com", "linhlinhins11@example.com", "AQAAAAEAACcQAAAAEBH0bkVuul+RM8Bo6FEsEL9QvKyUtdLaTKEadFT6ZQxEOlPX5rKP3sJvO8QudiVykw==", "1234522810", false, null, null, false, "linhlinhins11@example.com" },
                    { 13, 0, null, new DateTime(2024, 5, 19, 17, 37, 52, 67, DateTimeKind.Local).AddTicks(3399), "85d4d6cd-b084-480b-8056-83c25028b961", null, null, "studentlinh11@example.com", true, "Hồ Linh", "Male", false, false, null, "studentlinh11@example.com", "studentlinh11@example.com", "AQAAAAEAACcQAAAAEE2y1w2AJ9YY0TvxmOG/MEfaNzsWW8Tb3dr+e0suEUbxn21RJwkRWynlj8Vzmi0xfA==", "12312567890", false, null, null, false, "studentlinh11@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseImage", "CourseName", "DeletedAt", "Description", "Duration", "InstructorId", "IsDeleted", "IsFree", "LevelId", "Price", "SaleEnd", "SalePrice", "SaleStart", "ShortDescription", "Status", "TopicId" },
                values: new object[,]
                {
                    { 1, "", "Lập trình C# cơ bản", null, "Khóa học mang đến những kiến thức cơ bản về C#", "10 tiếng", 2, false, false, 1, 100000m, null, null, null, null, "PUBLISH", 1 },
                    { 2, "", "Guitar cơ bản", null, "Khóa học cơ bản về Guitar", "20 tiếng", 2, false, false, 1, 100000m, null, null, null, null, "PUBLISH", 5 },
                    { 3, "", "SEO cơ bản", null, "Khóa học SEO cơ bản cho website", "30 tiếng", 2, false, false, 1, 100000m, null, null, null, null, "PUBLISH", 4 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 2, 12 },
                    { 3, 13 }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "SectionId", "CourseId", "CreatedAt", "DeletedAt", "IsDeleted", "SectionOrder", "Title" },
                values: new object[,]
                {
                    { 1, 1, null, null, false, 1, "Basic syntax" },
                    { 2, 1, null, null, false, 2, "Basic syntax 2" },
                    { 3, 2, null, null, false, 1, "Giới thiệu" },
                    { 4, 2, null, null, false, 2, "Tìm hiểu về đàn Guitar" }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "CreatedAt", "DeletedAt", "IsDeleted", "Order", "SectionId", "Title" },
                values: new object[,]
                {
                    { 1, null, null, false, 1, 1, "Lesson 1" },
                    { 2, null, null, false, 2, 1, "Lesson 2" },
                    { 3, null, null, false, 1, 2, "Lesson 3" },
                    { 4, null, null, false, 2, 2, "Lesson 4" },
                    { 5, null, null, false, 3, 2, "Lesson 5" }
                });

            migrationBuilder.InsertData(
                table: "LessonContents",
                columns: new[] { "LessonContentId", "Content", "CreatedAt", "DeletedAt", "Description", "IsDeleted", "LessonId" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", false, 1 },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", false, 2 },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", false, 3 }
                });

            migrationBuilder.InsertData(
                table: "LessonMedias",
                columns: new[] { "LessonMediaId", "CreatedAt", "DeletedAt", "FileSizeByte", "IsDeleted", "LessonId", "MediaContent", "MediaName", "MediaPath", "MediaType", "MediaUrl" },
                values: new object[,]
                {
                    { 1, null, null, null, false, 1, "<iframe width=\"875\" height=\"492\" src=\"https://www.youtube.com/embed/DZFne4v2Z4Q?list=RDDZFne4v2Z4Q\" title=\"JVKE - This Is What Slow Dancing Feels Like (Lyrics)\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", "ytbCourse1", null, 2, null },
                    { 2, null, null, null, false, 2, "<iframe width=\"875\" height=\"492\" src=\"https://www.youtube.com/embed/DZFne4v2Z4Q?list=RDDZFne4v2Z4Q\" title=\"JVKE - This Is What Slow Dancing Feels Like (Lyrics)\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", "ytbCourse2", null, 2, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LessonMedias_LessonId",
                table: "LessonMedias",
                column: "LessonId");
        }
    }
}
