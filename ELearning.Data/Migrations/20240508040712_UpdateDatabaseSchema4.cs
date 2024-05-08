using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearning.Data.Migrations
{
    public partial class UpdateDatabaseSchema4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonMedias_Media_MediaId",
                table: "LessonMedias");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_LessonTypes_LessonTypeId",
                table: "Lessons");

            migrationBuilder.DropTable(
                name: "LessonTypes");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "MediaTypes");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_LessonTypeId",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_LessonMedias_MediaId",
                table: "LessonMedias");

            migrationBuilder.DropColumn(
                name: "LessonTypeId",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "MediaId",
                table: "LessonMedias");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 274, DateTimeKind.Local).AddTicks(701),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 832, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Topics",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(9869),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StudentProgresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(6874),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(9320),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundRequests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(5982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Quizzes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(8775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(6164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(6849),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(6192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(5674),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(5068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(4710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(5361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Levels",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(4357),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(1828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReports",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(3666),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonMedias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(2881),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.AddColumn<string>(
                name: "FileContent",
                table: "LessonMedias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "LessonMedias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "LessonMedias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FileSizeByte",
                table: "LessonMedias",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileType",
                table: "LessonMedias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonContents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(2386),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FavoriteCourses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(4108),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Enrollments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(2712),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Discussions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DiscussionReplies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(1194),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleStart",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 271, DateTimeKind.Local).AddTicks(5157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 828, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleEnd",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 271, DateTimeKind.Local).AddTicks(5365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 828, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 271, DateTimeKind.Local).AddTicks(5491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 828, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRatings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 271, DateTimeKind.Local).AddTicks(8236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(1251),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(5641));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileContent",
                table: "LessonMedias");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "LessonMedias");

            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "LessonMedias");

            migrationBuilder.DropColumn(
                name: "FileSizeByte",
                table: "LessonMedias");

            migrationBuilder.DropColumn(
                name: "FileType",
                table: "LessonMedias");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 832, DateTimeKind.Local).AddTicks(4127),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 274, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Topics",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(8258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StudentProgresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(8882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(7486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundRequests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(7613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Quizzes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(6164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(3630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(2821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(2185),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(1377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(5584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(6772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Levels",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(6553),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.AddColumn<int>(
                name: "LessonTypeId",
                table: "Lessons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReports",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(8767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonMedias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(7837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.AddColumn<int>(
                name: "MediaId",
                table: "LessonMedias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonContents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(7249),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FavoriteCourses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(3315),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Enrollments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(1562),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Discussions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(8926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DiscussionReplies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 830, DateTimeKind.Local).AddTicks(9915),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 273, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleStart",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 828, DateTimeKind.Local).AddTicks(8803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 271, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleEnd",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 828, DateTimeKind.Local).AddTicks(9045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 271, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 828, DateTimeKind.Local).AddTicks(9239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 271, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRatings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(2291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 271, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(5641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 8, 11, 7, 12, 272, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.CreateTable(
                name: "LessonTypes",
                columns: table => new
                {
                    LessonTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 829, DateTimeKind.Local).AddTicks(9651)),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonTypes", x => x.LessonTypeId);
                });

            migrationBuilder.CreateTable(
                name: "MediaTypes",
                columns: table => new
                {
                    MediaTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(4909)),
                    TypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaTypes", x => x.MediaTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    MediaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MediaTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 5, 7, 23, 48, 32, 831, DateTimeKind.Local).AddTicks(4268)),
                    FileContent = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    FileSizeByte = table.Column<long>(type: "bigint", nullable: true),
                    FileType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.MediaId);
                    table.ForeignKey(
                        name: "FK_Media_MediaTypes_MediaTypeId",
                        column: x => x.MediaTypeId,
                        principalTable: "MediaTypes",
                        principalColumn: "MediaTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_LessonTypeId",
                table: "Lessons",
                column: "LessonTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonMedias_MediaId",
                table: "LessonMedias",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_MediaTypeId",
                table: "Media",
                column: "MediaTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonMedias_Media_MediaId",
                table: "LessonMedias",
                column: "MediaId",
                principalTable: "Media",
                principalColumn: "MediaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_LessonTypes_LessonTypeId",
                table: "Lessons",
                column: "LessonTypeId",
                principalTable: "LessonTypes",
                principalColumn: "LessonTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
