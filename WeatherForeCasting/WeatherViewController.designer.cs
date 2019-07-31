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
        UIKit.UILabel latitudeLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel longtitudeLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel tempLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (cityLabel != null) {
                cityLabel.Dispose ();
                cityLabel = null;
            }

            if (latitudeLabel != null) {
                latitudeLabel.Dispose ();
                latitudeLabel = null;
            }

            if (longtitudeLabel != null) {
                longtitudeLabel.Dispose ();
                longtitudeLabel = null;
            }

            if (tempLabel != null) {
                tempLabel.Dispose ();
                tempLabel = null;
            }
        }
    }
}