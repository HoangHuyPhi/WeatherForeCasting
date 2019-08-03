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
    [Register ("WeatherViewController")]
    partial class WeatherViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel cityLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel countryLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel descriptionLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel humidityLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imageBackground { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imageLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel pressureLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel tempLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel tempMaxLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel tempMinLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel userName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel windLabel { get; set; }

        [Action ("UIBarButtonItem15246_Activated:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIBarButtonItem15246_Activated (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (cityLabel != null) {
                cityLabel.Dispose ();
                cityLabel = null;
            }

            if (countryLabel != null) {
                countryLabel.Dispose ();
                countryLabel = null;
            }

            if (descriptionLabel != null) {
                descriptionLabel.Dispose ();
                descriptionLabel = null;
            }

            if (humidityLabel != null) {
                humidityLabel.Dispose ();
                humidityLabel = null;
            }

            if (imageBackground != null) {
                imageBackground.Dispose ();
                imageBackground = null;
            }

            if (imageLabel != null) {
                imageLabel.Dispose ();
                imageLabel = null;
            }

            if (pressureLabel != null) {
                pressureLabel.Dispose ();
                pressureLabel = null;
            }

            if (tempLabel != null) {
                tempLabel.Dispose ();
                tempLabel = null;
            }

            if (tempMaxLabel != null) {
                tempMaxLabel.Dispose ();
                tempMaxLabel = null;
            }

            if (tempMinLabel != null) {
                tempMinLabel.Dispose ();
                tempMinLabel = null;
            }

            if (userName != null) {
                userName.Dispose ();
                userName = null;
            }

            if (windLabel != null) {
                windLabel.Dispose ();
                windLabel = null;
            }
        }
    }
}