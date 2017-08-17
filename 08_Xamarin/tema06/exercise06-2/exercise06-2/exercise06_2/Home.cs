using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace exercise06_2
{
    public class Home : ContentPage
    {
        public Home()
        {
            Title = "Compras OnLine";
            
            Image logoCarrefour = new Image
            {
                Source = "carrefour.jpg",
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill
            };

            ToolbarItems.Clear();
            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Productos",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(() =>
                  Navigation.PushAsync(new Products()))
            });
            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Formulario de Compra",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(() =>
                  Navigation.PushAsync(new secondPage()))
            });

            StackLayout mainSL = new StackLayout
            {
                Children =
                {
                    logoCarrefour,
                }
            };

            Content = mainSL;
        }
    }
}