using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Tabs
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // sadad
            MainPage = new NavigationPage(new BlindsPage());
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=d089b55e-d828-4290-8064-047c3a75e991;" + "uwp={Your UWP App secret here};" + "ios={Your iOS App secret here}", typeof(Analytics), typeof(Crashes));

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
