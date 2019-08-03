// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace WeatherForeCasting
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imageBackground { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton nextButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel titleName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField userName { get; set; }

        [Action ("NextButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void NextButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (imageBackground != null) {
                imageBackground.Dispose ();
                imageBackground = null;
            }

            if (nextButton != null) {
                nextButton.Dispose ();
                nextButton = null;
            }

            if (titleName != null) {
                titleName.Dispose ();
                titleName = null;
            }

            if (userName != null) {
                userName.Dispose ();
                userName = null;
            }
        }
    }
}