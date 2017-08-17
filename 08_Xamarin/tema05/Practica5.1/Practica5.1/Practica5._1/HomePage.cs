using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica5._1
{
    public class HomePage : ContentPage
    {
        public class ListItem
        {
            public string Nombre { get; set; }
            public string Cargo { get; set; }
        }
        public HomePage()
        {
            Label label = new Label
            {
                Text = "Lista de Personal",
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Orange,
                TextColor = Color.White
            };
            ListView listView = new ListView()
            {
                IsGroupingEnabled = true,
                GroupDisplayBinding = new Binding("Key"),
                GroupHeaderTemplate = new DataTemplate(typeof(HeaderCell)),
                HasUnevenRows = true,
                ItemTemplate = new DataTemplate(typeof(TextCell))
                {
                    Bindings ={
                    {TextCell.TextProperty,new Binding("Nombre") },
                    {TextCell.DetailProperty, new Binding("Cargo") }}
                }
            };
            listView.ItemTapped += async (sender, e) =>
            {
                ListItem item = (ListItem)e.Item;
                await DisplayAlert("Tapped", item.Nombre.ToString() + 
                    " con cargo : " + item.Cargo.ToString() + " fué seleccionado.", "OK");
                ((ListView)sender).SelectedItem = null;
            };
            List<Group> itemsGrouped = new List<Group>
            {
                new Group("Contabilidad", new List<ListItem>
                {
                    new ListItem {Nombre="Juan Ramírez",Cargo="Jefe Contabilidad" },
                    new ListItem {Nombre="Inés Jiménez",Cargo="Jefe Unidad Ventas" }
                }),
                new Group("Ventas", new List<ListItem>
                {
                    new ListItem {Nombre="Jesús Morán",Cargo="Jefe Ventas" },
                    new ListItem {Nombre="Evaristo González",Cargo="Administrativo Ventas" }
                })
            };
            listView.ItemsSource = itemsGrouped;
            StackLayout layout = new StackLayout
            {
                Children =
                {
                    label,
                    listView
                }
            };
            Content = layout;
            this.Padding = new Thickness(0, 20, 0, 0);
        }
        public class Group : List<ListItem>
        {
            public String Key { get; private set; }
            public Group(String key, List<ListItem> items)
            {
                Key = key;
                foreach (var item in items)
                    this.Add(item);
            }
        }
        public class HeaderCell : ViewCell
        {
            public HeaderCell()
            {
                this.Height = 40;
                var persona = new Label
                {
                    FontSize = 16,
                    TextColor = Color.Black,
                    VerticalOptions = LayoutOptions.Center
                };
                persona.SetBinding(Label.TextProperty, "Key");

                View = new StackLayout
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    HeightRequest = 40,
                    BackgroundColor = Color.White,
                    Padding = 5,
                    Orientation = StackOrientation.Horizontal,
                    Children = { persona }
                };
            }
        }
    }
}
