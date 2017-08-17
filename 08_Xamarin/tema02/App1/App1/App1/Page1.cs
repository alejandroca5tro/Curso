using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public class Page1 : ContentPage
    {

        public Page1()
        {

            Label name = new Label()
            {
                Text = "John",
                FontFamily = "Courier",
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                FontSize = 20,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Label lastName = new Label()
            {
                Text = "Doe",
                FontFamily = "Courier",
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                FontSize = 20,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Button btnConcatenate = new Button
            {
                Text = "Concatenar",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill,
            };

            btnConcatenate.Clicked += (sender, args) =>
                 {
                     btnConcatenate.Scale = 2;
                     btnConcatenate.BackgroundColor = Color.Red;
                     btnConcatenate.FontAttributes = FontAttributes.Bold | FontAttributes.Italic;
                     btnConcatenate.Text = name.Text + " " + lastName.Text;
                     name.Text = "";
                     lastName.Text = "";
                     BackgroundColor = Color.Green;
                 };

            StackLayout stackLayout = new StackLayout
            {
                Children =
                {
                    name, lastName, btnConcatenate
                }
            };
            Content = stackLayout;
        }
    }
}