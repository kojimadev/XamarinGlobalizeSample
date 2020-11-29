using System;
using System.Globalization;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinGlobalizeSample.Resources;

namespace XamarinGlobalizeSample
{
	public partial class App : Application
	{
		public static void SetCulture(CultureInfo culture)
		{
			AppResources.Culture = culture;
		}

		public App()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
