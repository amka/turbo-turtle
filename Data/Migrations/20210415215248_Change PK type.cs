using Microsoft.EntityFrameworkCore.Migrations;

namespace TurboTurtle.Data.Migrations
{
    public partial class ChangePKtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Issues_AspNetUsers_AccountId",
                table: "Issues");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Issues",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Issues_AccountId",
                table: "Issues",
                newName: "IX_Issues_AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Issues_AspNetUsers_AuthorId",
                table: "Issues",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Issues_AspNetUsers_AuthorId",
                table: "Issues");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Issues",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Issues_AuthorId",
                table: "Issues",
                newName: "IX_Issues_AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Issues_AspNetUsers_AccountId",
                table: "Issues",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
