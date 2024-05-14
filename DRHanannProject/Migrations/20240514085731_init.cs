using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DRHanannProject.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "alexWeatherData",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    day = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    minute = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    temperature_2m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    humidity_2m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dew_point_2m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apparent_temperature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precipitation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pressure_msl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surface_pressure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wind_speed_10m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wind_speed_100m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wind_direction_10m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wind_direction_100m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_temperature_0_to_7cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_temperature_7_to_28cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_temperature_28_to_100cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_temperature_100_to_255cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_moisture_0_to_7cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_moisture_7_to_28cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shortwave_radiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direct_radiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diffuse_radiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direct_normal_irradiance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    terrestrial_radiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shortwave_radiation_instant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direct_radiation_instant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diffuse_radiation_instant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direct_normal_irradiance_instant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    terrestrial_radiation_instant = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alexWeatherData", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "aswanweatherData",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    day = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    minute = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    temperature_2m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    humidity_2m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dew_point_2m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apparent_temperature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precipitation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pressure_msl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surface_pressure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wind_speed_10m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wind_speed_100m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wind_direction_10m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wind_direction_100m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_temperature_0_to_7cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_temperature_7_to_28cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_temperature_28_to_100cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_temperature_100_to_255cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_moisture_0_to_7cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_moisture_7_to_28cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shortwave_radiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direct_radiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diffuse_radiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direct_normal_irradiance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    terrestrial_radiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shortwave_radiation_instant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direct_radiation_instant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diffuse_radiation_instant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direct_normal_irradiance_instant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    terrestrial_radiation_instant = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aswanweatherData", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cairoWeatherData",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    day = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    minute = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    temperature_2m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    humidity_2m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dew_point_2m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apparent_temperature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precipitation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pressure_msl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surface_pressure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wind_speed_10m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wind_speed_100m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wind_direction_10m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wind_direction_100m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_temperature_0_to_7cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_temperature_7_to_28cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_temperature_28_to_100cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_temperature_100_to_255cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_moisture_0_to_7cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_moisture_7_to_28cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shortwave_radiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direct_radiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diffuse_radiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direct_normal_irradiance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    terrestrial_radiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shortwave_radiation_instant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direct_radiation_instant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diffuse_radiation_instant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direct_normal_irradiance_instant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    terrestrial_radiation_instant = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cairoWeatherData", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "modules",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modules", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "power",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cityId = table.Column<int>(type: "int", nullable: false),
                    moduleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_power", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "suezWeatherData",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    day = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    minute = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    temperature_2m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    humidity_2m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dew_point_2m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apparent_temperature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precipitation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pressure_msl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surface_pressure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wind_speed_10m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wind_speed_100m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wind_direction_10m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wind_direction_100m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_temperature_0_to_7cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_temperature_7_to_28cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_temperature_28_to_100cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_temperature_100_to_255cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_moisture_0_to_7cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_moisture_7_to_28cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shortwave_radiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direct_radiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diffuse_radiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direct_normal_irradiance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    terrestrial_radiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shortwave_radiation_instant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direct_radiation_instant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diffuse_radiation_instant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direct_normal_irradiance_instant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    terrestrial_radiation_instant = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suezWeatherData", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tantaWeatherData",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    day = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    minute = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    temperature_2m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    humidity_2m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dew_point_2m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apparent_temperature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precipitation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pressure_msl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surface_pressure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wind_speed_10m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wind_speed_100m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wind_direction_10m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wind_direction_100m = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_temperature_0_to_7cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_temperature_7_to_28cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_temperature_28_to_100cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_temperature_100_to_255cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_moisture_0_to_7cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soil_moisture_7_to_28cm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shortwave_radiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direct_radiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diffuse_radiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direct_normal_irradiance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    terrestrial_radiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shortwave_radiation_instant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direct_radiation_instant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diffuse_radiation_instant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direct_normal_irradiance_instant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    terrestrial_radiation_instant = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tantaWeatherData", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alexWeatherData");

            migrationBuilder.DropTable(
                name: "aswanweatherData");

            migrationBuilder.DropTable(
                name: "cairoWeatherData");

            migrationBuilder.DropTable(
                name: "modules");

            migrationBuilder.DropTable(
                name: "power");

            migrationBuilder.DropTable(
                name: "suezWeatherData");

            migrationBuilder.DropTable(
                name: "tantaWeatherData");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
