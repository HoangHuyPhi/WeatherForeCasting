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
            userName.Text = userNameInput;
        }
    }
}