using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public class Page2 : ContentPage
    {
        public Page2()
        {

            Entry entry = new Entry()
            {
                Placeholder = "Introduce tu Dni",
                VerticalOptions = LayoutOptions.Center,
                Keyboard = Keyboard.Default
            };

            Image image = new Image
            {
                Source = "circle.png",
                Aspect = Aspect.AspectFit,
                //HorizontalOptions = LayoutOptions.End,
                //VerticalOptions = LayoutOptions.Fill
            };

            var tapGestureRecognizer = new TapGestureRecognizer();

            tapGestureRecognizer.Tapped += async (s, e) =>
            {                         
                    image.Opacity = .5;
                    await Task.Delay(200);
                    image.Opacity = 1;              
          
            };

            image.GestureRecognizers.Add(tapGestureRecognizer);

            StackLayout Contenedor = new StackLayout
            {
                Children =
                {
                    entry, image
                }
            };

            Content = Contenedor;            
        }
    }
}