using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myAppC.Migrations
{
    /// <inheritdoc />
    public partial class GdpNaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GDPperCapita",
                table: "Gaps",
                newName: "GdpPerCapita");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GdpPerCapita",
                table: "Gaps",
                newName: "GDPperCapita");
        }
    }
}
