using ElectionTimeInfoApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace ElectionTimeInfoApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            var navpage = new NavigationPage();
            var page = new CandidateListViewPage();
            navpage.PushAsync(page);
            MainPage = navpage;
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
