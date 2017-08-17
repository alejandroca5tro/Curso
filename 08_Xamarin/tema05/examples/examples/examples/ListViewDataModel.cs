using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace examples
{
    public class ListViewDataModel : ContentPage
    {
        public ListViewDataModel()
        {
            var listview = new ListView();
            listview.ItemsSource = new ListItem[]
            {
                new ListItem {Title="Primero", Description="Primer Elemento" },
                new ListItem {Title="Segundo", Description="Segundo Elemento" },
                new ListItem {Title="Tercero", Description="Tercer Elemento" },
            };

            listview.ItemTemplate = new DataTemplate(typeof(TextCell));
            listview.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
            listview.ItemTemplate.SetBinding(TextCell.DetailProperty, "Description");


            listview.ItemTapped += async (sender, e) =>
            {
                ListItem item = (ListItem)e.Item;
                await DisplayAlert("TAPPED", "El usuario ha seleccionado el elemento " + e.Item.ToString(), "OK");
                ((ListView)sender).SelectedItem = null;
            };

            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            Content = listview;
        }
    }
}
