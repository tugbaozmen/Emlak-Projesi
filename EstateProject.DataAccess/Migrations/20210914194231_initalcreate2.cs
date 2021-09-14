using Microsoft.EntityFrameworkCore.Migrations;

namespace EstateProject.DataAccess.Migrations
{
    public partial class initalcreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Estates_EstateTypeId",
                table: "Estates");

            migrationBuilder.CreateIndex(
                name: "IX_Estates_EstateTypeId",
                table: "Estates",
                column: "EstateTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Estates_EstateTypeId",
                table: "Estates");

            migrationBuilder.CreateIndex(
                name: "IX_Estates_EstateTypeId",
                table: "Estates",
                column: "EstateTypeId",
                unique: true);
        }
    }
}
