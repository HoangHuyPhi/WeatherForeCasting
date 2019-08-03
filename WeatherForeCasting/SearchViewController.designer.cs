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
    [Register ("SearchViewController")]
    partial class SearchViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton getButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imageBackground { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField locationName { get; set; }

        [Action ("UIButton6465_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton6465_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (getButton != null) {
                getButton.Dispose ();
                getButton = null;
            }

            if (imageBackground != null) {
                imageBackground.Dispose ();
                imageBackground = null;
            }

            if (locationName != null) {
                locationName.Dispose ();
                locationName = null;
            }
        }
    }
}