using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoProject.Data.Migrations
{
    public partial class EducationDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Graduation_Board",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Graduation_Percentage",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Graduation_Year",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HSC_Board",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HSC_Percentage",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HSC_Year",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SSC_Board",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SSC_Percentage",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SSC_Year",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Graduation_Board",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Graduation_Percentage",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Graduation_Year",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "HSC_Board",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "HSC_Percentage",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "HSC_Year",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "SSC_Board",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "SSC_Percentage",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "SSC_Year",
                table: "Applications");
        }
    }
}
