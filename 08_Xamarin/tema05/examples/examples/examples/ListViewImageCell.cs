using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace examples
{
    public class ListViewImageCell : ContentPage
    {
        public ListViewImageCell()
        {
            var listview = new ListView();
            listview.ItemsSource = new ListItemImage[]
            {
                new ListItemImage {Source="icon.png", Title="Primero", Description="Primera imagen" },
                new ListItemImage {Source="icon.png", Title="Segundo", Description="Segunda imagen" },
                new ListItemImage {Source="icon.png", Title="Tercero", Description="Tercera imagen" }
            };

            listview.ItemTemplate = new DataTemplate(typeof(ImageCell));
            listview.ItemTemplate.SetBinding(ImageCell.ImageSourceProperty, "Source");
            listview.ItemTemplate.SetBinding(ImageCell.TextProperty, "Title");
            listview.ItemTemplate.SetBinding(ImageCell.DetailProperty, "Description");

            listview.ItemTapped += async (sender, e) =>
            {
                ListItemImage item = (ListItemImage)e.Item;
                await DisplayAlert("TAPPED", "El usuario ha seleccionado el elemento " + e.Item.ToString(), "OK");
                ((ListView)sender).SelectedItem = null;
            };

            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            Content = listview;
        }
    }
}
