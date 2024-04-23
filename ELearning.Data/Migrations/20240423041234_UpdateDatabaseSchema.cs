using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearning.Data.Migrations
{
    public partial class UpdateDatabaseSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuizAttemptQuizAttemptStatus");

            migrationBuilder.AddColumn<int>(
                name: "QuizAttemptStatusId",
                table: "QuizAttempts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_QuizAttempts_QuizAttemptStatusId",
                table: "QuizAttempts",
                column: "QuizAttemptStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuizAttempts_QuizAttemptStatus_QuizAttemptStatusId",
                table: "QuizAttempts",
                column: "QuizAttemptStatusId",
                principalTable: "QuizAttemptStatus",
                principalColumn: "QuizAttemptStatusId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuizAttempts_QuizAttemptStatus_QuizAttemptStatusId",
                table: "QuizAttempts");

            migrationBuilder.DropIndex(
                name: "IX_QuizAttempts_QuizAttemptStatusId",
                table: "QuizAttempts");

            migrationBuilder.DropColumn(
                name: "QuizAttemptStatusId",
                table: "QuizAttempts");

            migrationBuilder.CreateTable(
                name: "QuizAttemptQuizAttemptStatus",
                columns: table => new
                {
                    QuizAttemptStatusId = table.Column<int>(type: "int", nullable: false),
                    QuizAttemptsQuizAttemptId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizAttemptQuizAttemptStatus", x => new { x.QuizAttemptStatusId, x.QuizAttemptsQuizAttemptId });
                    table.ForeignKey(
                        name: "FK_QuizAttemptQuizAttemptStatus_QuizAttempts_QuizAttemptsQuizAttemptId",
                        column: x => x.QuizAttemptsQuizAttemptId,
                        principalTable: "QuizAttempts",
                        principalColumn: "QuizAttemptId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuizAttemptQuizAttemptStatus_QuizAttemptStatus_QuizAttemptStatusId",
                        column: x => x.QuizAttemptStatusId,
                        principalTable: "QuizAttemptStatus",
                        principalColumn: "QuizAttemptStatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuizAttemptQuizAttemptStatus_QuizAttemptsQuizAttemptId",
                table: "QuizAttemptQuizAttemptStatus",
                column: "QuizAttemptsQuizAttemptId");
        }
    }
}
