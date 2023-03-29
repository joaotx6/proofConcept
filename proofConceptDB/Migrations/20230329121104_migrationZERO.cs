using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proofConceptDB.Migrations
{
    public partial class migrationZERO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "wands",
                columns: table => new
                {
                    wandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    core = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    flexibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    length = table.Column<int>(type: "int", nullable: true),
                    size = table.Column<float>(type: "real", nullable: true),
                    imgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
