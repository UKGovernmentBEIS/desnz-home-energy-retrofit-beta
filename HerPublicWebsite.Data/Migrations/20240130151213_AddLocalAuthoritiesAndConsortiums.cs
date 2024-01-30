using HerPublicWebsite.Data.Seeds;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using HerPublicWebsite.BusinessLogic.Models.Enums;

#nullable disable

namespace HerPublicWebsite.Data.Migrations
{
    public partial class AddLocalAuthoritiesAndConsortiums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consortium",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConsortiumCode = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consortium", x => x.Id);
                    table.UniqueConstraint("AK_Consortium_ConsortiumCode", x => x.ConsortiumCode);
                });

            migrationBuilder.CreateTable(
                name: "LocalAuthority",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustodianCode = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    WebsiteUrl = table.Column<string>(type: "text", nullable: true),
                    ConsortiumCode = table.Column<string>(type: "text", nullable: true),
                    IncomeThreshold = table.Column<int>(type: "integer", nullable: false),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalAuthority", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocalAuthority_Consortium_ConsortiumCode",
                        column: x => x.ConsortiumCode,
                        principalTable: "Consortium",
                        principalColumn: "ConsortiumCode");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consortium_ConsortiumCode",
                table: "Consortium",
                column: "ConsortiumCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocalAuthority_ConsortiumCode",
                table: "LocalAuthority",
                column: "ConsortiumCode");

            migrationBuilder.CreateIndex(
                name: "IX_LocalAuthority_CustodianCode",
                table: "LocalAuthority",
                column: "CustodianCode",
                unique: true);

            var localAuthoritySeedData = LocalAuthoritySeedData.Data;
            var consortiumSeedData = ConsortiumSeedData.Data;

            foreach (var c in consortiumSeedData)
            {
                migrationBuilder.InsertData(table: "Consortium", columns: new[] { "ConsortiumCode", "Name" },
                    values: new object[] { c.ConsortiumCode, c.Name });
            }
            
            foreach (var la in localAuthoritySeedData)
            {
                migrationBuilder.InsertData(table: "LocalAuthority", columns: new[] { "CustodianCode", "Name", "Status", "WebsiteUrl", "ConsortiumCode", "IncomeThreshold" },
                    values: new object[] { la.CustodianCode, la.Name, la.Status, la.WebsiteUrl, la.ConsortiumCode, la.IncomeThreshold });
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalAuthority");

            migrationBuilder.DropTable(
                name: "Consortium");
        }
    }
}
