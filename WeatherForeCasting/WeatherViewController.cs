using Foundation;
using System;
using UIKit;
using System.Linq;
using CoreLocation;
using System.Diagnostics;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace WeatherForeCasting
{

    public class RestService
    {
        HttpClient client;

        public RestService()
        {

            client = new HttpClient();
        }
        public async Task<WeatherData> GetWeatherData(String query)
        {
            WeatherData result = null;
            try
            {
                var response = await client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<WeatherData>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\t\tERROR {0}", ex.Message);
            }
            return result;
        }
	}


    public partial class WeatherViewController : UIViewController, ICLLocationManagerDelegate
    {
        public string OpenWeatherMapEndpoint = "https://api.openweathermap.org/data/2.5/weather";
        public string OpenWeatherMapAPIKey = "134573e0259af002b82ae681e04742c3";
        public RestService restService = new RestService();
        public string cityInput = null; 
        private readonly CLLocationManager locationManager = new CLLocationManager();
        public WeatherViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            if (cityInput == null) {
                locationManager.DesiredAccuracy = 1000;
                locationManager.Delegate = this;
                locationManager.RequestWhenInUseAuthorization();
                if (CLLocationManager.LocationServicesEnabled)
                {
                    locationManager.StartUpdatingLocation();
                }
            } else
            {
                GenerateRequestUri(OpenWeatherMapEndpoint);
            }
        }
        [Export("locationManager:didUpdateLocations:")]
        public void LocationsUpdatedAsync(CLLocationManager manager, CLLocation[] locations)
        {
            var location = locations.Last();
            if (location.HorizontalAccuracy > 0)
            {
                locationManager.StopUpdatingLocation();
                GenerateRequestUri(OpenWeatherMapEndpoint, location);
            }
        }
        // Get Weather API by lat,long
        public async Task<WeatherData> GenerateRequestUri(string url, CLLocation location)
        {
                string requestUrl = url;
                requestUrl += $"?lat={location.Coordinate.Latitude}";
                requestUrl += $"&lon={location.Coordinate.Longitude}";
                requestUrl += $"&APPID={OpenWeatherMapAPIKey}";
                var result = await restService.GetWeatherData(requestUrl);
                UpdateLabel(result, location);
                return result;
        }
        public void UpdateLabel(WeatherData result, CLLocation location)
        {
            cityLabel.Text = (result.Sys.Country).ToString();
            tempLabel.Text = (result.Main.Temperature - 273.15).ToString() + "°C";
            latitudeLabel.Text = location.Coordinate.Latitude.ToString();
            longtitudeLabel.Text = location.Coordinate.Longitude.ToString();
        }
        // Get Weather API by Location
        public async Task<WeatherData> GenerateRequestUri(string url)
        {    
                string requestUrl = url;
                requestUrl += $"?q={cityInput}";
                requestUrl += $"&APPID={OpenWeatherMapAPIKey}";
                var result = await restService.GetWeatherData(requestUrl);
                UpdateLabel(result);
                return result;
        }
        public void UpdateLabel(WeatherData result)
        {
            cityLabel.Text = (result.Sys.Country).ToString();
            tempLabel.Text = (result.Main.Temperature - 273.15).ToString() + "°C";
            latitudeLabel.Text = result.Coord.Lat.ToString();
            longtitudeLabel.Text = result.Coord.Lon.ToString();
        }
    }
}