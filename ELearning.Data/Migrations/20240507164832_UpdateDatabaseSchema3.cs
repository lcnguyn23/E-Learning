using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearning.Data.Migrations
{
    public partial class UpdateDatabaseSchema3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_ApplicationUserId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_ApplicationUserId",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "UserRoles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 832, DateTimeKind.Local).AddTicks(4127),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 583, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Topics",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(8258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StudentProgresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(8882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(7486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundRequests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(7613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Quizzes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(6164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(3630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(2821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(2185),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(1377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(5584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(6772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MediaTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(4909),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Media",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(4268),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Levels",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(9651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(6553),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReports",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(8767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonMedias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(7837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonContents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(7249),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FavoriteCourses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(3315),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Enrollments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(1562),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Discussions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(8926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DiscussionReplies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(9915),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleStart",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 828, DateTimeKind.Local).AddTicks(8803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleEnd",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 828, DateTimeKind.Local).AddTicks(9045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 828, DateTimeKind.Local).AddTicks(9239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRatings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(2291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(5641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(7373));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 583, DateTimeKind.Local).AddTicks(2079),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 832, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "UserRoles",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Topics",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(8595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StudentProgresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(7338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(7979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundRequests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(6420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Quizzes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(7430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(6164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(5337),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(4579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(3977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(3233),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(5033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(5756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MediaTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(4486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Media",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(3938),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Levels",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(2110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(1413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(8070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReports",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(388),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonMedias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(9227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonContents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(8678),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FavoriteCourses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(3087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Enrollments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(1653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Discussions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(9303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DiscussionReplies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleStart",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 828, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleEnd",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(1029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 828, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(1164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 828, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRatings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(4041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(7373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_ApplicationUserId",
                table: "UserRoles",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_ApplicationUserId",
                table: "UserRoles",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
