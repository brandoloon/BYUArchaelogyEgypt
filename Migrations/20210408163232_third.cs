using Microsoft.EntityFrameworkCore.Migrations;

namespace BYUArchaeologyEgypt.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Burials_AgesAtDeath_AgeAtDeath",
                table: "Burials");

            migrationBuilder.DropIndex(
                name: "IX_Burials_AgeAtDeath",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "AgeAtDeath",
                table: "Burials");

            migrationBuilder.AddColumn<int>(
                name: "Age_bracket_at_death",
                table: "Burials",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age_bracket_at_death",
                table: "Burials");

            migrationBuilder.AddColumn<int>(
                name: "AgeAtDeath",
                table: "Burials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Burials_AgeAtDeath",
                table: "Burials",
                column: "AgeAtDeath");

            migrationBuilder.AddForeignKey(
                name: "FK_Burials_AgesAtDeath_AgeAtDeath",
                table: "Burials",
                column: "AgeAtDeath",
                principalTable: "AgesAtDeath",
                principalColumn: "AgeCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
