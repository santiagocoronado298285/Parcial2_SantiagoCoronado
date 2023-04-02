using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppBoleteria.Migrations
{
    /// <inheritdoc />
    public partial class modifieddatabase_entityTickets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Tickets",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tickets",
                newName: "Guid");
        }
    }
}
