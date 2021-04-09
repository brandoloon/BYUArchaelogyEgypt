using Microsoft.EntityFrameworkCore.Migrations;

namespace BYUArchaeologyEgypt.Migrations
{
    public partial class simplify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BiologicalSamples_Burials_BurialID",
                table: "BiologicalSamples");

            migrationBuilder.DropTable(
                name: "AgesAtDeath");

            migrationBuilder.DropTable(
                name: "BurialWrappings");

            migrationBuilder.DropTable(
                name: "HairColors");

            migrationBuilder.DropTable(
                name: "Sexes");

            migrationBuilder.DropIndex(
                name: "IX_BiologicalSamples_BurialID",
                table: "BiologicalSamples");

            migrationBuilder.DropColumn(
                name: "BurialID",
                table: "BiologicalSamples");

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "Burials",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Hair_color",
                table: "Burials",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Gender_GE",
                table: "Burials",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Burial_wrapping",
                table: "Burials",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Age_bracket_at_death",
                table: "Burials",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Sex",
                table: "Burials",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "Hair_color",
                table: "Burials",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "Gender_GE",
                table: "Burials",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "Burial_wrapping",
                table: "Burials",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "Age_bracket_at_death",
                table: "Burials",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "BurialID",
                table: "BiologicalSamples",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AgesAtDeath",
                columns: table => new
                {
                    AgeCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgesAtDeath", x => x.AgeCode);
                });

            migrationBuilder.CreateTable(
                name: "BurialWrappings",
                columns: table => new
                {
                    BurialWrappingCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BurialWrappingDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BurialWrappings", x => x.BurialWrappingCode);
                });

            migrationBuilder.CreateTable(
                name: "HairColors",
                columns: table => new
                {
                    HairColorCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HairColorDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HairColors", x => x.HairColorCode);
                });

            migrationBuilder.CreateTable(
                name: "Sexes",
                columns: table => new
                {
                    SexCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SexDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexes", x => x.SexCode);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BiologicalSamples_BurialID",
                table: "BiologicalSamples",
                column: "BurialID");

            migrationBuilder.AddForeignKey(
                name: "FK_BiologicalSamples_Burials_BurialID",
                table: "BiologicalSamples",
                column: "BurialID",
                principalTable: "Burials",
                principalColumn: "BurialID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
