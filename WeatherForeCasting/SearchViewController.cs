using Foundation;
using System;
using UIKit;


namespace WeatherForeCasting
{
    interface IWeather
    {
        void GetCityName(string cityName);
    }

    public partial class SearchViewController : UIViewController
    {
        // Make an instance of viewController to pass data by using interface. 
        public WeatherViewController viewController;
        public SearchViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Update UI
            imageBackground.Image = UIImage.FromBundle("background.png");
            getButton.Layer.CornerRadius = 10;
            getButton.Layer.BorderWidth = 1;
            getButton.Layer.BorderColor = UIColor.White.CGColor;
        }
        partial void UIButton6465_TouchUpInside(UIButton sender)
        {
            if (viewController != null) 
            viewController.GetCityName(locationName.Text); 
            NavigationController.PopViewController(false);
        }
    }
}