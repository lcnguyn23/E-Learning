using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearning.Data.Migrations
{
    public partial class UpdateDatabaseSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuestionAttemptStatus",
                table: "QuizAttempts",
                newName: "QuestionAttemptStatusId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 661, DateTimeKind.Local).AddTicks(2223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 363, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 660, DateTimeKind.Local).AddTicks(2452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 362, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserRoles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 661, DateTimeKind.Local).AddTicks(1662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 363, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Topics",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(8327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StudentProgresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(9028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 362, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(7647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(7263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 362, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(6710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 362, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundRequest",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(6230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 362, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Quizzes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(7077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttemptStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(5974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(4630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(3994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(3476),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(2887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(5551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 362, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(4557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(5073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MediaTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(4047),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Medias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(3575),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Levels",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(2240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(1768),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(8726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReportStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(1169),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReports",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonMedias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(9758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonContents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(9295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FavoriteCourses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(2823),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EnrollmentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(1598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Enrollments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(1050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Discussions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(8847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DiscussionReplies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(9644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(7672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleStart",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(1422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 359, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleEnd",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(1640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 359, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(1813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 359, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRequestStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(7144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRatings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(4391),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 359, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(8206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(1919));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuestionAttemptStatusId",
                table: "QuizAttempts",
                newName: "QuestionAttemptStatus");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 363, DateTimeKind.Local).AddTicks(7390),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 661, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 362, DateTimeKind.Local).AddTicks(7415),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 660, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserRoles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 363, DateTimeKind.Local).AddTicks(6821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 661, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Topics",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(2266),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StudentProgresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 362, DateTimeKind.Local).AddTicks(3885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(1720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 362, DateTimeKind.Local).AddTicks(2032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 362, DateTimeKind.Local).AddTicks(1505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundRequest",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 362, DateTimeKind.Local).AddTicks(977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Quizzes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(1204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttemptStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(48),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(8638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(7949),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(7424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(3476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(6826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 362, DateTimeKind.Local).AddTicks(299),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(9260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(9803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MediaTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(8708),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Medias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(8153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Levels",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(6139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(5685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(2628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReportStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(5144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReports",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(4543),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonMedias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(3664),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonContents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(3192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FavoriteCourses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(7371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EnrollmentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(5960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Enrollments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(5365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Discussions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(2855),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DiscussionReplies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 361, DateTimeKind.Local).AddTicks(3831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(1427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleStart",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 359, DateTimeKind.Local).AddTicks(4739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleEnd",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 359, DateTimeKind.Local).AddTicks(4982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 359, DateTimeKind.Local).AddTicks(5117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(1813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRequestStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRatings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 359, DateTimeKind.Local).AddTicks(7941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 37, 36, 360, DateTimeKind.Local).AddTicks(1919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(8206));
        }
    }
}
