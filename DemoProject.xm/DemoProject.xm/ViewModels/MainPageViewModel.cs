using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using MasterMenuSample.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using DemoProject.xm.Views;

namespace DemoProject.xm.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            PopulateMenu();
        }

        private void PopulateMenu()
        {
            MenuItems = new ObservableCollection<MasterMenu>();
            MenuItems.Add(new MasterMenu { MenuName = "Home", MenuIcon = "home", TargetType = typeof(ItemsPage) });
            MenuItems.Add(new MasterMenu { MenuName = "C#.net", MenuIcon= "csharp", TargetType = typeof(CsharpPage) });
            MenuItems.Add(new MasterMenu { MenuName = "ASP.NET MVC", MenuIcon = "csharp", TargetType = typeof(mvcContentPage) });
            MenuItems.Add(new MasterMenu { MenuName = "Azure", MenuIcon = "Azure", TargetType = typeof(AzureContentPage) });
            MenuItems.Add(new MasterMenu { MenuName = "Angular", MenuIcon = "Angular", TargetType = typeof(AngularContentPage) });
            MenuItems.Add(new MasterMenu { MenuName = "Blogs", MenuIcon = "Blogs", TargetType = typeof(BlogContentPage) });
          
        }

        ObservableCollection<MasterMenu> _menuItems;
        public ObservableCollection<MasterMenu> MenuItems
        {
            get
            {
                return _menuItems;
            }
            set
            {
                if (value != null)
                {
                    _menuItems = value;
                    OnPropertyChanged();
                }
            }
        }

        MasterMenu _selectedMenu;
        public MasterMenu SelectedMenu
        {
            get
            {
                return _selectedMenu;
            }
            set
            {
                if (_selectedMenu != null)
                {
                    _selectedMenu.Selected = false;
                    _selectedMenu.MenuIcon = _selectedMenu.MenuIcon.Substring(0, _selectedMenu.MenuIcon.Length - 6);
                }
                    

                _selectedMenu = value;

                if (_selectedMenu != null)
                {
                    _selectedMenu.Selected = true;
                    _selectedMenu.MenuIcon += "_colored";
                    MessagingCenter.Send<MasterMenu>(_selectedMenu, "OpenMenu");
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}