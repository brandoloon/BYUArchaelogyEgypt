using Microsoft.EntityFrameworkCore.Migrations;

namespace BYUArchaeologyEgypt.Migrations
{
    public partial class biosample : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BiologicalSample_Burials_BurialID",
                table: "BiologicalSample");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BiologicalSample",
                table: "BiologicalSample");

            migrationBuilder.RenameTable(
                name: "BiologicalSample",
                newName: "BiologicalSamples");

            migrationBuilder.RenameIndex(
                name: "IX_BiologicalSample_BurialID",
                table: "BiologicalSamples",
                newName: "IX_BiologicalSamples_BurialID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BiologicalSamples",
                table: "BiologicalSamples",
                column: "SampleId");

            migrationBuilder.AddForeignKey(
                name: "FK_BiologicalSamples_Burials_BurialID",
                table: "BiologicalSamples",
                column: "BurialID",
                principalTable: "Burials",
                principalColumn: "BurialID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BiologicalSamples_Burials_BurialID",
                table: "BiologicalSamples");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BiologicalSamples",
                table: "BiologicalSamples");

            migrationBuilder.RenameTable(
                name: "BiologicalSamples",
                newName: "BiologicalSample");

            migrationBuilder.RenameIndex(
                name: "IX_BiologicalSamples_BurialID",
                table: "BiologicalSample",
                newName: "IX_BiologicalSample_BurialID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BiologicalSample",
                table: "BiologicalSample",
                column: "SampleId");

            migrationBuilder.AddForeignKey(
                name: "FK_BiologicalSample_Burials_BurialID",
                table: "BiologicalSample",
                column: "BurialID",
                principalTable: "Burials",
                principalColumn: "BurialID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
