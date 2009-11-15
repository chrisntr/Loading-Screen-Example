
using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace LoadingScreenExample
{
	public partial class SecondScreenViewController : UIViewController
	{
		#region Constructors

		// The IntPtr and NSCoder constructors are required for controllers that need 
		// to be able to be created from a xib rather than from managed code

		public SecondScreenViewController (IntPtr handle) : base(handle)
		{
			Initialize ();
		}

		[Export("initWithCoder:")]
		public SecondScreenViewController (NSCoder coder) : base(coder)
		{
			Initialize ();
		}

		public SecondScreenViewController (string fahrenheitValue) : base("SecondScreenViewController", null)
		{
			FahrenheitValue = fahrenheitValue;
			Initialize ();
		}

		void Initialize ()
		{
		}
		
		#endregion
		
		public string FahrenheitValue {
			get;
			set;
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			Title = "Converted";
			if(!String.IsNullOrEmpty(FahrenheitValue))
				fahrenheitLabel.Text = FahrenheitValue;
		}

		
	}
}
