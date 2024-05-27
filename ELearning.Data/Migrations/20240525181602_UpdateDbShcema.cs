using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearning.Data.Migrations
{
    public partial class UpdateDbShcema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 26, 1, 16, 1, 454, DateTimeKind.Local).AddTicks(5407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 22, 14, 30, 24, 676, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "78fd0c83-f93d-4381-a1b1-b6800730dac9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e057178e-9d68-488a-b0fd-864465dbd942");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c3c6b7f1-7339-4d14-99e7-6c2cd0b14c30");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 1, 16, 1, 459, DateTimeKind.Local).AddTicks(1129), "14f73b62-468f-4368-97a6-cd63d1643620", "AQAAAAEAACcQAAAAELPdesm8yLvB366Cdr68NL6wmGqaqivsP7P4GOkrkn5xLFUaV3/kWVtJD1yGcccq5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 1, 16, 1, 460, DateTimeKind.Local).AddTicks(5091), "e73c5c59-2273-4f4d-aa21-162090a956d7", "AQAAAAEAACcQAAAAELQ5zcEPfhV5cbiqK3DfgDE3UUF96pe/6gXBpKm/Z6ybW0sPZ+IEwaZyUZDWd1r4rA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 1, 16, 1, 461, DateTimeKind.Local).AddTicks(8132), "4d522117-8c9b-49e5-9a02-82bf6e39a0a6", "AQAAAAEAACcQAAAAEGnkt6Q9VcwgHvDTM8mH8NvhvR3nhKxqz623wh5m3xEjOylwsoOVPXOIS0CJ//3ABQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 1, 16, 1, 463, DateTimeKind.Local).AddTicks(893), "c493abae-3980-44b4-93c7-828317e06679", "AQAAAAEAACcQAAAAEKEgEAtmwdlqL8vb8ImwrXihoi92RIU9GhquHDTRz/Nih5ot/AU4Fd/ppag/3Y/BIg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 1, 16, 1, 464, DateTimeKind.Local).AddTicks(2040), "20fc7213-e91b-4791-94ef-397220b9b831", "AQAAAAEAACcQAAAAECShwuuLO++SeKfadL0+DU/wLbeKpp+hBXrzucWQ+sDC6onQq+3VHKY5YQ7Zq5INPg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                oldDefaultValue: new DateTime(2024, 5, 26, 1, 16, 1, 454, DateTimeKind.Local).AddTicks(5407));

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
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 22, 14, 30, 24, 679, DateTimeKind.Local).AddTicks(2912), "f0b3e333-c354-497c-b307-c08aff9d4a30", "AQAAAAEAACcQAAAAEBgwqajLZIk5NGGCWHNvDgKEe7Nah2yPunr3BPEyCb/c9lCWmcW8Krtml5xdCFjitQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 22, 14, 30, 24, 680, DateTimeKind.Local).AddTicks(4003), "96c2f191-6d5a-4ff1-8fc5-3166af270227", "AQAAAAEAACcQAAAAENUDkv/ebOsKhAWeyA9uOw7erxfZXTBCd/gXlj8lPSz9etNdJ1Hd84ZfizcBkp+wxQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 22, 14, 30, 24, 681, DateTimeKind.Local).AddTicks(4739), "0cbc474d-78b9-454c-9dcb-1811d38d839b", "AQAAAAEAACcQAAAAEB5z3N2mjzl85CUa2P4zZZraRsKsBXsdVMkryvRZJVoaa/XK3Tx6e0GOmVH+/Od6lA==" });

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
    }
}
