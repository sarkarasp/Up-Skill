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
    public partial class AngularContentPage : ContentPage
    {
        public AngularContentPage()
        {
            InitializeComponent();
            var page = new ItemsPage();

            page.BindingContext = page.Content;
           // MainPage = page.Content;
        }
        
    }
}