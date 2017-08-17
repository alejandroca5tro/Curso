using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _17julio._2
{
    class content:ContentPage
    {
        public content()
        {
            ContentView caja = new ContentView
            {
                BackgroundColor=Color.Teal,
                Padding=new Thickness(40),
                HorizontalOptions=LayoutOptions.Fill,
                Content = new Label
                {
                    Text = "podemos poner cualquier valor,stacklayout...",
                    FontSize=20,
                    FontAttributes=FontAttributes.Bold,
                    TextColor=Color.White
                }
                
            };
            Padding = new Thickness(10);
            Content = new StackLayout
            {
                Children =
                {
                    caja
                }
            };
            
        }
    }
}
