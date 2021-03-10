using Microsoft.EntityFrameworkCore.Migrations;

namespace ThirdPartyBookingApi.Migrations
{
    public partial class AddTablesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ThirdPartyApplications",
                columns: table => new
                {
                    RequestID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleRegNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BodyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PremiumAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThirdPartyApplications", x => x.RequestID);
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThirdPartyApplications");

            migrationBuilder.DropTable(
                name: "VehicleInformation");
        }
    }
}
