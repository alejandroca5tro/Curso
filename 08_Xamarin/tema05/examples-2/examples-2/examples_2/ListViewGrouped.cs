using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace examples_2
{
    public class ListViewGrouped : ContentPage
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

        public ListViewGrouped()
        {
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
            ListView listview = new ListView()
            {
                IsGroupingEnabled = true,
                GroupDisplayBinding = new Binding("Key"),
                ItemTemplate = new DataTemplate(typeof(TextCell))
                {
                    Bindings =
                    {
                        {TextCell.TextProperty, new Binding("Title") },
                        {TextCell.DetailProperty, new Binding("Description") }
                    }
                }
            };

            listview.ItemsSource = itemsGrouped;

            Content = listview;
            Padding = new Thickness(0, 20, 0, 0);
        }
    }
}
