using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejemplo5._1
{
    public class ListViewStrings:ContentPage
    {
        public ListViewStrings()
        {
            ListView listView = new ListView();
            List<String> items = new List<string>() { "First", "Second", "Thrird" };
            listView.ItemsSource = items;

            //Evento Forma 1
            //listView.ItemTapped += async (sender, e) =>
            //{
            //    await DisplayAlert("Tapped", e.Item.ToString() + " was selected.", "OK");
            //    ((ListView)sender).SelectedItem = null;
            //};

            //Evento Forma 2
            listView.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null) return;
                await DisplayAlert("Selected", e.SelectedItem.ToString() + "was selected.", "OK");
                ((ListView)sender).SelectedItem = null;
            };


            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            this.Content = listView;
            

        }
    }
}
