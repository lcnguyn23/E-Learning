using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearning.Data.Migrations
{
    public partial class DeleteStatusTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseRequests_CourseRequestStatus_CourseRequestStatusId",
                table: "CourseRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseStatus_CourseStatusId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_EnrollmentStatus_EnrollmentStatusId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonReports_LessonReportStatus_LessonReportStatusId",
                table: "LessonReports");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_PaymentStatus_PaymentStatusId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_QuizAttempts_QuizAttemptStatus_QuizAttemptStatusId",
                table: "QuizAttempts");

            migrationBuilder.DropForeignKey(
                name: "FK_RefundRequest_RefundStatus_RefundStatusId",
                table: "RefundRequest");

            migrationBuilder.DropTable(
                name: "CourseRequestStatus");

            migrationBuilder.DropTable(
                name: "CourseStatus");

            migrationBuilder.DropTable(
                name: "EnrollmentStatus");

            migrationBuilder.DropTable(
                name: "LessonReportStatus");

            migrationBuilder.DropTable(
                name: "PaymentStatus");

            migrationBuilder.DropTable(
                name: "QuizAttemptStatus");

            migrationBuilder.DropTable(
                name: "RefundStatus");

            migrationBuilder.DropIndex(
                name: "IX_RefundRequest_RefundStatusId",
                table: "RefundRequest");

            migrationBuilder.DropIndex(
                name: "IX_QuizAttempts_QuizAttemptStatusId",
                table: "QuizAttempts");

            migrationBuilder.DropIndex(
                name: "IX_Payments_PaymentStatusId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_LessonReports_LessonReportStatusId",
                table: "LessonReports");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_EnrollmentStatusId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseStatusId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_CourseRequests_CourseRequestStatusId",
                table: "CourseRequests");

            migrationBuilder.DropColumn(
                name: "RefundStatusId",
                table: "RefundRequest");

            migrationBuilder.DropColumn(
                name: "QuizAttemptStatusId",
                table: "QuizAttempts");

            migrationBuilder.DropColumn(
                name: "PaymentStatusId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "LessonReportStatusId",
                table: "LessonReports");

            migrationBuilder.DropColumn(
                name: "EnrollmentStatusId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "CourseStatusId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseRequestStatusId",
                table: "CourseRequests");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 263, DateTimeKind.Local).AddTicks(1459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 330, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Topics",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(7734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 328, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StudentProgresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(7779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 329, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(7101),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 328, DateTimeKind.Local).AddTicks(142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundRequest",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(5660),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 329, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "RefundRequest",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Quizzes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(6510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 327, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(4219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 327, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "QuizAttempts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(3405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 327, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(2812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 327, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(2159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 327, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(4159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 329, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(4933),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 329, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MediaTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(3612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 329, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Medias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(3004),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 329, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Levels",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(1444),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 327, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 327, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(8021),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 326, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReports",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(94),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 326, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "LessonReports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonMedias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(9164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 326, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonContents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(8665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 326, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FavoriteCourses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(2159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 328, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Enrollments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 328, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Enrollments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Discussions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(8308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 328, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DiscussionReplies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(9182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 328, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleStart",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 325, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleEnd",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(1211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 325, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(1358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 325, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "CourseRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRatings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(4251),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 325, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(7390),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 326, DateTimeKind.Local).AddTicks(3072));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "RefundRequest");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "QuizAttempts");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "LessonReports");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "CourseRequests");

            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "Users",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 330, DateTimeKind.Local).AddTicks(3957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 263, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Topics",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 328, DateTimeKind.Local).AddTicks(1194),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StudentProgresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 329, DateTimeKind.Local).AddTicks(8698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 328, DateTimeKind.Local).AddTicks(142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundRequest",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 329, DateTimeKind.Local).AddTicks(4936),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.AddColumn<int>(
                name: "RefundStatusId",
                table: "RefundRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Quizzes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 327, DateTimeKind.Local).AddTicks(9126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 327, DateTimeKind.Local).AddTicks(5262),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.AddColumn<int>(
                name: "QuizAttemptStatusId",
                table: "QuizAttempts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 327, DateTimeKind.Local).AddTicks(4045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 327, DateTimeKind.Local).AddTicks(3291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 327, DateTimeKind.Local).AddTicks(2210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 329, DateTimeKind.Local).AddTicks(2332),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.AddColumn<int>(
                name: "PaymentStatusId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 329, DateTimeKind.Local).AddTicks(3155),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MediaTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 329, DateTimeKind.Local).AddTicks(1501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Medias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 329, DateTimeKind.Local).AddTicks(497),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Levels",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 327, DateTimeKind.Local).AddTicks(1374),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 327, DateTimeKind.Local).AddTicks(573),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 326, DateTimeKind.Local).AddTicks(4285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReports",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 326, DateTimeKind.Local).AddTicks(7986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.AddColumn<int>(
                name: "LessonReportStatusId",
                table: "LessonReports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonMedias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 326, DateTimeKind.Local).AddTicks(6544),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonContents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 326, DateTimeKind.Local).AddTicks(5453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FavoriteCourses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 328, DateTimeKind.Local).AddTicks(9337),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Enrollments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 328, DateTimeKind.Local).AddTicks(6485),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.AddColumn<int>(
                name: "EnrollmentStatusId",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Discussions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 328, DateTimeKind.Local).AddTicks(2045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DiscussionReplies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 328, DateTimeKind.Local).AddTicks(3717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleStart",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 325, DateTimeKind.Local).AddTicks(751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleEnd",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 325, DateTimeKind.Local).AddTicks(1208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 325, DateTimeKind.Local).AddTicks(1517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.AddColumn<int>(
                name: "CourseStatusId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseRequestStatusId",
                table: "CourseRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRatings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 325, DateTimeKind.Local).AddTicks(5847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 326, DateTimeKind.Local).AddTicks(3072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.CreateTable(
                name: "CourseRequestStatus",
                columns: table => new
                {
                    CourseRequestStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 326, DateTimeKind.Local).AddTicks(870)),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseRequestStatus", x => x.CourseRequestStatusId);
                });

            migrationBuilder.CreateTable(
                name: "CourseStatus",
                columns: table => new
                {
                    CourseStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 326, DateTimeKind.Local).AddTicks(1983)),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStatus", x => x.CourseStatusId);
                });

            migrationBuilder.CreateTable(
                name: "EnrollmentStatus",
                columns: table => new
                {
                    EnrollmentStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 328, DateTimeKind.Local).AddTicks(7370)),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnrollmentStatus", x => x.EnrollmentStatusId);
                });

            migrationBuilder.CreateTable(
                name: "LessonReportStatus",
                columns: table => new
                {
                    LessonReportStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 326, DateTimeKind.Local).AddTicks(9278)),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonReportStatus", x => x.LessonReportStatusId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentStatus",
                columns: table => new
                {
                    PaymentStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 329, DateTimeKind.Local).AddTicks(3933)),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentStatus", x => x.PaymentStatusId);
                });

            migrationBuilder.CreateTable(
                name: "QuizAttemptStatus",
                columns: table => new
                {
                    QuizAttemptStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 327, DateTimeKind.Local).AddTicks(7864)),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizAttemptStatus", x => x.QuizAttemptStatusId);
                });

            migrationBuilder.CreateTable(
                name: "RefundStatus",
                columns: table => new
                {
                    RefundStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 5, 3, 22, 29, 28, 329, DateTimeKind.Local).AddTicks(5918)),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefundStatus", x => x.RefundStatusId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RefundRequest_RefundStatusId",
                table: "RefundRequest",
                column: "RefundStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizAttempts_QuizAttemptStatusId",
                table: "QuizAttempts",
                column: "QuizAttemptStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentStatusId",
                table: "Payments",
                column: "PaymentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonReports_LessonReportStatusId",
                table: "LessonReports",
                column: "LessonReportStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_EnrollmentStatusId",
                table: "Enrollments",
                column: "EnrollmentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseStatusId",
                table: "Courses",
                column: "CourseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseRequests_CourseRequestStatusId",
                table: "CourseRequests",
                column: "CourseRequestStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRequests_CourseRequestStatus_CourseRequestStatusId",
                table: "CourseRequests",
                column: "CourseRequestStatusId",
                principalTable: "CourseRequestStatus",
                principalColumn: "CourseRequestStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseStatus_CourseStatusId",
                table: "Courses",
                column: "CourseStatusId",
                principalTable: "CourseStatus",
                principalColumn: "CourseStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_EnrollmentStatus_EnrollmentStatusId",
                table: "Enrollments",
                column: "EnrollmentStatusId",
                principalTable: "EnrollmentStatus",
                principalColumn: "EnrollmentStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonReports_LessonReportStatus_LessonReportStatusId",
                table: "LessonReports",
                column: "LessonReportStatusId",
                principalTable: "LessonReportStatus",
                principalColumn: "LessonReportStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_PaymentStatus_PaymentStatusId",
                table: "Payments",
                column: "PaymentStatusId",
                principalTable: "PaymentStatus",
                principalColumn: "PaymentStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuizAttempts_QuizAttemptStatus_QuizAttemptStatusId",
                table: "QuizAttempts",
                column: "QuizAttemptStatusId",
                principalTable: "QuizAttemptStatus",
                principalColumn: "QuizAttemptStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RefundRequest_RefundStatus_RefundStatusId",
                table: "RefundRequest",
                column: "RefundStatusId",
                principalTable: "RefundStatus",
                principalColumn: "RefundStatusId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
