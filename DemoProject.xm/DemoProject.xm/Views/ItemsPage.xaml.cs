using DemoProject.xm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoProject.xm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            InitializeComponent();
        }

        public void ClickTap1(object sender, EventArgs e)
        {
            var page = new ItemsPage();
           page.BindingContext  = new MainPageViewModel();
            Navigation.PushModalAsync(new MainPage());
            //MainView.ControlTemplate = page.Detail.BindingContext;
            // MainView.Content = page.;

        }
        public void ClickTap2(object sender, EventArgs e)
        {
            var page = new InterviewQA();
            MainView.Content = page.Content;

        }

        public void ClickTap3(object sender, EventArgs e)
        {
            var page = new BlogContentPage();
            MainView.Content = page.Content;
            page.BindingContext = new CardDataViewModel();

        }

        public void ClickTap4(object sender, EventArgs e)
        {
            var page = new UserProfile();
            MainView.Content = page.Content;
            
        }

        private void btnAzureExplore_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AzureContentPage());
        }

        private void btnCSharpExplore_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CsharpPage());
        }

       
    }
}