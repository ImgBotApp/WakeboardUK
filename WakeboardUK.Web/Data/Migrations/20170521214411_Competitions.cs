using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WakeboardUK.Web.Migrations
{
    public partial class Competitions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    CompetitionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    accommodation = table.Column<string>(nullable: true),
                    country_id = table.Column<int>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: true),
                    end_date = table.Column<DateTime>(nullable: true),
                    entry = table.Column<string>(nullable: true),
                    location = table.Column<string>(nullable: true),
                    location_id = table.Column<int>(nullable: true),
                    notes = table.Column<string>(nullable: true),
                    official_url = table.Column<string>(nullable: true),
                    photo_content_type = table.Column<string>(nullable: true),
                    photo_file_name = table.Column<string>(nullable: true),
                    photo_file_size = table.Column<int>(nullable: true),
                    schedule = table.Column<string>(nullable: true),
                    short_name = table.Column<string>(nullable: true),
                    sponsors = table.Column<string>(nullable: true),
                    start_date = table.Column<DateTime>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.CompetitionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Competitions");
        }
    }
}
