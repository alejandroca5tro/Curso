using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace examples
{
    public class ListViewGrouped : ContentPage
    {
        public class Group : List<ListItemGroup>
        { 
            public String Key { get; set; }
            public Group(String key, List<ListItemGroup> items)
            {
                Key = key;
                foreach (var item in items)
                    this.Add(item);
            }
        }

        public ListViewGrouped()
        {
            List<Group> itemGrouped = new List<Group>
            {
                new Group("Important", new List<ListItemGroup>
                {
                    new ListItemGroup {Title="First", Description="1st item" },
                    new ListItemGroup {Title="Second", Description="2nd item" },
                }),

                new Group("Less important", new List<ListItemGroup>
                {
                    new ListItemGroup {Title="Third", Description="3rd item" },
                    new ListItemGroup {Title="Fourth", Description="4th item" },
                }),
            };
        }
    }
}

        
