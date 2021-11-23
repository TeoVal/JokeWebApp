using Microsoft.EntityFrameworkCore.Migrations;

namespace JokesWebApp.Data.Migrations
{
    public partial class AddedNameofthejokeForKnockKnockJoke : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "KnockKnockJoke",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "KnockKnockJoke");
        }
    }
}
