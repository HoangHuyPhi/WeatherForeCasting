using Foundation;
using System;
using UIKit;

namespace WeatherForeCasting
{
    public partial class SearchViewController : UIViewController
    {
        public string userNameInput;
        public SearchViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            userName.Text = "Hi " + userNameInput;
        }
        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            if (segue.Identifier == "cityName")
            {
                var viewController = segue.DestinationViewController as WeatherViewController;
                viewController.cityInput = locationName.Text; 
            }
        }
    }
}