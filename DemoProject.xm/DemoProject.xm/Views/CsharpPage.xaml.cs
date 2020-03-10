using DemoProject.xm.Models;
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
    public partial class CsharpPage : ContentPage
    {
        public CsharpPage()
        {
            InitializeComponent();
            BindingContext = new TutorialListPageViewModel();
           
        }

        private async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as TutorialListModel;
            await Navigation.PushAsync(new CsharpDetailPage(mydetails.Name, mydetails.Ingredients, mydetails.Image));

        }
    }
}