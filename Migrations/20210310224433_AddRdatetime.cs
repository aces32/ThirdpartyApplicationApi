using Microsoft.EntityFrameworkCore.Migrations;

namespace ThirdPartyBookingApi.Migrations
{
    public partial class AddRdatetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateOFBirth",
                table: "ThirdPartyApplications",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOFBirth",
                table: "ThirdPartyApplications");
        }
    }
}
