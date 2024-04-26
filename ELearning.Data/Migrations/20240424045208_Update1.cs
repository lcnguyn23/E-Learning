using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearning.Data.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 857, DateTimeKind.Local).AddTicks(6202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 46, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "UserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Topics",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(9771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StudentProgresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 857, DateTimeKind.Local).AddTicks(2501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 46, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(9148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 857, DateTimeKind.Local).AddTicks(469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(9846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundRequest",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(9267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Quizzes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(8428),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttemptStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(6808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(4992),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(4213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(3611),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(2933),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(8497),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(7243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(7893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MediaTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(6668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Medias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(5974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Levels",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(2227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(1677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 854, DateTimeKind.Local).AddTicks(8245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 43, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReportStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(1076),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReports",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonMedias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 854, DateTimeKind.Local).AddTicks(9410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 43, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonContents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 854, DateTimeKind.Local).AddTicks(8856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 43, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FavoriteCourses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(5128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EnrollmentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(3678),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Enrollments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(3084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Discussions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(443),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DiscussionReplies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(1380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 854, DateTimeKind.Local).AddTicks(7077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 43, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleStart",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 854, DateTimeKind.Local).AddTicks(358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 43, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleEnd",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 854, DateTimeKind.Local).AddTicks(645),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 43, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 854, DateTimeKind.Local).AddTicks(805),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 43, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRequestStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 854, DateTimeKind.Local).AddTicks(6431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 43, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRatings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 854, DateTimeKind.Local).AddTicks(3359),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 43, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 854, DateTimeKind.Local).AddTicks(7654),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 43, DateTimeKind.Local).AddTicks(7918));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 46, DateTimeKind.Local).AddTicks(4979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 857, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "UserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Topics",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(9058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StudentProgresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 46, DateTimeKind.Local).AddTicks(1311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 857, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(8477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(9296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 857, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(8688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundRequest",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(7986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Quizzes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(7928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttemptStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(6929),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(5357),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(4566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(3960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(3304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(7221),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(6140),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(6680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MediaTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(5513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Medias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(4936),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Levels",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(2576),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(2005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 43, DateTimeKind.Local).AddTicks(8509),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 854, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReportStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(1268),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReports",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 855, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonMedias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 43, DateTimeKind.Local).AddTicks(9676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 854, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonContents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 43, DateTimeKind.Local).AddTicks(9161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 854, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FavoriteCourses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(4080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EnrollmentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(2810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Enrollments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(2030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Discussions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 44, DateTimeKind.Local).AddTicks(9627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DiscussionReplies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 45, DateTimeKind.Local).AddTicks(491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 856, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 43, DateTimeKind.Local).AddTicks(7329),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 854, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleStart",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 43, DateTimeKind.Local).AddTicks(518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 854, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleEnd",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 43, DateTimeKind.Local).AddTicks(785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 854, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 43, DateTimeKind.Local).AddTicks(942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 854, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRequestStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 43, DateTimeKind.Local).AddTicks(6679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 854, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRatings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 43, DateTimeKind.Local).AddTicks(3600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 854, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 24, 11, 31, 1, 43, DateTimeKind.Local).AddTicks(7918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 24, 11, 52, 7, 854, DateTimeKind.Local).AddTicks(7654));
        }
    }
}
