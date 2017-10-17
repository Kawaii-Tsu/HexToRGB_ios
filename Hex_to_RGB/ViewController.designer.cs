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
        UIKit.UILabel BlueCol { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView colorView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton demoButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel GreenCol { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Hex { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel RedCol { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BlueCol != null) {
                BlueCol.Dispose ();
                BlueCol = null;
            }

            if (colorView != null) {
                colorView.Dispose ();
                colorView = null;
            }

            if (demoButton != null) {
                demoButton.Dispose ();
                demoButton = null;
            }

            if (GreenCol != null) {
                GreenCol.Dispose ();
                GreenCol = null;
            }

            if (Hex != null) {
                Hex.Dispose ();
                Hex = null;
            }

            if (RedCol != null) {
                RedCol.Dispose ();
                RedCol = null;
            }
        }
    }
}