using Microsoft.EntityFrameworkCore.Migrations;

namespace Core2Hastane.Data.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Randevular",
                columns: table => new
                {
                    RandevuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HastaAdiSoyadi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BolumAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoktorAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RandevuTarihi = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    RandevuSaati = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevular", x => x.RandevuId);
                });

            migrationBuilder.CreateTable(
                name: "Doktorlar",
                columns: table => new
                {
                    DoktorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoktorAdSoyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Unvan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RandevuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doktorlar", x => x.DoktorId);
                    table.ForeignKey(
                        name: "FK_Doktorlar_Randevular_RandevuId",
                        column: x => x.RandevuId,
                        principalTable: "Randevular",
                        principalColumn: "RandevuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hastalar",
                columns: table => new
                {
                    HastaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HastaAdiSoyadi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HastaTC = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    HastaDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RandevuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hastalar", x => x.HastaId);
                    table.ForeignKey(
                        name: "FK_Hastalar_Randevular_RandevuId",
                        column: x => x.RandevuId,
                        principalTable: "Randevular",
                        principalColumn: "RandevuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Poliklinikler",
                columns: table => new
                {
                    BolumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DoktorAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoktorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poliklinikler", x => x.BolumId);
                    table.ForeignKey(
                        name: "FK_Poliklinikler_Doktorlar_DoktorId",
                        column: x => x.DoktorId,
                        principalTable: "Doktorlar",
                        principalColumn: "DoktorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doktorlar_RandevuId",
                table: "Doktorlar",
                column: "RandevuId");

            migrationBuilder.CreateIndex(
                name: "IX_Hastalar_RandevuId",
                table: "Hastalar",
                column: "RandevuId");

            migrationBuilder.CreateIndex(
                name: "IX_Poliklinikler_DoktorId",
                table: "Poliklinikler",
                column: "DoktorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hastalar");

            migrationBuilder.DropTable(
                name: "Poliklinikler");

            migrationBuilder.DropTable(
                name: "Doktorlar");

            migrationBuilder.DropTable(
                name: "Randevular");
        }
    }
}
