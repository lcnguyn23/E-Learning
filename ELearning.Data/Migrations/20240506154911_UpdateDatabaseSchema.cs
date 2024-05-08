using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearning.Data.Migrations
{
    public partial class UpdateDatabaseSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonMedias_Medias_MediaId",
                table: "LessonMedias");

            migrationBuilder.DropForeignKey(
                name: "FK_Medias_MediaTypes_MediaTypeId",
                table: "Medias");

            migrationBuilder.DropForeignKey(
                name: "FK_RefundRequest_Enrollments_EnrollmentId",
                table: "RefundRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefundRequest",
                table: "RefundRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medias",
                table: "Medias");

            migrationBuilder.RenameTable(
                name: "RefundRequest",
                newName: "RefundRequests");

            migrationBuilder.RenameTable(
                name: "Medias",
                newName: "Media");

            migrationBuilder.RenameIndex(
                name: "IX_RefundRequest_EnrollmentId",
                table: "RefundRequests",
                newName: "IX_RefundRequests_EnrollmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Medias_MediaTypeId",
                table: "Media",
                newName: "IX_Media_MediaTypeId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 243, DateTimeKind.Local).AddTicks(5477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 263, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Topics",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(2101),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StudentProgresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 243, DateTimeKind.Local).AddTicks(1851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(1527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Quizzes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(961),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(8707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(7998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(7451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(6832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(8448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(9144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MediaTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(7889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Levels",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(6098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(5558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(2677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReports",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(4770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonMedias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(3774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonContents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(3259),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FavoriteCourses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(6491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Enrollments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(5040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Discussions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(2648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DiscussionReplies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(3434),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleStart",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 240, DateTimeKind.Local).AddTicks(5765),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleEnd",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 240, DateTimeKind.Local).AddTicks(5980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 240, DateTimeKind.Local).AddTicks(6115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRatings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 240, DateTimeKind.Local).AddTicks(9013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(2063),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundRequests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(9832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Media",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(7328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefundRequests",
                table: "RefundRequests",
                column: "RefundRequestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Media",
                table: "Media",
                column: "MediaId");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonMedias_Media_MediaId",
                table: "LessonMedias",
                column: "MediaId",
                principalTable: "Media",
                principalColumn: "MediaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Media_MediaTypes_MediaTypeId",
                table: "Media",
                column: "MediaTypeId",
                principalTable: "MediaTypes",
                principalColumn: "MediaTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RefundRequests_Enrollments_EnrollmentId",
                table: "RefundRequests",
                column: "EnrollmentId",
                principalTable: "Enrollments",
                principalColumn: "EnrollmentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonMedias_Media_MediaId",
                table: "LessonMedias");

            migrationBuilder.DropForeignKey(
                name: "FK_Media_MediaTypes_MediaTypeId",
                table: "Media");

            migrationBuilder.DropForeignKey(
                name: "FK_RefundRequests_Enrollments_EnrollmentId",
                table: "RefundRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefundRequests",
                table: "RefundRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Media",
                table: "Media");

            migrationBuilder.RenameTable(
                name: "RefundRequests",
                newName: "RefundRequest");

            migrationBuilder.RenameTable(
                name: "Media",
                newName: "Medias");

            migrationBuilder.RenameIndex(
                name: "IX_RefundRequests_EnrollmentId",
                table: "RefundRequest",
                newName: "IX_RefundRequest_EnrollmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Media_MediaTypeId",
                table: "Medias",
                newName: "IX_Medias_MediaTypeId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 263, DateTimeKind.Local).AddTicks(1459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 243, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Topics",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(7734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StudentProgresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(7779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 243, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(7101),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Quizzes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(6510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuizAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(4219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(3405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(2812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionAttempts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(2159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(4159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(4933),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MediaTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(3612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Levels",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(1444),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(8021),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonReports",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(94),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonMedias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(9164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LessonContents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(8665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FavoriteCourses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(2159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Enrollments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Discussions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(8308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DiscussionReplies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 261, DateTimeKind.Local).AddTicks(9182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleStart",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 240, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleEnd",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(1211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 240, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(1358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 240, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseRatings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(4251),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 240, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Answers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 260, DateTimeKind.Local).AddTicks(7390),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 241, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RefundRequest",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(5660),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Medias",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 6, 22, 41, 43, 262, DateTimeKind.Local).AddTicks(3004),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 6, 22, 49, 11, 242, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefundRequest",
                table: "RefundRequest",
                column: "RefundRequestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medias",
                table: "Medias",
                column: "MediaId");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonMedias_Medias_MediaId",
                table: "LessonMedias",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "MediaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_MediaTypes_MediaTypeId",
                table: "Medias",
                column: "MediaTypeId",
                principalTable: "MediaTypes",
                principalColumn: "MediaTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RefundRequest_Enrollments_EnrollmentId",
                table: "RefundRequest",
                column: "EnrollmentId",
                principalTable: "Enrollments",
                principalColumn: "EnrollmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
