using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LePhamTheVu_231220962_de01.Migrations
{
    /// <inheritdoc />
    public partial class lptv_v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lptvComputer",
                columns: table => new
                {
                    LePhamTheVuComId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LePhamTheVuComName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LePhamTheVuComPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LePhamTheVuComImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LePhamTheVuComStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lptvComputer", x => x.LePhamTheVuComId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lptvComputer");
        }
    }
}
