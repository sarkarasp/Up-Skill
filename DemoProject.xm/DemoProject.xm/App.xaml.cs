using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DemoProject.xm.Services;
using DemoProject.xm.Views;

namespace DemoProject.xm
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
