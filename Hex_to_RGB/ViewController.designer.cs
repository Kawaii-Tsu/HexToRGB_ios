// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Hex_to_RGB
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Blue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton demoButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Green { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Hex { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Red { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Blue != null) {
                Blue.Dispose ();
                Blue = null;
            }

            if (demoButton != null) {
                demoButton.Dispose ();
                demoButton = null;
            }

            if (Green != null) {
                Green.Dispose ();
                Green = null;
            }

            if (Hex != null) {
                Hex.Dispose ();
                Hex = null;
            }

            if (Red != null) {
                Red.Dispose ();
                Red = null;
            }
        }
    }
}