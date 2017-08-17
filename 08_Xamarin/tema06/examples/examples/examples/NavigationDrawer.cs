using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace examples
{
    public class NavigationDrawer : MasterDetailPage
    {
        public NavigationDrawer()
        {
            Title = "Navigation Drawer Using MasterDetailsPage";
            string[] myPagesName = { "Home", "Second", "Third" };
            ListView listview = new ListView
            {
                ItemsSource = myPagesName
            };

            Master = new ContentPage
            {
                Title = "Options",
                Content = listview,
                Icon = "hamburger.png"
            };

            listview.ItemTapped += (sender, e) =>
            {
                ContentPage gotoPage;
                switch (e.Item.ToString())
                {
                    case "Home":
                        gotoPage = new HomePage();
                        break;
                    case "Second":
                        gotoPage = new SecondPage();
                        break;
                    case "Third":
                        gotoPage = new ThirdPage();
                        break;
                    default:
                        gotoPage = new FirstPage();
                        break;
                }
                Detail = new NavigationPage(gotoPage);
                ((ListView)sender).SelectedItem = null;
                IsPresented = false;
            };
            Detail = new NavigationPage(new HomePage());
        }
    }
}