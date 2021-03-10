using Microsoft.EntityFrameworkCore.Migrations;

namespace ThirdPartyBookingApi.Migrations
{
    public partial class AddRemainingbookingColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThirdPartyApplications_VehicleModelInformation_VehicleModelInformationVehicleModelID",
                table: "ThirdPartyApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleModelInformation_VehicleMakeInformation_VehicleMakeInformationVehicleMakeID",
                table: "VehicleModelInformation");

            migrationBuilder.DropIndex(
                name: "IX_VehicleModelInformation_VehicleMakeInformationVehicleMakeID",
                table: "VehicleModelInformation");

            migrationBuilder.DropIndex(
                name: "IX_ThirdPartyApplications_VehicleModelInformationVehicleModelID",
                table: "ThirdPartyApplications");

            migrationBuilder.DropColumn(
                name: "VehicleMakeInformationVehicleMakeID",
                table: "VehicleModelInformation");

            migrationBuilder.DropColumn(
                name: "VehicleModelInformationVehicleModelID",
                table: "ThirdPartyApplications");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleMake",
                table: "ThirdPartyApplications");

            migrationBuilder.DropColumn(
                name: "VehicleModel",
                table: "ThirdPartyApplications");

            migrationBuilder.AddColumn<int>(
                name: "VehicleMakeInformationVehicleMakeID",
                table: "VehicleModelInformation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehicleModelInformationVehicleModelID",
                table: "ThirdPartyApplications",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModelInformation_VehicleMakeInformationVehicleMakeID",
                table: "VehicleModelInformation",
                column: "VehicleMakeInformationVehicleMakeID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleModelInformation_VehicleMakeInformation_VehicleMakeInformationVehicleMakeID",
                table: "VehicleModelInformation",
                column: "VehicleMakeInformationVehicleMakeID",
                principalTable: "VehicleMakeInformation",
                principalColumn: "VehicleMakeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
