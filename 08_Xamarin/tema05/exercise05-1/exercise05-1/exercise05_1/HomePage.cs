using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace exercise05_1
{
    class HomePage : ContentPage
    {
        public class ListItem 
        {
            public string Title { get; set; }
            public string Description { get; set; }
        }

        public class Group : List<ListItem>
        {
            public string Key { get; private set; }
            public Group(string key, List<ListItem> items)
            {
                Key = key;
                foreach (var item in items)
                    Add(item);
            }
        }

        public HomePage()
        {
            Label lblTop = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Orange,
                TextColor = Color.White,
                Text = "Lista de personal",
            };

            ListView listview = new ListView()
            {
                IsGroupingEnabled = true,
                GroupDisplayBinding = new Binding("Key"),
                GroupHeaderTemplate = new DataTemplate(typeof(HeaderCell)),
                HasUnevenRows = true,
                ItemTemplate = new DataTemplate(typeof(TextCell))
                {
                    Bindings =
                    {
                        {TextCell.TextProperty, new Binding("Title") },
                        {TextCell.DetailProperty, new Binding("Description") }
                    }
                }
            };

            List<Group> itemsGrouped = new List<Group>
            {
                new Group("Contabilidad", new List<ListItem>
                {
                    new ListItem {Title = "Juan Ramírez", Description = "Jefe Contabilidad" },
                    new ListItem {Title = "Inés Jiménez", Description = "Jefe Unidad Ventas" },
                }),
                new Group("Ventas", new List<ListItem>
                {
                    new ListItem {Title = "Jesús Morán", Description = "Jefe Ventas" },
                    new ListItem {Title = "Evaristo González", Description = "Administrativo Ventas" }
                })
            };

            listview.ItemsSource = itemsGrouped;

            listview.ItemTapped += async (sender, e) =>
            {
                ListItem item = (ListItem)e.Item;
                await DisplayAlert("TAPPED", item.Title.ToString() + " con cargo: " + item.Description.ToString() + " fué seleccionado.", "OK");
                ((ListView)sender).SelectedItem = null;
            };


            StackLayout sLMain = new StackLayout
            {
                Children =
                {
                    lblTop,
                    listview
                }
            };

            Content = sLMain;
            Padding = new Thickness(0, 20, 0, 0);
        }

        public class HeaderCell : ViewCell
        {
            public HeaderCell()
            {
                Height = 40;
                Label title = new Label
                {
                    FontSize = 16,
                    TextColor = Color.Black,
                    VerticalOptions = LayoutOptions.Center
                };

                title.SetBinding(Label.TextProperty, "Key");
                View = new StackLayout
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    HeightRequest = 40,
                    BackgroundColor = Color.White,
                    Padding = 5,
                    Orientation = StackOrientation.Horizontal,
                    Children =
                    {
                        title
                    }
                };
            }
        }
    }
}
