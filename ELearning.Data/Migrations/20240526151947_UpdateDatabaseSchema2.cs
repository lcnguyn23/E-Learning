using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearning.Data.Migrations
{
    public partial class UpdateDatabaseSchema2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "QuestionAttempts");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "QuizAttempts");

            migrationBuilder.DropTable(
                name: "QuestionTypes");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 26, 22, 19, 46, 80, DateTimeKind.Local).AddTicks(8303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 26, 1, 16, 1, 454, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotificationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationId);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "65175db3-fd67-4626-8173-13d2a09dbdc2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3e413c7f-e40c-493a-b4ae-667815ef24cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "ef4b857a-ec48-4027-8ede-194830e87f07");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 19, 46, 84, DateTimeKind.Local).AddTicks(489), "96bc2567-5d78-4c1d-a356-67a847dad7d5", "AQAAAAEAACcQAAAAEMBersONuZDsqRVngCesz5pbocF0CYEWeYQwjXK39HhSRVBWDKja9rfiu6YRXqZ6Ig==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 19, 46, 85, DateTimeKind.Local).AddTicks(3507), "3eaaadd4-7b57-4510-b7ef-138efb86285e", "AQAAAAEAACcQAAAAENNCSiw03CIO1nuuvAOIIN3vg2lEOCpZVWU12c5wkSr7F5p8qr5FZBZ2K+5+842s/Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 19, 46, 86, DateTimeKind.Local).AddTicks(5308), "d4c2297b-5e5f-4144-938f-39bec84154c9", "AQAAAAEAACcQAAAAEDKESB5INyni3WKSxrRRCBCO/WY0Y3F7M/Dvfi8IJWLNIQDw1TnhscyIvxklF2DOJw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 19, 46, 87, DateTimeKind.Local).AddTicks(7588), "3cd344e9-a796-4d2b-ba9b-7e9486100943", "AQAAAAEAACcQAAAAEFzZWXG94H4oqzd7Oc81eo323kk9Aad6dx9nznF56bRXMzuI+fBP/CkGoA9p8ubEHw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 19, 46, 89, DateTimeKind.Local).AddTicks(770), "bf6c37a1-f02d-4dfe-8340-058df77bb0b7", "AQAAAAEAACcQAAAAENjt1BgnGP9799lVWar+ZiZWp7N/7hwMWMvZtN+djOG1KEwfiz6zHkIN+tkrJ3YULg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 26, 1, 16, 1, 454, DateTimeKind.Local).AddTicks(5407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 26, 22, 19, 46, 80, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.CreateTable(
                name: "QuestionTypes",
                columns: table => new
                {
                    QuestionTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTypes", x => x.QuestionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    QuizId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PassingScore = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TimeLimit = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.QuizId);
                    table.ForeignKey(
                        name: "FK_Quizzes_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "SectionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionTypeId = table.Column<int>(type: "int", nullable: false),
                    QuizId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Point = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    QuestionOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Questions_QuestionTypes_QuestionTypeId",
                        column: x => x.QuestionTypeId,
                        principalTable: "QuestionTypes",
                        principalColumn: "QuestionTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "QuizId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuizAttempts",
                columns: table => new
                {
                    QuizAttemptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuizId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizAttempts", x => x.QuizAttemptId);
                    table.ForeignKey(
                        name: "FK_QuizAttempts_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "QuizId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuizAttempts_Users_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionAttempts",
                columns: table => new
                {
                    QuestionAttemptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    QuizAttemptId = table.Column<int>(type: "int", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAttempts", x => x.QuestionAttemptId);
                    table.ForeignKey(
                        name: "FK_QuestionAttempts_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionAttempts_QuizAttempts_QuizAttemptId",
                        column: x => x.QuizAttemptId,
                        principalTable: "QuizAttempts",
                        principalColumn: "QuizAttemptId");
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "78fd0c83-f93d-4381-a1b1-b6800730dac9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e057178e-9d68-488a-b0fd-864465dbd942");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c3c6b7f1-7339-4d14-99e7-6c2cd0b14c30");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 1, 16, 1, 459, DateTimeKind.Local).AddTicks(1129), "14f73b62-468f-4368-97a6-cd63d1643620", "AQAAAAEAACcQAAAAELPdesm8yLvB366Cdr68NL6wmGqaqivsP7P4GOkrkn5xLFUaV3/kWVtJD1yGcccq5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 1, 16, 1, 460, DateTimeKind.Local).AddTicks(5091), "e73c5c59-2273-4f4d-aa21-162090a956d7", "AQAAAAEAACcQAAAAELQ5zcEPfhV5cbiqK3DfgDE3UUF96pe/6gXBpKm/Z6ybW0sPZ+IEwaZyUZDWd1r4rA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 1, 16, 1, 461, DateTimeKind.Local).AddTicks(8132), "4d522117-8c9b-49e5-9a02-82bf6e39a0a6", "AQAAAAEAACcQAAAAEGnkt6Q9VcwgHvDTM8mH8NvhvR3nhKxqz623wh5m3xEjOylwsoOVPXOIS0CJ//3ABQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 1, 16, 1, 463, DateTimeKind.Local).AddTicks(893), "c493abae-3980-44b4-93c7-828317e06679", "AQAAAAEAACcQAAAAEKEgEAtmwdlqL8vb8ImwrXihoi92RIU9GhquHDTRz/Nih5ot/AU4Fd/ppag/3Y/BIg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 1, 16, 1, 464, DateTimeKind.Local).AddTicks(2040), "20fc7213-e91b-4791-94ef-397220b9b831", "AQAAAAEAACcQAAAAECShwuuLO++SeKfadL0+DU/wLbeKpp+hBXrzucWQ+sDC6onQq+3VHKY5YQ7Zq5INPg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAttempts_QuestionId",
                table: "QuestionAttempts",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAttempts_QuizAttemptId",
                table: "QuestionAttempts",
                column: "QuizAttemptId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionTypeId",
                table: "Questions",
                column: "QuestionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuizId",
                table: "Questions",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizAttempts_QuizId",
                table: "QuizAttempts",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizAttempts_StudentId",
                table: "QuizAttempts",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_SectionId",
                table: "Quizzes",
                column: "SectionId");
        }
    }
}
