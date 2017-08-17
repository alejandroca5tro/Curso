using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace examples_2
{
    public class ListViewGroupedTemplate : ContentPage
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

        public ListViewGroupedTemplate()
        {
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
                new Group("Important", new List<ListItem>
                {
                    new ListItem {Title = "First", Description = "1st item" },
                    new ListItem {Title = "Second", Description = "2nd item" },
                }),
                new Group("Les important", new List<ListItem>
                {
                    new ListItem {Title = "Third", Description = "3rd item" }
                })
            };

            listview.ItemsSource = itemsGrouped;

            Content = listview;
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
