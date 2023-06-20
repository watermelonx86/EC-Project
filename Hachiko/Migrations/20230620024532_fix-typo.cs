using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hachiko.Migrations
{
    /// <inheritdoc />
    public partial class fixtypo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DisplayOder",
                table: "Category",
                newName: "DisplayOrder");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DisplayOrder",
                table: "Category",
                newName: "DisplayOder");
        }
    }
}
