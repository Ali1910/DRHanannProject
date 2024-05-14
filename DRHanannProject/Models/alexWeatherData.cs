namespace DRHanannProject.Models
{
    public class alexWeatherData
    {
        public int id { get; set; }
        public string year { get; set; }
        public string month { get; set; }
        public string day { get; set; }
        public string hour { get; set; }
        public string minute { get; set; }
        public string temperature_2m { get; set; }
        public string humidity_2m { get; set; }
        public string dew_point_2m { get; set; }
        public string apparent_temperature { get; set; }
        public string precipitation { get; set; }
        public string rain { get; set; }
        public string pressure_msl  { get; set; }
        public string surface_pressure { get; set; }
        public string wind_speed_10m { get; set; }
        public string wind_speed_100m { get; set; }
        public string wind_direction_10m { get; set; }
        public string wind_direction_100m { get; set; }
        public string soil_temperature_0_to_7cm { get; set; }
        public string soil_temperature_7_to_28cm { get; set; }
        public string soil_temperature_28_to_100cm { get; set; }
        public string soil_temperature_100_to_255cm { get; set; }
        public string soil_moisture_0_to_7cm { get; set; }
        public string soil_moisture_7_to_28cm { get; set; }
        public string shortwave_radiation { get; set; }
        public string direct_radiation { get; set; }
        public string diffuse_radiation { get; set; }
        public string direct_normal_irradiance { get; set; }
        public string terrestrial_radiation { get; set; }
        public string shortwave_radiation_instant { get; set; }
        public string direct_radiation_instant { get; set; }
        public string diffuse_radiation_instant { get; set; }
        public string direct_normal_irradiance_instant { get; set; }
        public string terrestrial_radiation_instant { get; set; }
    }
}
