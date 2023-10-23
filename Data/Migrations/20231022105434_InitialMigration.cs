using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinTrack.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasicClients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EntityName = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ABN = table.Column<string>(type: "TEXT", nullable: true),
                    ACN = table.Column<string>(type: "TEXT", nullable: true),
                    DirectorsName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicClients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BasicClients",
                columns: new[] { "Id", "ABN", "ACN", "DirectorsName", "EntityName" },
                values: new object[,]
                {
                    { 1, "01234567890", "123456789", "Director Number 1", "Company 1 Pty Ltd" },
                    { 2, "01234567890", "123456789", "Director Number 2", "Company 2 Pty Ltd" },
                    { 3, "01234567890", "123456789", "Director Number 3", "Company 3 Pty Ltd" },
                    { 4, "01234567890", "123456789", "Director Number 4", "Company 4 Pty Ltd" },
                    { 5, "01234567890", "123456789", "Director Number 5", "Company 5 Pty Ltd" },
                    { 6, "01234567890", "123456789", "Director Number 6", "Company 6 Pty Ltd" },
                    { 7, "01234567890", "123456789", "Director Number 7", "Company 7 Pty Ltd" },
                    { 8, "01234567890", "123456789", "Director Number 8", "Company 8 Pty Ltd" },
                    { 9, "01234567890", "123456789", "Director Number 9", "Company 9 Pty Ltd" },
                    { 10, "01234567890", "123456789", "Director Number 10", "Company 10 Pty Ltd" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasicClients");
        }
    }
}
