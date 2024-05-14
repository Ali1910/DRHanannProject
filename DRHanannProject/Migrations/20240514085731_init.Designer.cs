﻿// <auto-generated />
using DRHanannProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DRHanannProject.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240514085731_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DRHanannProject.Models.alexWeatherData", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("apparent_temperature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dew_point_2m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diffuse_radiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diffuse_radiation_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direct_normal_irradiance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direct_normal_irradiance_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direct_radiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direct_radiation_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("humidity_2m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("minute")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("month")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("precipitation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pressure_msl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rain")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortwave_radiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortwave_radiation_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_moisture_0_to_7cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_moisture_7_to_28cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_temperature_0_to_7cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_temperature_100_to_255cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_temperature_28_to_100cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_temperature_7_to_28cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surface_pressure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("temperature_2m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terrestrial_radiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terrestrial_radiation_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wind_direction_100m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wind_direction_10m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wind_speed_100m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wind_speed_10m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("alexWeatherData");
                });

            modelBuilder.Entity("DRHanannProject.Models.AswanweatherData", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("apparent_temperature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dew_point_2m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diffuse_radiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diffuse_radiation_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direct_normal_irradiance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direct_normal_irradiance_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direct_radiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direct_radiation_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("humidity_2m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("minute")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("month")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("precipitation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pressure_msl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rain")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortwave_radiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortwave_radiation_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_moisture_0_to_7cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_moisture_7_to_28cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_temperature_0_to_7cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_temperature_100_to_255cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_temperature_28_to_100cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_temperature_7_to_28cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surface_pressure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("temperature_2m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terrestrial_radiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terrestrial_radiation_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wind_direction_100m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wind_direction_10m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wind_speed_100m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wind_speed_10m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("aswanweatherData");
                });

            modelBuilder.Entity("DRHanannProject.Models.cairoWeatherData", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("apparent_temperature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dew_point_2m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diffuse_radiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diffuse_radiation_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direct_normal_irradiance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direct_normal_irradiance_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direct_radiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direct_radiation_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("humidity_2m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("minute")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("month")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("precipitation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pressure_msl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rain")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortwave_radiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortwave_radiation_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_moisture_0_to_7cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_moisture_7_to_28cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_temperature_0_to_7cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_temperature_100_to_255cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_temperature_28_to_100cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_temperature_7_to_28cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surface_pressure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("temperature_2m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terrestrial_radiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terrestrial_radiation_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wind_direction_100m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wind_direction_10m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wind_speed_100m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wind_speed_10m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("cairoWeatherData");
                });

            modelBuilder.Entity("DRHanannProject.Models.modules", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("modules");
                });

            modelBuilder.Entity("DRHanannProject.Models.power", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("cityId")
                        .HasColumnType("int");

                    b.Property<int>("moduleId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("power");
                });

            modelBuilder.Entity("DRHanannProject.Models.suezWeatherData", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("apparent_temperature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dew_point_2m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diffuse_radiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diffuse_radiation_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direct_normal_irradiance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direct_normal_irradiance_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direct_radiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direct_radiation_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("humidity_2m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("minute")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("month")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("precipitation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pressure_msl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rain")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortwave_radiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortwave_radiation_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_moisture_0_to_7cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_moisture_7_to_28cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_temperature_0_to_7cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_temperature_100_to_255cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_temperature_28_to_100cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_temperature_7_to_28cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surface_pressure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("temperature_2m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terrestrial_radiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terrestrial_radiation_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wind_direction_100m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wind_direction_10m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wind_speed_100m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wind_speed_10m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("suezWeatherData");
                });

            modelBuilder.Entity("DRHanannProject.Models.tantaWeatherData", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("apparent_temperature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dew_point_2m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diffuse_radiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diffuse_radiation_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direct_normal_irradiance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direct_normal_irradiance_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direct_radiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direct_radiation_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("humidity_2m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("minute")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("month")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("precipitation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pressure_msl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rain")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortwave_radiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortwave_radiation_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_moisture_0_to_7cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_moisture_7_to_28cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_temperature_0_to_7cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_temperature_100_to_255cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_temperature_28_to_100cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soil_temperature_7_to_28cm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surface_pressure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("temperature_2m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terrestrial_radiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terrestrial_radiation_instant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wind_direction_100m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wind_direction_10m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wind_speed_100m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wind_speed_10m")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tantaWeatherData");
                });

            modelBuilder.Entity("DRHanannProject.Models.user", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
