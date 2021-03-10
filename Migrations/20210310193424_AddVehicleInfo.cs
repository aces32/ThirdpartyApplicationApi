using Microsoft.EntityFrameworkCore.Migrations;

namespace ThirdPartyBookingApi.Migrations
{
    public partial class AddVehicleInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThirdPartyApplications_VehicleInformation_VehicleInformationVehicleInfoID",
                table: "ThirdPartyApplications");

            migrationBuilder.DropTable(
                name: "VehicleInformation");

            migrationBuilder.DropIndex(
                name: "IX_ThirdPartyApplications_VehicleInformationVehicleInfoID",
                table: "ThirdPartyApplications");

            migrationBuilder.DropColumn(
                name: "VehicleInformationVehicleInfoID",
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

            migrationBuilder.CreateTable(
                name: "VehicleMakeInformation",
                columns: table => new
                {
                    VehicleMakeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleMake = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleMakeInformation", x => x.VehicleMakeID);
                });

            migrationBuilder.CreateTable(
                name: "VehicleModelInformation",
                columns: table => new
                {
                    VehicleModelID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VehicleModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleMakeInformationVehicleMakeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModelInformation", x => x.VehicleModelID);
                    table.ForeignKey(
                        name: "FK_VehicleModelInformation_VehicleMakeInformation_VehicleMakeInformationVehicleMakeID",
                        column: x => x.VehicleMakeInformationVehicleMakeID,
                        principalTable: "VehicleMakeInformation",
                        principalColumn: "VehicleMakeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModelInformation_VehicleMakeInformationVehicleMakeID",
                table: "VehicleModelInformation",
                column: "VehicleMakeInformationVehicleMakeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleModelInformation");

            migrationBuilder.DropTable(
                name: "VehicleMakeInformation");

            migrationBuilder.DropColumn(
                name: "VehicleMake",
                table: "ThirdPartyApplications");

            migrationBuilder.DropColumn(
                name: "VehicleModel",
                table: "ThirdPartyApplications");

            migrationBuilder.AddColumn<string>(
                name: "VehicleInformationVehicleInfoID",
                table: "ThirdPartyApplications",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VehicleInformation",
                columns: table => new
                {
                    VehicleInfoID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VehicleMake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleModel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleInformation", x => x.VehicleInfoID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ThirdPartyApplications_VehicleInformationVehicleInfoID",
                table: "ThirdPartyApplications",
                column: "VehicleInformationVehicleInfoID");

            migrationBuilder.AddForeignKey(
                name: "FK_ThirdPartyApplications_VehicleInformation_VehicleInformationVehicleInfoID",
                table: "ThirdPartyApplications",
                column: "VehicleInformationVehicleInfoID",
                principalTable: "VehicleInformation",
                principalColumn: "VehicleInfoID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
