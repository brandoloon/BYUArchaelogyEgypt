using Microsoft.EntityFrameworkCore.Migrations;

namespace BYUArchaeologyEgypt.Migrations
{
    public partial class secondCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "C14CalendarDate",
                table: "BiologicalSample",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "C14_2017",
                table: "BiologicalSample",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CalendarDateAVG",
                table: "BiologicalSample",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CalendarDateMAX",
                table: "BiologicalSample",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CalendarDateMIN",
                table: "BiologicalSample",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CalendarDateSPAN",
                table: "BiologicalSample",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "BiologicalSample",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConventionalC14Age",
                table: "BiologicalSample",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Foci",
                table: "BiologicalSample",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "BiologicalSample",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Questions",
                table: "BiologicalSample",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Size",
                table: "BiologicalSample",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "C14CalendarDate",
                table: "BiologicalSample");

            migrationBuilder.DropColumn(
                name: "C14_2017",
                table: "BiologicalSample");

            migrationBuilder.DropColumn(
                name: "CalendarDateAVG",
                table: "BiologicalSample");

            migrationBuilder.DropColumn(
                name: "CalendarDateMAX",
                table: "BiologicalSample");

            migrationBuilder.DropColumn(
                name: "CalendarDateMIN",
                table: "BiologicalSample");

            migrationBuilder.DropColumn(
                name: "CalendarDateSPAN",
                table: "BiologicalSample");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "BiologicalSample");

            migrationBuilder.DropColumn(
                name: "ConventionalC14Age",
                table: "BiologicalSample");

            migrationBuilder.DropColumn(
                name: "Foci",
                table: "BiologicalSample");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "BiologicalSample");

            migrationBuilder.DropColumn(
                name: "Questions",
                table: "BiologicalSample");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "BiologicalSample");
        }
    }
}
