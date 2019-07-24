using Foundation;
using System;
using UIKit;
using System.Linq;
using CoreLocation; 

namespace WeatherForeCasting
{
    public partial class WeatherViewController : UIViewController, ICLLocationManagerDelegate
    {
        private readonly CLLocationManager locationManager = new CLLocationManager();
        public WeatherViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            locationManager.DesiredAccuracy = 1000;
            locationManager.Delegate = this;
            locationManager.RequestWhenInUseAuthorization();

            if (CLLocationManager.LocationServicesEnabled)
            {
                locationManager.StartUpdatingLocation();
            }
        }
        [Export("locationManager:didUpdateLocations:")]
        public void LocationsUpdated(CLLocationManager manager, CLLocation[] locations)
        {
            var location = locations.LastOrDefault();
            latitudeLabel.Text = location.Coordinate.Latitude.ToString();
            longtitudeLabel.Text = location.Coordinate.Longitude.ToString(); 
        }
    }
}