using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearning.Data.Migrations
{
    public partial class UpdateDatabaseSchema5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 39, DateTimeKind.Local).AddTicks(1860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 274, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Topics",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(9056),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Topics",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Topics",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StudentProgresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 38, DateTimeKind.Local).AddTicks(6889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "StudentProgresses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "StudentProgresses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(8350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Sections",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundRequests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 38, DateTimeKind.Local).AddTicks(5863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "RefundRequests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "RefundRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Quizzes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(7684),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Quizzes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Quizzes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(5430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "QuizAttempts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "QuizAttempts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(4705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "QuestionTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "QuestionTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(4087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Questions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(3430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "QuestionAttempts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "QuestionAttempts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 38, DateTimeKind.Local).AddTicks(4431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Payments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 38, DateTimeKind.Local).AddTicks(5179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PaymentMethods",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Levels",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(2680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Levels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Levels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 36, DateTimeKind.Local).AddTicks(9742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Lessons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReports",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(1879),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "LessonReports",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "LessonReports",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonMedias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(931),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "LessonMedias",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "LessonMedias",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonContents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "LessonContents",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "LessonContents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FavoriteCourses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 38, DateTimeKind.Local).AddTicks(3609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "FavoriteCourses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "FavoriteCourses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Enrollments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 38, DateTimeKind.Local).AddTicks(2127),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Enrollments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Enrollments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Discussions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(9651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Discussions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Discussions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DiscussionReplies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 38, DateTimeKind.Local).AddTicks(535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "DiscussionReplies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "DiscussionReplies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleStart",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 36, DateTimeKind.Local).AddTicks(2009),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 271, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleEnd",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 36, DateTimeKind.Local).AddTicks(2229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 271, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 36, DateTimeKind.Local).AddTicks(2363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 271, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "CourseRequests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CourseRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRatings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 36, DateTimeKind.Local).AddTicks(5775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 271, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "CourseRatings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CourseRatings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 36, DateTimeKind.Local).AddTicks(9089),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Answers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Answers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "StudentProgresses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "StudentProgresses");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "RefundRequests");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "RefundRequests");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "QuizAttempts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "QuizAttempts");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "QuestionTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "QuestionTypes");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "QuestionAttempts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "QuestionAttempts");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "PaymentMethods");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PaymentMethods");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Levels");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Levels");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "LessonReports");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "LessonReports");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "LessonMedias");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "LessonMedias");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "LessonContents");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "LessonContents");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "FavoriteCourses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "FavoriteCourses");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Discussions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Discussions");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "DiscussionReplies");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "DiscussionReplies");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "CourseRequests");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CourseRequests");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "CourseRatings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CourseRatings");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Answers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 274, DateTimeKind.Local).AddTicks(701),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 39, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Topics",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(9869),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StudentProgresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(6874),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 38, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(9320),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundRequests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(5982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 38, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Quizzes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(8775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(6849),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(6192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(5674),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(5068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(4710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 38, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(5361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 38, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Levels",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(4357),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(1828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 36, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReports",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(3666),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonMedias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(2881),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonContents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(2386),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FavoriteCourses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(4108),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 38, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Enrollments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(2712),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 38, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Discussions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 37, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DiscussionReplies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(1194),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 38, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleStart",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 271, DateTimeKind.Local).AddTicks(5157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 36, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleEnd",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 271, DateTimeKind.Local).AddTicks(5365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 36, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 271, DateTimeKind.Local).AddTicks(5491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 36, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRatings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 271, DateTimeKind.Local).AddTicks(8236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 36, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(1251),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 21, 4, 36, DateTimeKind.Local).AddTicks(9089));
        }
    }
}
