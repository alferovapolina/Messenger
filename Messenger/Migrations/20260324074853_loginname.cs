using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Messenger.Migrations
{
    /// <inheritdoc />
    public partial class loginname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_users_nickname",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "nickname",
                table: "users",
                newName: "name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "users",
                newName: "nickname");

            migrationBuilder.CreateIndex(
                name: "ix_users_nickname",
                table: "users",
                column: "nickname",
                unique: true);
        }
    }
}
