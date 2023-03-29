using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proofConceptDB.Migrations
{
    public partial class migrationOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "wands",
                columns: table => new
                {
                    wandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    core = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    flexibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    length = table.Column<int>(type: "int", nullable: false),
                    size = table.Column<float>(type: "real", nullable: false),
                    imgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wands", x => x.wandId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wands");
        }
    }
}
