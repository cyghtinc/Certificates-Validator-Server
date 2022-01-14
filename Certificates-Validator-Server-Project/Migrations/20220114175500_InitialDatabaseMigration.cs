using Microsoft.EntityFrameworkCore.Migrations;

namespace Certificates_Validator_Server_Project.Migrations
{
    public partial class InitialDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    sha256Hash = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    filename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    md5Hash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sha1Hash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filepath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fileSigned = table.Column<bool>(type: "bit", nullable: false),
                    fileSignatureCatalog = table.Column<bool>(type: "bit", nullable: false),
                    fileSignSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fileSignCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fileAuthenticodeSHA1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fileAuthenticodeSHA256 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fileAuthenticodeMD5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fileINCore = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.sha256Hash);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Files");
        }
    }
}
