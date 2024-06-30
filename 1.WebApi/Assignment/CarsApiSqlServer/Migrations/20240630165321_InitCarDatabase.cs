using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsApiInMemory.Migrations
{
    /// <inheritdoc />
    public partial class InitCarDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "carsDatabase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carsDatabase", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "carsDatabase",
                columns: new[] { "Id", "Category", "Name", "Price" },
                values: new object[] { 1, "Sport", "Ford Mustang", 55999.989999999998 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "carsDatabase");
        }
    }
}
