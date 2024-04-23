using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearning.Data.Migrations
{
    public partial class UpdateDatabaseSchema2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionAttemptStatusId",
                table: "QuizAttempts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 661, DateTimeKind.Local).AddTicks(421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 661, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 659, DateTimeKind.Local).AddTicks(7375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 660, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserRoles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 660, DateTimeKind.Local).AddTicks(9558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 661, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Topics",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(6512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StudentProgresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 659, DateTimeKind.Local).AddTicks(1498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(5914),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 658, DateTimeKind.Local).AddTicks(8394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 658, DateTimeKind.Local).AddTicks(7240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundRequest",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 658, DateTimeKind.Local).AddTicks(6133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Quizzes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(5206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttemptStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(4173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(2704),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(1971),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(1405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(3476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(741),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 658, DateTimeKind.Local).AddTicks(5066),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 658, DateTimeKind.Local).AddTicks(3566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 658, DateTimeKind.Local).AddTicks(4091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MediaTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 658, DateTimeKind.Local).AddTicks(2986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Medias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 658, DateTimeKind.Local).AddTicks(2387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Levels",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(42),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 656, DateTimeKind.Local).AddTicks(9512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 656, DateTimeKind.Local).AddTicks(5582),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReportStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 656, DateTimeKind.Local).AddTicks(8935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReports",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 656, DateTimeKind.Local).AddTicks(8291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonMedias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 656, DateTimeKind.Local).AddTicks(7190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonContents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 656, DateTimeKind.Local).AddTicks(6483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FavoriteCourses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 658, DateTimeKind.Local).AddTicks(1487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EnrollmentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 658, DateTimeKind.Local).AddTicks(171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Enrollments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(9552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Discussions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(7103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DiscussionReplies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(8014),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 656, DateTimeKind.Local).AddTicks(4336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleStart",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 655, DateTimeKind.Local).AddTicks(6784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleEnd",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 655, DateTimeKind.Local).AddTicks(7022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 655, DateTimeKind.Local).AddTicks(7160),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(1813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRequestStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 656, DateTimeKind.Local).AddTicks(3746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRatings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 656, DateTimeKind.Local).AddTicks(383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 656, DateTimeKind.Local).AddTicks(4953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(8206));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 661, DateTimeKind.Local).AddTicks(2223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 661, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 660, DateTimeKind.Local).AddTicks(2452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 659, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserRoles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 661, DateTimeKind.Local).AddTicks(1662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 660, DateTimeKind.Local).AddTicks(9558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Topics",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(8327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StudentProgresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(9028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 659, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(7647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(7263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 658, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(6710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 658, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundRequest",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(6230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 658, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Quizzes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(7077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttemptStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(5974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(4630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.AddColumn<int>(
                name: "QuestionAttemptStatusId",
                table: "QuizAttempts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(3994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(3476),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(2887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(5551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 658, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(4557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 658, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(5073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 658, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MediaTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(4047),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 658, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Medias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(3575),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 658, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Levels",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(2240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(42));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(1768),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 656, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(8726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 656, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReportStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(1169),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 656, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReports",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 656, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonMedias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(9758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 656, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonContents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(9295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 656, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FavoriteCourses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(2823),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 658, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EnrollmentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(1598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 658, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Enrollments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 659, DateTimeKind.Local).AddTicks(1050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Discussions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(8847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DiscussionReplies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 658, DateTimeKind.Local).AddTicks(9644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 657, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(7672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 656, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleStart",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(1422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 655, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleEnd",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(1640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 655, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(1813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 655, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRequestStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(7144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 656, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRatings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(4391),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 656, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 20, 41, 50, 657, DateTimeKind.Local).AddTicks(8206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 20, 47, 11, 656, DateTimeKind.Local).AddTicks(4953));
        }
    }
}
