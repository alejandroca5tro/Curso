using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejemplo5._1
{
    public class ListViewCustom : ContentPage
    {
        public class ListItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
        }
        public ListViewCustom()
        {
            var listView = new ListView();
            listView.ItemsSource = new ListItem[]
            {
                new ListItem {Title="First",Description="1st item",Price="$100.00"},
                new ListItem {Title="Second",Description="2nd item",Price="$200.00"},
                new ListItem {Title="Third",Description="3rd item",Price="$300.00"}
            };
            listView.RowHeight = 80;
            listView.BackgroundColor = Color.Black;
            listView.ItemTemplate = new DataTemplate(typeof(ListItemCell));

            Content = listView;
            listView.ItemTapped += async (sender, e) =>
            {
                ListItem item = (ListItem)e.Item;
                await DisplayAlert("Tapped", item.Title.ToString() + "was selected.", "OK");
                ((ListView)sender).SelectedItem = null;
            };
        }
    }
}
