using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelWebSite.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commentss_Blogs_BlogID",
                table: "Commentss");

            migrationBuilder.RenameColumn(
                name: "BlogID",
                table: "Commentss",
                newName: "Blogid");

            migrationBuilder.RenameIndex(
                name: "IX_Commentss_BlogID",
                table: "Commentss",
                newName: "IX_Commentss_Blogid");

            migrationBuilder.AddForeignKey(
                name: "FK_Commentss_Blogs_Blogid",
                table: "Commentss",
                column: "Blogid",
                principalTable: "Blogs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commentss_Blogs_Blogid",
                table: "Commentss");

            migrationBuilder.RenameColumn(
                name: "Blogid",
                table: "Commentss",
                newName: "BlogID");

            migrationBuilder.RenameIndex(
                name: "IX_Commentss_Blogid",
                table: "Commentss",
                newName: "IX_Commentss_BlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_Commentss_Blogs_BlogID",
                table: "Commentss",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
