using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejemplo5._1
{
    public class ListViewImageCell:ContentPage
    {
        public class ListItem
        {
            public string Source { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
        }

        public ListViewImageCell()
        {
            var listView = new ListView();
            listView.ItemsSource = new ListItem[]
            {
                new ListItem {Source="icon.png", Title="First",Description="1st item"},
                new ListItem {Source="icon.png",Title="Second",Description="2nd item"},
                new ListItem {Source="icon.png",Title="Third",Description="3rd item"}
            };

            listView.ItemTemplate = new DataTemplate(typeof(ImageCell));
            listView.ItemTemplate.SetBinding(ImageCell.ImageSourceProperty, "Source");
            listView.ItemTemplate.SetBinding(ImageCell.TextProperty, "Title");
            listView.ItemTemplate.SetBinding(ImageCell.DetailProperty, "Description");

            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 0, 0);

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
