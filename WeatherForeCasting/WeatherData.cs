using System;
using Newtonsoft.Json;
using System.Linq;
namespace WeatherForeCasting
{
    public class WeatherData
    {
        public string weatherIconName = ""; 
        public string updateWeatherIcon(int condition)
        {
            if (condition >= 0 && condition <= 300) return "tstorm1.png";
            else if (condition >= 301 && condition <= 500) return "light_rain.png";
            else if (condition >= 501 && condition <= 600) return "shower3.png";
            else if (condition >= 601 && condition <= 700) return "snow4.png";
            else if (condition >= 701 && condition <= 771) return "fog.png";
            else if (condition >= 772 && condition <= 799) return "tstorm3.png";
            else if (condition == 800) return "sunny.png";
            else if (condition >= 801 && condition <= 804) return "cloudy2.png";
            else if (condition >= 900 && condition <= 902 || condition >= 905 && condition <= 1000) return "tstorm3.png";
            else if (condition == 903) return "snow5.png";
            else if (condition == 904) return "sunny.png";
            else return "dunno"; 
        }

        [JsonProperty("name")]
        public string Title { get; set; }

        [JsonProperty("coord")]
        public Coord Coord { get; set; }

        [JsonProperty("weather")]
        public Weather[] Weather { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("visibility")]
        public long Visibility { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        [JsonProperty("dt")]
        public long Dt { get; set; }

        [JsonProperty("sys")]
        public Sys Sys { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("cod")]
        public long Cod { get; set; }
    }
    public class Clouds
    {
        [JsonProperty("all")]
        public long All { get; set; }
    }

    public class Coord
    {
        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }
    }

    public class Main
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        [JsonProperty("humidity")]
        public long Humidity { get; set; }

        [JsonProperty("temp_min")]
        public double TempMin { get; set; }

        [JsonProperty("temp_max")]
        public double TempMax { get; set; }
    }

    public class Sys
    {
        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("message")]
        public double Message { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("sunrise")]
        public long Sunrise { get; set; }

        [JsonProperty("sunset")]
        public long Sunset { get; set; }
    }

    public class Weather
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("main")]
        public string Visibility { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }

    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("deg")]
        public long Deg { get; set; }
    }
}