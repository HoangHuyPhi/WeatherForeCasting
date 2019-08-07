using Foundation;
using System;
using UIKit;
using System.Linq;
using CoreLocation;
using System.Threading.Tasks;

namespace WeatherForeCasting
{
    public partial class WeatherViewController : UIViewController, ICLLocationManagerDelegate, IWeather
    {
        public string OpenWeatherMapEndpoint = "https://api.openweathermap.org/data/2.5/weather";
        public string OpenWeatherMapAPIKey = "134573e0259af002b82ae681e04742c3";
        public RestService restService = new RestService();
        public string userNameInput;
        private readonly CLLocationManager locationManager = new CLLocationManager();
        public WeatherViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            imageBackground.Image = UIImage.FromBundle("background.png");
            userName.Text = "Name: " + userNameInput;
            // Location setup 
            locationManager.DesiredAccuracy = 1000;
            locationManager.Delegate = this;
            locationManager.RequestWhenInUseAuthorization();
            if (CLLocationManager.LocationServicesEnabled)
            locationManager.StartUpdatingLocation();
        }    
        // Updating Location dATA
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
                UpdateLabel(result);
                return result;
        }
        // Get Weather API by Location
        public async Task<WeatherData> GenerateRequestUri(string url, string cityName)
        {    
                string requestUrl = url;
                requestUrl += $"?q={cityName}";
                requestUrl += $"&APPID={OpenWeatherMapAPIKey}";
                var result = await restService.GetWeatherData(requestUrl);
                UpdateLabel(result);
                return result;
        }

        public void UpdateLabel(WeatherData result)
        {
            cityLabel.Text = (result.Title).ToString();
            tempLabel.Text = Math.Ceiling((result.Main.Temperature - 273.15)).ToString() + "°C";
            humidityLabel.Text = "Humidity: " + result.Main.Humidity.ToString() + " %";
            tempMaxLabel.Text = "Max temp: " + Math.Ceiling(result.Main.TempMax - 273.15) + "°C";
            pressureLabel.Text = "Pressure: " + Math.Ceiling(result.Main.Pressure) + " hpa";
            windLabel.Text = "Wind speed: " + Math.Ceiling(result.Wind.Speed) + " m/s";
            countryLabel.Text = "Country: " + result.Sys.Country;
            tempMinLabel.Text = "Min temp:" + Math.Ceiling(result.Main.TempMin - 273.15).ToString() + "°C";
            descriptionLabel.Text = result.Weather[0].Description;
            result.weatherIconName = result.updateWeatherIcon(result.Weather[0].Id);
            imageLabel.Image = UIImage.FromBundle(result.weatherIconName);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            if (segue.Identifier == "Search")
            {
                var vc = segue.DestinationViewController as SearchViewController;
                vc.viewController = this;
            }
        }

        public void GetCityName(string cityName)
        {
            GenerateRequestUri(OpenWeatherMapEndpoint, cityName);
        }

        partial void UIBarButtonItem15246_Activated(UIBarButtonItem sender)
        {
            NavigationController.PopViewController(true);
        }
    }
}