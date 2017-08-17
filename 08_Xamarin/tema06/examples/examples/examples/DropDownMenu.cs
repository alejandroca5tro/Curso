using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace examples
{
    public class DropDownMenu : ContentPage
    {
        public DropDownMenu()
        {
            ToolbarItems.Clear();

            ToolbarItems.Add(new ToolbarItem
            {
                Text="Home",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(() => Navigation.PushAsync(new HomePage()))
            });

            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Second",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(() => Navigation.PushAsync(new SecondPage()))
            });
        }
    }
}
