using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearning.Data.Migrations
{
    public partial class UpdateDatabaseSchema4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Users",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 26, 22, 40, 13, 255, DateTimeKind.Local).AddTicks(8380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 26, 22, 21, 57, 760, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ca6c888a-eb18-4718-9ef4-b6eb4467f966");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "16a87e33-158e-4e36-b0c7-3defddcc20e4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "7124b4fd-4b2b-4df5-89e6-a9469921719e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 40, 13, 258, DateTimeKind.Local).AddTicks(9156), "834fd74a-7a39-4575-b011-0cd220b7c2e0", "AQAAAAEAACcQAAAAENYQljYEGsRfR0fFHh2nGakXQfgWgV9nyqOPxz6MEqT0CSWPJJHSJtU17AVilwYxJw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 40, 13, 260, DateTimeKind.Local).AddTicks(85), "454b8a04-fe68-4bc0-baa7-d96786827e6f", "AQAAAAEAACcQAAAAEFLF8Ef8oO4fdxpk7+y6iasJ+IUOYdkol57C5D1SwUfHI9dKrhAan6zLe/1KL5CVJQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 40, 13, 261, DateTimeKind.Local).AddTicks(948), "8d52b14e-78ef-4837-8e4f-b143d93c0dc3", "AQAAAAEAACcQAAAAEOFDdnEZz0eS6ALHan4JL5c6/N3cvLv3QCc9cO5oEBAtG+z4x2yand4Er0/FKe8ELA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 40, 13, 262, DateTimeKind.Local).AddTicks(1539), "336de601-d7a8-49f3-81d5-ce6705e8c27c", "AQAAAAEAACcQAAAAEMTOKVVXJlVH57qMXjXOeDOjDob6xbXly468FeX7DnaAwHFXQDKJ4iX2F4H/8H610g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 40, 13, 263, DateTimeKind.Local).AddTicks(2269), "a07dd038-e43c-48db-9308-c085e338769c", "AQAAAAEAACcQAAAAEFC26WU0Ua6qzUdcPMKzSLV2AuwLTs6QQOf10895oeQN6FkpAqch+ctA6rTzeKZyGw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 26, 22, 21, 57, 760, DateTimeKind.Local).AddTicks(4969),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 26, 22, 40, 13, 255, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "fe634f1b-542c-4c32-b9bf-bfa2205b852d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "aca438aa-21da-49d8-9874-15d07a6ef2bc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "282fd2da-1bdc-4fee-8f00-2e46ee3a670b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 21, 57, 763, DateTimeKind.Local).AddTicks(5237), "bf06dcc1-ec05-4597-bdf6-e56eedcc102d", "AQAAAAEAACcQAAAAEPJDtafyoiilnZt14yHj43GIjeY0WBMqAz4B+aSFgyn9EjOZ6RJIgqGo2WXRmiOPJg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 21, 57, 764, DateTimeKind.Local).AddTicks(7349), "b1fa58da-5520-40c9-a075-025a012a810e", "AQAAAAEAACcQAAAAENsj+3m/cmUwMQMuXl5Ij5NM0Qy4M1olPFTKdOXkcV+6GMMffvRCIhaFyIjyma4Mzw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 21, 57, 765, DateTimeKind.Local).AddTicks(9324), "69807bc8-de07-43d4-a6ca-349402a365eb", "AQAAAAEAACcQAAAAEG4wiTQCe2xf17QbD3FXyzU/3UcI4pcx/XZo774/EOOEZ1j7OLJdPipgTZsNrRo05Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 21, 57, 766, DateTimeKind.Local).AddTicks(9881), "b812a0e7-f247-436f-9346-e1a19d199b9e", "AQAAAAEAACcQAAAAEGuQdKO5+I20df41MdCtvlUJgGRK1hI9Lu9g4mqxc9JeICBF/+v6UVNUhkGUf99xew==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 21, 57, 768, DateTimeKind.Local).AddTicks(1732), "1cbe5426-b0c2-4837-a06c-65a7f2a26ef3", "AQAAAAEAACcQAAAAEENazOnIQoORFmvQohqANifuVvzF4PkGEeoVLUffxpfIcaDf7Rl7uzsJB5MXAJj9yQ==" });
        }
    }
}
