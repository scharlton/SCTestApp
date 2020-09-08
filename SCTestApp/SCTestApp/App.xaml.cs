using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SCTestApp.Services;
using SCTestApp.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace SCTestApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=92762260-34ff-4643-8126-ef36006ea1d8;" +
                  "uwp={5ab647aaa28c254291bb51e5134c3e39577d48c7};" +
                  "ios={c1b5f5338cce61a4921f94e94c9531e6c4d23f1f}",
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
