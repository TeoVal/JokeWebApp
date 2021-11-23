using Microsoft.EntityFrameworkCore.Migrations;

namespace JokesWebApp.Data.Migrations
{
    public partial class RemoveWhoIsThereAnswerFromModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PunchLineQuestion",
                table: "KnockKnockJoke");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PunchLineQuestion",
                table: "KnockKnockJoke",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
