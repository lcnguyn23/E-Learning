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
                name: "StudentLessons");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 583, DateTimeKind.Local).AddTicks(2079),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 243, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Topics",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(8595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StudentProgresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(7338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 243, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(7979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundRequests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(6420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Quizzes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(7430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(5337),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(4579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(3977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(3233),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(5033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(5756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MediaTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(4486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Media",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(3938),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Levels",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(2110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(1413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(8070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReports",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(388),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonMedias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(9227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonContents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(8678),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FavoriteCourses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(3087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Enrollments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(1653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Discussions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(9303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DiscussionReplies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleStart",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 240, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleEnd",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(1029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 240, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(1164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 240, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRatings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(4041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 240, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(7373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(2063));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 243, DateTimeKind.Local).AddTicks(5477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 583, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Topics",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(2101),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StudentProgresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 243, DateTimeKind.Local).AddTicks(1851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(1527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundRequests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(9832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Quizzes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(961),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(8707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(7998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(7451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(6832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(8448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(9144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MediaTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(7889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Media",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(7328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Levels",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(6098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(5558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(2677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReports",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(4770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonMedias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(3774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonContents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(3259),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FavoriteCourses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(6491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Enrollments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(5040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Discussions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(2648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 581, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DiscussionReplies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(3434),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 582, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleStart",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 240, DateTimeKind.Local).AddTicks(5765),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleEnd",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 240, DateTimeKind.Local).AddTicks(5980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 240, DateTimeKind.Local).AddTicks(6115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRatings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 240, DateTimeKind.Local).AddTicks(9013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(2063),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 23, 43, 9, 580, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.CreateTable(
                name: "StudentLessons",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentLessons", x => new { x.StudentId, x.LessonId });
                    table.ForeignKey(
                        name: "FK_StudentLessons_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "LessonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentLessons_Users_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentLessons_LessonId",
                table: "StudentLessons",
                column: "LessonId");
        }
    }
}
