using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VTSAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    Organization = table.Column<string>(nullable: true),
                    Emailaddress = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Photopath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VehicleNumber = table.Column<string>(nullable: true),
                    VehicleType = table.Column<string>(nullable: true),
                    ChassisNumber = table.Column<string>(nullable: true),
                    EngineNumber = table.Column<string>(nullable: true),
                    Manufacturingyear = table.Column<string>(nullable: true),
                    Loadcarryingcapacity = table.Column<string>(nullable: true),
                    Makeofvehicle = table.Column<string>(nullable: true),
                    ModelNumber = table.Column<string>(nullable: true),
                    Bodytype = table.Column<string>(nullable: true),
                    Organisationname = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    UserID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleID);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Emailaddress", "Location", "MobileNumber", "Name", "Organization", "Photopath" },
                values: new object[] { 1, "Electronic Items", "Electronics", "Electronic Items", "Electronics", "Electronics", "Electronic Items" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Emailaddress", "Location", "MobileNumber", "Name", "Organization", "Photopath" },
                values: new object[] { 2, "Electronic Items2", "Electronics2", "Electronic Items2", "Electronics2", "Electronics2", "Electronic Items2" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Emailaddress", "Location", "MobileNumber", "Name", "Organization", "Photopath" },
                values: new object[] { 3, "Electronic Items3", "Electronics3", "Electronic Items3", "Electronics3", "Electronics3", "Electronic Items3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
