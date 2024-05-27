using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearning.Data.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 22, 14, 30, 24, 676, DateTimeKind.Local).AddTicks(1674),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 22, 14, 27, 6, 78, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "LevelId",
                keyValue: 1,
                column: "LevelName",
                value: "Cơ bản");

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "LevelId",
                keyValue: 2,
                column: "LevelName",
                value: "Trung cấp");

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "LevelId",
                keyValue: 3,
                column: "LevelName",
                value: "Nâng cao");

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "LevelId",
                keyValue: 4,
                column: "LevelName",
                value: "Mọi cấp độ");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "52698705-d08f-43fa-8197-2ab0d797bcf9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "54bd43bb-73b8-4384-9677-78b0f59f2b57");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "e480e11f-7954-46ca-bc5b-76c51ec60c41");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "NormalizedEmail", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 22, 14, 30, 24, 679, DateTimeKind.Local).AddTicks(2912), "f0b3e333-c354-497c-b307-c08aff9d4a30", "admin01@example.com", "AQAAAAEAACcQAAAAEBgwqajLZIk5NGGCWHNvDgKEe7Nah2yPunr3BPEyCb/c9lCWmcW8Krtml5xdCFjitQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "NormalizedEmail", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 22, 14, 30, 24, 680, DateTimeKind.Local).AddTicks(4003), "96c2f191-6d5a-4ff1-8fc5-3166af270227", "instructor01@example.com", "AQAAAAEAACcQAAAAENUDkv/ebOsKhAWeyA9uOw7erxfZXTBCd/gXlj8lPSz9etNdJ1Hd84ZfizcBkp+wxQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "NormalizedEmail", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 22, 14, 30, 24, 681, DateTimeKind.Local).AddTicks(4739), "0cbc474d-78b9-454c-9dcb-1811d38d839b", "student01@example.com", "AQAAAAEAACcQAAAAEB5z3N2mjzl85CUa2P4zZZraRsKsBXsdVMkryvRZJVoaa/XK3Tx6e0GOmVH+/Od6lA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 22, 14, 30, 24, 682, DateTimeKind.Local).AddTicks(5287), "f185c081-6981-4fd9-8b91-86ea9001b2d2", "AQAAAAEAACcQAAAAEJpjdXJreQraGzHpBFyYF+6g+g0NNh6VgMt0a0OTOn6XGVKmQYM8qRu9w1XzB+oitQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 22, 14, 30, 24, 683, DateTimeKind.Local).AddTicks(5863), "d92f6541-9fad-4d72-a38c-4b7ec9d04939", "AQAAAAEAACcQAAAAEG1xPrH9XGAArO5MlfVBlMEXTtFgDRPiGl0Uh2sKPSEnH5Dr1H6Gp/vPU9XpB958KA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 22, 14, 27, 6, 78, DateTimeKind.Local).AddTicks(2751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 22, 14, 30, 24, 676, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "LevelId",
                keyValue: 1,
                column: "LevelName",
                value: "Beginner");

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "LevelId",
                keyValue: 2,
                column: "LevelName",
                value: "Intermediate");

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "LevelId",
                keyValue: 3,
                column: "LevelName",
                value: "Advance");

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "LevelId",
                keyValue: 4,
                column: "LevelName",
                value: "All level");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "571101ee-4364-4ca8-a8f0-dbac091928b5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "4e1d2b32-91d8-4a36-be12-d3ed7ec5206f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "8d804060-5764-481c-8f34-6e4754d981a9");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "NormalizedEmail", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 22, 14, 27, 6, 81, DateTimeKind.Local).AddTicks(6275), "1e15901c-0db1-4881-afa5-e1e1624c82ae", null, "AQAAAAEAACcQAAAAEF3DYBW8GDIDV4e187G1B/+8ux90bMESTR109AT2oeMQoiOezIhmJx/stPDbNFpr/w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "NormalizedEmail", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 22, 14, 27, 6, 82, DateTimeKind.Local).AddTicks(7213), "adcbfa7a-4e44-4d68-8155-ad60a06d5a5d", null, "AQAAAAEAACcQAAAAEIPRpDO18thMCNert/VW8ttCFbLBpdAafyzHZgnb7brH8G/bSy45fUJrD6Re/YmHpg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "NormalizedEmail", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 22, 14, 27, 6, 83, DateTimeKind.Local).AddTicks(7894), "3075e2b3-bcf0-4edd-92c5-96f0a9d2aa96", null, "AQAAAAEAACcQAAAAEP0/4gOuQdnO0dl9fUqMcaM96uPTVI7W01lOnBRClllBJLQujlrqKunM3FsBM4/Inw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 22, 14, 27, 6, 84, DateTimeKind.Local).AddTicks(8471), "ac53aa1e-c2ef-41c5-9834-4741c75663b0", "AQAAAAEAACcQAAAAEAU7K/X2xSHqNtbVs8G4+25eXD6SQHZ3j3arv4+5uWl0X+OshMszrV/UB+KzE/arpg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 22, 14, 27, 6, 85, DateTimeKind.Local).AddTicks(9049), "a5042651-c4f8-43ea-be8e-10810462e935", "AQAAAAEAACcQAAAAEDmc8HTSa2H+eZWea7wu6YvWq/BitrS7c5r4t5APMXstsG4YUgOY4Cny7Af0BVq1Yw==" });
        }
    }
}
