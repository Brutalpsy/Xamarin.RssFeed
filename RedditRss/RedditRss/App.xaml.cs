using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using RedditRss.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RedditRss
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts

            AppCenter.Start("b084fa24-aedb-4a78-9b10-be5ed1b49146",
                       typeof(Analytics), typeof(Crashes));
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
