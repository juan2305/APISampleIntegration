using APISampleIntegration.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APISampleIntegration
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FlightPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
