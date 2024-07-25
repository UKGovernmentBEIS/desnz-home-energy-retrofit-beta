using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

#nullable disable

namespace HerPublicWebsite.Data.Migrations
{
    public partial class DeleteSessionsContents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Operations.Add(new SqlOperation
            {
                Sql = "TRUNCATE TABLE \"Sessions\""
            });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
