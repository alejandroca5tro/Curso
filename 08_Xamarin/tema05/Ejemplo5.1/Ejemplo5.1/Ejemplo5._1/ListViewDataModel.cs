using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejemplo5._1
{
    public class ListViewDataModel : ContentPage
    {
        public ListViewDataModel()
        {
            var listView = new ListView();
            listView.ItemsSource = new ListItem[]
            {
                new ListItem {Title="First",Description="1st item"},
                new ListItem {Title="Second",Description="2nd item"},
                new ListItem {Title="Third",Description="3rd item"},
            };
            listView.ItemTemplate = new DataTemplate(typeof(TextCell));
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
            listView.ItemTemplate.SetBinding(TextCell.DetailProperty, "Description");

            listView.ItemTapped += async (sender, e) =>
            {
                ListItem item = (ListItem)e.Item;
                await DisplayAlert("Tapped", item.Title.ToString() + "was selected.", "OK");
                ((ListView)sender).SelectedItem = null;
            };

            this.Padding = new Thickness(10, 20, 10, 5);

            Content = listView;
        }
    }
}
