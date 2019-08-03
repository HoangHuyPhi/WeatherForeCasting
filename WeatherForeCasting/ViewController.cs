using Foundation;
using System;
using UIKit;

namespace WeatherForeCasting
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            imageBackground.Image = UIImage.FromBundle("background.png");
            nextButton.SetTitleColor(UIColor.Clear, UIControlState.Disabled);
            nextButton.SetTitleColor(UIColor.White, UIControlState.Normal);
            UpdateButton();
            nextButton.Layer.CornerRadius = 10;
            nextButton.Layer.BorderWidth = 1;
            NavigationController.NavigationBar.BarStyle = UIBarStyle.Default;
            userName.EditingChanged += (object sender, EventArgs e) =>
            {
                UpdateButton();
            };
        }
        public void UpdateButton()
        {
            if (userName.HasText)
            {
                nextButton.Enabled = true;
                nextButton.Layer.BorderColor = UIColor.White.CGColor;
            } else
            {
                nextButton.Enabled = false;
                nextButton.Layer.BorderColor = UIColor.Clear.CGColor;
            }
        }
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            if (segue.Identifier == "Search")
            {
                var viewcontroller = segue.DestinationViewController as WeatherViewController;
                viewcontroller.userNameInput = userName.Text; 
            }
        }
    }
}
