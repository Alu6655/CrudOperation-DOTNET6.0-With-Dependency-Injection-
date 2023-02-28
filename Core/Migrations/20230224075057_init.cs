using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anxiety_RegPatients",
                columns: table => new
                {
                    Pid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pfirstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Page = table.Column<int>(type: "int", nullable: false),
                    Pgender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pdob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Paddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pstate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pcity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pcontact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prefferalname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pbloodgroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ppassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pemail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anxiety_RegPatients", x => x.Pid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anxiety_RegPatients");
        }
    }
}
