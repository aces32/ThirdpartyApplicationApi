using Microsoft.EntityFrameworkCore.Migrations;

namespace ThirdPartyBookingApi.Migrations
{
    public partial class removeMakeandModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleMake",
                table: "ThirdPartyApplications");

            migrationBuilder.DropColumn(
                name: "VehicleModel",
                table: "ThirdPartyApplications");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "VehicleMake",
                table: "ThirdPartyApplications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleModel",
                table: "ThirdPartyApplications",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
