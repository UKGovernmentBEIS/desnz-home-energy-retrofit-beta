using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HerPublicWebsite.Data.Migrations
{
    public partial class AddReferralFollowUpTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReferralRequestFollowUps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReferralRequestId = table.Column<int>(type: "integer", nullable: true),
                    WasFollowedUp = table.Column<bool>(type: "boolean", nullable: false),
                    DateOfFollowUpResponse = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferralRequestFollowUps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReferralRequestFollowUps_ReferralRequests_ReferralRequestId",
                        column: x => x.ReferralRequestId,
                        principalTable: "ReferralRequests",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReferralRequestFollowUps_ReferralRequestId",
                table: "ReferralRequestFollowUps",
                column: "ReferralRequestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReferralRequestFollowUps");
        }
    }
}
