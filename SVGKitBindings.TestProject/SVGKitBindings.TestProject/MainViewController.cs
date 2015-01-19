using Foundation;
using System;
using System.CodeDom.Compiler;
using System.Drawing;
using UIKit;
using CoreGraphics;
using SVGKitBindings.TestProject.Classes;
using SVGKitBindings;

namespace SVGKitBindings.TestProject
{
	partial class MainViewController : UIViewController
	{
		public MainViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			//Set these properties to AutoLayout can be overrided.
			View1.TranslatesAutoresizingMaskIntoConstraints = true;
			View2.TranslatesAutoresizingMaskIntoConstraints = true;
			View3.TranslatesAutoresizingMaskIntoConstraints = true;
			View4.TranslatesAutoresizingMaskIntoConstraints = true;

			//Arrange views so they are of equal heights and fill screen.
			View1.Frame = new RectangleF(0, 0, (float)View.Frame.Width, (float)View.Frame.Height/4);
			View2.Frame = new RectangleF(0, (float)View1.Frame.Height, (float)View1.Frame.Width, (float)View1.Frame.Height);
			View3.Frame = new RectangleF(0, (float)(View1.Frame.Height * 2), (float)View1.Frame.Width, (float)View1.Frame.Height);
			View4.Frame = new RectangleF(0, (float)(View1.Frame.Height * 3), (float)View1.Frame.Width, (float)View1.Frame.Height);

			//Set colours of controls.
			View1.BackgroundColor = UIColour.Green;
			View2.BackgroundColor = UIColour.LightBlue;
			View3.BackgroundColor = UIColour.DarkBlue;
			View4.BackgroundColor = UIColour.Cream;

			var image = new SVGKImage(NSBundle.MainBundle.BundlePath + "/SVG/LogoWhite.svg");
			var imageView = new SVGKFastImageView(image);
			View.Add(imageView);
		}
	}
}
