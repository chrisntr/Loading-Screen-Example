
using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using LoadingScreenExample.www.w3schools.com;

namespace LoadingScreenExample
{
	public partial class MainScreenViewController : UIViewController
	{
		#region Constructors

		// The IntPtr and NSCoder constructors are required for controllers that need 
		// to be able to be created from a xib rather than from managed code

		public MainScreenViewController (IntPtr handle) : base(handle)
		{
			Initialize ();
		}

		[Export("initWithCoder:")]
		public MainScreenViewController (NSCoder coder) : base(coder)
		{
			Initialize ();
		}

		public MainScreenViewController () : base("MainScreenViewController", null)
		{
			Initialize ();
		}

		void Initialize ()
		{
		}
		
		#endregion
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			Title = "Convert";
			
			// Remove keyboard from textbox when convert button is pressed
			convertButton.TouchUpInside += delegate {
				convertTextbox.ResignFirstResponder();
			};
			
			convertTextbox.KeyboardType = UIKeyboardType.NumbersAndPunctuation;
			
			// Handle the "Return" section on Textbox keyboard
			convertTextbox.ShouldReturn = (tf) => {   
		        tf.ResignFirstResponder ();   
				return true;   
			};
		}
				
		partial void convertingCelcius (UIButton sender)
		{
			// Async Convert temperature from Celcius to Fahrenheit
			TempConvert tempConvert = new TempConvert();
			tempConvert.CelsiusToFahrenheitCompleted += HandleTempConvertCelsiusToFahrenheitCompleted;

			if(!String.IsNullOrEmpty(convertTextbox.Text)){
				tempConvert.CelsiusToFahrenheitAsync(convertTextbox.Text);
				DisplayLoadingScreen(true);
			}
			else 
			{
				using (var alert = new UIAlertView("Whoops", "Please enter a value to convert", null, "Ok", null))
				{
					alert.Show();
				}	
			}
			
		}

		void HandleTempConvertCelsiusToFahrenheitCompleted (object sender, CelsiusToFahrenheitCompletedEventArgs args)
		{
			// We got the async result now display new view.
			InvokeOnMainThread( delegate {
				DisplayLoadingScreen(false);
				if(!String.IsNullOrEmpty(args.Result)){
					var secondScreen = new SecondScreenViewController(args.Result);
					this.NavigationController.PushViewController(secondScreen, true);
				}
			});
		}

		void DisplayLoadingScreen(bool start)
		{
			DisplayLoadingScreen(start, "Loading...");
		}
		
		void DisplayLoadingScreen(bool start, string message)
		{
			if(start)
			{
				// Start to display loading screen
				loadingView.Hidden = false;
				loadingMessage.Hidden = false;
				loadingMessage.Text = message;
				loadingIndicator.StartAnimating();
				UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;	
			}
			else
			{
				// Stop showing the loading screen
				loadingView.Hidden = true;
				loadingMessage.Hidden = true;
				loadingIndicator.StopAnimating();
				UIApplication.SharedApplication.NetworkActivityIndicatorVisible = false;
			}
		}
		
	}
}
