using System;

using UIKit;

namespace Hex_to_RGB
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

           // Convert.TouchUpInside += Convert_TouchUpInside;
           // ConvertButton.TouchUpInside+= ConvertButton_TouchUpInside;
            demoButton.TouchUpInside+= DemoButton_TouchUpInside;
        }

        void DemoButton_TouchUpInside(object sender, EventArgs e)
        {
			string hexValue = Hex.Text;
			string rValue = hexValue.Substring(0, 2);
			string gValue = hexValue.Substring(2, 2);
			string bValue = hexValue.Substring(4, 2);

			int Red = int.Parse(rValue, System.Globalization.NumberStyles.HexNumber);
			int Green = int.Parse(gValue, System.Globalization.NumberStyles.HexNumber);
			int Blue = int.Parse(bValue, System.Globalization.NumberStyles.HexNumber);
        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
