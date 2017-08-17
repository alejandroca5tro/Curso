using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace examples
{
    public class ListViewCustom : ContentPage
    {
        public ListViewCustom()
        {
            var listview = new ListView();
            listview.ItemsSource = new ListItemCustom[]
            {
                new ListItemCustom {Title="Primero", Description="Primer custom", Price="$100.00"  },
                new ListItemCustom {Title="Segundo", Description="Segundo custom", Price="$200.00"  },
                new ListItemCustom {Title="Tercero", Description="Tercer custom", Price="$300.00"  },
            };
            listview.RowHeight = 80;
            listview.BackgroundColor = Color.Black;

            listview.ItemTemplate = new DataTemplate(typeof(ListItemCell));
                        
            Content = listview;

            listview.ItemTapped += async (sender, e) =>
            {
                ListItemCustom item = (ListItemCustom)e.Item;
                await DisplayAlert("TAPPED", "Elemento: " + item.Price.ToString() + "seleccionado", "OK");
                ((ListView)sender).SelectedItem = null;
            };
        }
    }
}
