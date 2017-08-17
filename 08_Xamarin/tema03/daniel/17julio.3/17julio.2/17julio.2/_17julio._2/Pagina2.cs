using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _17julio._2
{
    class Pagina2 : ContentPage
    {
        public Pagina2()
        {
            Entry entry = new Entry()
            {
                Placeholder = "Introduce tu DNI",
                VerticalOptions=LayoutOptions.Center,
                Keyboard=Keyboard.Text

            };
            Image image = new Image
            {
                Source= "b60d85053805086eb22ad98c6288e23f.png",
                Aspect=Aspect.AspectFit,
                HorizontalOptions= LayoutOptions.End,
                VerticalOptions = LayoutOptions.Fill
            };
            var tapGestureRecognizer = new TapGestureRecognizer();

            tapGestureRecognizer.Tapped += async (s, e) =>
            {
                image.Opacity = .5;
                await Task.Delay(200);
                image.Opacity = 1;
            };
            image.GestureRecognizers.Add(tapGestureRecognizer);

            StackLayout contenedor = new StackLayout
            {
                Children =
                {
                    entry,image
                }
            };
            Content = contenedor;
        }
    }
}
