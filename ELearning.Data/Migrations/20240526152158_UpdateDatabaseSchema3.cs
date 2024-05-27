using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearning.Data.Migrations
{
    public partial class UpdateDatabaseSchema3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 26, 22, 21, 57, 760, DateTimeKind.Local).AddTicks(4969),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 26, 22, 19, 46, 80, DateTimeKind.Local).AddTicks(8303));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 26, 22, 19, 46, 80, DateTimeKind.Local).AddTicks(8303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 26, 22, 21, 57, 760, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "65175db3-fd67-4626-8173-13d2a09dbdc2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3e413c7f-e40c-493a-b4ae-667815ef24cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "ef4b857a-ec48-4027-8ede-194830e87f07");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 19, 46, 84, DateTimeKind.Local).AddTicks(489), "96bc2567-5d78-4c1d-a356-67a847dad7d5", "AQAAAAEAACcQAAAAEMBersONuZDsqRVngCesz5pbocF0CYEWeYQwjXK39HhSRVBWDKja9rfiu6YRXqZ6Ig==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 19, 46, 85, DateTimeKind.Local).AddTicks(3507), "3eaaadd4-7b57-4510-b7ef-138efb86285e", "AQAAAAEAACcQAAAAENNCSiw03CIO1nuuvAOIIN3vg2lEOCpZVWU12c5wkSr7F5p8qr5FZBZ2K+5+842s/Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 19, 46, 86, DateTimeKind.Local).AddTicks(5308), "d4c2297b-5e5f-4144-938f-39bec84154c9", "AQAAAAEAACcQAAAAEDKESB5INyni3WKSxrRRCBCO/WY0Y3F7M/Dvfi8IJWLNIQDw1TnhscyIvxklF2DOJw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 19, 46, 87, DateTimeKind.Local).AddTicks(7588), "3cd344e9-a796-4d2b-ba9b-7e9486100943", "AQAAAAEAACcQAAAAEFzZWXG94H4oqzd7Oc81eo323kk9Aad6dx9nznF56bRXMzuI+fBP/CkGoA9p8ubEHw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 19, 46, 89, DateTimeKind.Local).AddTicks(770), "bf6c37a1-f02d-4dfe-8340-058df77bb0b7", "AQAAAAEAACcQAAAAENjt1BgnGP9799lVWar+ZiZWp7N/7hwMWMvZtN+djOG1KEwfiz6zHkIN+tkrJ3YULg==" });
        }
    }
}
