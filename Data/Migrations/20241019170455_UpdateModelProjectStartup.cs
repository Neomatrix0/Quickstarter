using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quickstarter.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModelProjectStartup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contributions_Projects_ProjectId",
                table: "Contributions");

            migrationBuilder.DropIndex(
                name: "IX_Contributions_ProjectId",
                table: "Contributions");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Projects",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "ProjectStartupId",
                table: "Contributions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contributions_ProjectStartupId",
                table: "Contributions",
                column: "ProjectStartupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contributions_Projects_ProjectStartupId",
                table: "Contributions",
                column: "ProjectStartupId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contributions_Projects_ProjectStartupId",
                table: "Contributions");

            migrationBuilder.DropIndex(
                name: "IX_Contributions_ProjectStartupId",
                table: "Contributions");

            migrationBuilder.DropColumn(
                name: "ProjectStartupId",
                table: "Contributions");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Projects",
                newName: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Contributions_ProjectId",
                table: "Contributions",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contributions_Projects_ProjectId",
                table: "Contributions",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
