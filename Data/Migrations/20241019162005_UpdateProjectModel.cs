using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quickstarter.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProjectModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_AspNetUsers_StartupperId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Projects",
                newName: "WebsiteLink");

            migrationBuilder.RenameColumn(
                name: "GoalAmount",
                table: "Projects",
                newName: "TargetFunding");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Projects",
                newName: "Sector");

            migrationBuilder.RenameColumn(
                name: "CurrentAmount",
                table: "Projects",
                newName: "FutureGoals");

            migrationBuilder.AlterColumn<string>(
                name: "StartupperId",
                table: "Projects",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Projects",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Projects",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Employees",
                table: "Projects",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "InitialCapital",
                table: "Projects",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectDescription",
                table: "Projects",
                type: "TEXT",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_AspNetUsers_StartupperId",
                table: "Projects",
                column: "StartupperId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_AspNetUsers_StartupperId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Employees",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "InitialCapital",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectDescription",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "WebsiteLink",
                table: "Projects",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "TargetFunding",
                table: "Projects",
                newName: "GoalAmount");

            migrationBuilder.RenameColumn(
                name: "Sector",
                table: "Projects",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "FutureGoals",
                table: "Projects",
                newName: "CurrentAmount");

            migrationBuilder.AlterColumn<string>(
                name: "StartupperId",
                table: "Projects",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_AspNetUsers_StartupperId",
                table: "Projects",
                column: "StartupperId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
