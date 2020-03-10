using DemoProject.xm.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoProject.xm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CsharpDetailPage : ContentPage
    {
        List<BlogViewModel> BlogList = new List<BlogViewModel>();
        public CsharpDetailPage(string Name, string Ingredients, string source)
        {
           
            InitializeComponent();
            GetAllBlogList();
            // MyItemNameShow.Text = Name;
            foreach (var item in BlogList)
            {
                MyIngrediantItemShow.Text = item.contents;
            }
           
           // MyImageCall.Source = source;
            //MyImageCall.Source = new UriImageSource()
            //{
            //    Uri = new Uri(source)
            //};
        }

        public async void GetAllBlogList()
        {

            using (var client = new HttpClient())
            {
                var uri = "http://IN-IT2313/values/GetBlogHttp";
                var result = await client.GetStringAsync(uri);

                 BlogList = JsonConvert.DeserializeObject<List<BlogViewModel>>(result);
            }
        }
    }
}