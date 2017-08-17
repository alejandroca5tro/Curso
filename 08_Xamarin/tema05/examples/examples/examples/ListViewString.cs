using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace examples
{
    public class ListViewString : ContentPage
    {
        public ListViewString()
        {
            ListView listview = new ListView();
            List<string> lista = new List<string>() { "Primero", "Segundo", "Tercero" };
            listview.ItemsSource = lista;

            listview.ItemTapped += async (sender, e) =>
            {
                await DisplayAlert("TAPPED", "El usuario ha seleccionado el elemento " + e.Item.ToString(), "OK");
                ((ListView)sender).SelectedItem = null;
            };

            listview.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null) return;
                await DisplayAlert("SELECTED", "Elemento: " + e.SelectedItem.ToString() + " seleccionado", "OK");
                ((ListView)sender).SelectedItem = null;
            };

            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            Content = listview;
        }
    }
}   