using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App3
{
    public class Page2 : ContentPage
    {
        public Page2()
        {
            Label labelGrande = new Label()
            {
                Text = "Esta es una label grande",
                FontSize = 40,
                BackgroundColor = Color.Black,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Center
            };

            Label labelPequeña = new Label()
            {
                Text = "Este control va a trabajar\n" + "en varias líneas de\n" + "texto",
                FontFamily = "Courier",
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                FontSize = 20,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Button button = new Button
            {
                Text = "Presióname",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill,
            };

            button.Clicked += (sender, args) =>
             {
                 button.Text = "Ya me has presionado";
             };

            StackLayout stackLayout = new StackLayout
            {
                Children =
                {
                    labelGrande, labelPequeña, button
                }
            };
            Content = stackLayout;
        }
    }
}