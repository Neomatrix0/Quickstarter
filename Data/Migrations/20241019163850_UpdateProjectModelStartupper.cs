using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quickstarter.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProjectModelStartupper : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_AspNetUsers_StartupperId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_StartupperId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "StartupperId",
                table: "Projects",
                newName: "Startupper");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Projects",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ApplicationUserId",
                table: "Projects",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_AspNetUsers_ApplicationUserId",
                table: "Projects",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_AspNetUsers_ApplicationUserId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ApplicationUserId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "Startupper",
                table: "Projects",
                newName: "StartupperId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_StartupperId",
                table: "Projects",
                column: "StartupperId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_AspNetUsers_StartupperId",
                table: "Projects",
                column: "StartupperId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
