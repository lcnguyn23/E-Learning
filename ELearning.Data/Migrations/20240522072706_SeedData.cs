using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearning.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 22, 14, 27, 6, 78, DateTimeKind.Local).AddTicks(2751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 22, 14, 23, 4, 883, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "LevelId", "CreatedAt", "DeletedAt", "IsDeleted", "LevelName" },
                values: new object[,]
                {
                    { 1, null, null, false, "Beginner" },
                    { 2, null, null, false, "Intermediate" },
                    { 3, null, null, false, "Advance" },
                    { 4, null, null, false, "All level" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "571101ee-4364-4ca8-a8f0-dbac091928b5", "Admin", null },
                    { 2, "4e1d2b32-91d8-4a36-be12-d3ed7ec5206f", "Instructor", null },
                    { 3, "8d804060-5764-481c-8f34-6e4754d981a9", "Student", null }
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
                    { 1, 0, null, new DateTime(2024, 5, 22, 14, 27, 6, 81, DateTimeKind.Local).AddTicks(6275), "1e15901c-0db1-4881-afa5-e1e1624c82ae", null, null, "admin01@example.com", true, "Lê Trí", "Male", false, false, null, null, "admin01", "AQAAAAEAACcQAAAAEF3DYBW8GDIDV4e187G1B/+8ux90bMESTR109AT2oeMQoiOezIhmJx/stPDbNFpr/w==", "1234567890", false, null, null, false, "admin01@example.com" },
                    { 2, 0, null, new DateTime(2024, 5, 22, 14, 27, 6, 82, DateTimeKind.Local).AddTicks(7213), "adcbfa7a-4e44-4d68-8155-ad60a06d5a5d", null, null, "instructor01@example.com", true, "Lê Lai", "Male", false, false, null, null, "instructor01", "AQAAAAEAACcQAAAAEIPRpDO18thMCNert/VW8ttCFbLBpdAafyzHZgnb7brH8G/bSy45fUJrD6Re/YmHpg==", "1234567810", false, null, null, false, "instructor01@example.com" },
                    { 3, 0, null, new DateTime(2024, 5, 22, 14, 27, 6, 83, DateTimeKind.Local).AddTicks(7894), "3075e2b3-bcf0-4edd-92c5-96f0a9d2aa96", null, null, "student01@example.com", true, "Văn Linh", "Male", false, false, null, null, "student01", "AQAAAAEAACcQAAAAEP0/4gOuQdnO0dl9fUqMcaM96uPTVI7W01lOnBRClllBJLQujlrqKunM3FsBM4/Inw==", "1222567890", false, null, null, false, "student01@example.com" },
                    { 12, 0, null, new DateTime(2024, 5, 22, 14, 27, 6, 84, DateTimeKind.Local).AddTicks(8471), "ac53aa1e-c2ef-41c5-9834-4741c75663b0", null, null, "linhlinhins11@example.com", true, "Nguyễn Linh", "Male", false, false, null, "linhlinhins11@example.com", "linhlinhins11@example.com", "AQAAAAEAACcQAAAAEAU7K/X2xSHqNtbVs8G4+25eXD6SQHZ3j3arv4+5uWl0X+OshMszrV/UB+KzE/arpg==", "1234522810", false, null, null, false, "linhlinhins11@example.com" },
                    { 13, 0, null, new DateTime(2024, 5, 22, 14, 27, 6, 85, DateTimeKind.Local).AddTicks(9049), "a5042651-c4f8-43ea-be8e-10810462e935", null, null, "studentlinh11@example.com", true, "Hồ Linh", "Male", false, false, null, "studentlinh11@example.com", "studentlinh11@example.com", "AQAAAAEAACcQAAAAEDmc8HTSa2H+eZWea7wu6YvWq/BitrS7c5r4t5APMXstsG4YUgOY4Cny7Af0BVq1Yw==", "12312567890", false, null, null, false, "studentlinh11@example.com" }
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 22, 14, 23, 4, 883, DateTimeKind.Local).AddTicks(6839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 22, 14, 27, 6, 78, DateTimeKind.Local).AddTicks(2751));
        }
    }
}
