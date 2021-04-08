using Microsoft.EntityFrameworkCore.Migrations;

namespace BYUArchaeologyEgypt.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Burials_BurialWrappings_BurialWrapping",
                table: "Burials");

            migrationBuilder.DropIndex(
                name: "IX_Burials_BurialWrapping",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "BurialWrapping",
                table: "Burials");

            migrationBuilder.AlterColumn<int>(
                name: "Hair_color",
                table: "Burials",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Burial_wrapping",
                table: "Burials",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Burial_wrapping",
                table: "Burials");

            migrationBuilder.AlterColumn<string>(
                name: "Hair_color",
                table: "Burials",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "BurialWrapping",
                table: "Burials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Burials_BurialWrapping",
                table: "Burials",
                column: "BurialWrapping");

            migrationBuilder.AddForeignKey(
                name: "FK_Burials_BurialWrappings_BurialWrapping",
                table: "Burials",
                column: "BurialWrapping",
                principalTable: "BurialWrappings",
                principalColumn: "BurialWrappingCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
