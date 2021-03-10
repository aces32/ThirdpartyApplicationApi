using Microsoft.EntityFrameworkCore.Migrations;

namespace ThirdPartyBookingApi.Migrations
{
    public partial class BookingRequestid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VehicleModelInformationVehicleModelID",
                table: "ThirdPartyApplications",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ThirdPartyApplications_VehicleModelInformationVehicleModelID",
                table: "ThirdPartyApplications",
                column: "VehicleModelInformationVehicleModelID");

            migrationBuilder.AddForeignKey(
                name: "FK_ThirdPartyApplications_VehicleModelInformation_VehicleModelInformationVehicleModelID",
                table: "ThirdPartyApplications",
                column: "VehicleModelInformationVehicleModelID",
                principalTable: "VehicleModelInformation",
                principalColumn: "VehicleModelID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThirdPartyApplications_VehicleModelInformation_VehicleModelInformationVehicleModelID",
                table: "ThirdPartyApplications");

            migrationBuilder.DropIndex(
                name: "IX_ThirdPartyApplications_VehicleModelInformationVehicleModelID",
                table: "ThirdPartyApplications");

            migrationBuilder.DropColumn(
                name: "VehicleModelInformationVehicleModelID",
                table: "ThirdPartyApplications");
        }
    }
}
