using Microsoft.EntityFrameworkCore.Migrations;

namespace AndySWilliams.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Families",
                columns: new[] { "Id", "ImageUrl", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 1, "Colton", "My name is Colton and I am 4 years old!", "Colton Williams", "My son the old soul." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Families",
                keyColumn: "Id",
                keyValue: 1);
        }

    }
}
