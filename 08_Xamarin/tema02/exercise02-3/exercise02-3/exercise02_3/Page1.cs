using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace exercise02_3
{
    public class Page1 : ContentPage
    {
        public Page1()
        {          

            Image image = new Image
            {
                Source = "forest.jpg",
                //Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.Fill,
                //VerticalOptions = LayoutOptions.Fill
            };
            Button btnInc = new Button
            {
                Text = "Aumentar",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill,
                IsVisible = false
            };

            Button btnDec = new Button
            {
                Text = "Disminuir",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill,
                IsVisible = false
            };

            image.Opacity = .5;

            var tapGestureRecognizer = new TapGestureRecognizer();

            tapGestureRecognizer.Tapped += (s, e) =>
            {
                btnInc.IsVisible = true;
                btnDec.IsVisible = true;
            };

            image.GestureRecognizers.Add(tapGestureRecognizer);

            btnInc.Clicked += (sender, args) =>
            {
                image.Opacity += .1;              
               
            };

            btnDec.Clicked += (sender, args) =>
            {
                image.Opacity -= .1; 
            };

            StackLayout botonera = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    btnInc, btnDec
                },
            HeightRequest = 1500
            };

            StackLayout container = new StackLayout
            {
                Children =
                {
                     image, botonera
                }
            };

            Content = container;
        }
    }
}