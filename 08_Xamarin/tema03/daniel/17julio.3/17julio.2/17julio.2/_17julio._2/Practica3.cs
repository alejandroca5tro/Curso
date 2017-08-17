using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _17julio._2
{
    class Practica3:ContentPage
    {
        public Practica3()
        {
            Grid g2 = new Grid
            {
                VerticalOptions=LayoutOptions.FillAndExpand,
                RowDefinitions =
                {
                    new RowDefinition { Height=GridLength.Auto},
                    new RowDefinition { Height=GridLength.Auto},
                    new RowDefinition { Height=GridLength.Auto},
                    new RowDefinition { Height=GridLength.Auto}
                },

                ColumnDefinitions =
                {
                     new ColumnDefinition {Width=GridLength.Auto},
                     new ColumnDefinition {Width=new GridLength(2,GridUnitType.Star)},
                     
                }

            };

            g2.Children.Add(new Label
            {
                Text="USUARIO :",
                FontAttributes=FontAttributes.Bold

            },0,0);

            g2.Children.Add(new Label
            {
                Text = "DIRECCION :",
                FontAttributes = FontAttributes.Bold

            }, 0, 1);

            g2.Children.Add(new Entry
            {
                Placeholder="Nombre de Usuario",
                FontAttributes = FontAttributes.Bold

            }, 1, 0);

            g2.Children.Add(new Entry
            {
                Placeholder = "Direccion",
                FontAttributes = FontAttributes.Bold

            }, 1, 1);

            g2.Children.Add(new Button
            {
               Text = "Aceptar",
                FontAttributes = FontAttributes.Bold,
                BackgroundColor=Color.Aqua,
                TextColor=Color.White

            }, 0, 3);

            g2.Children.Add(new Button
            {
                Text = "Cancelar",
                HorizontalOptions=LayoutOptions.Center,
                FontAttributes = FontAttributes.Bold,
                BackgroundColor = Color.Aqua,
                TextColor = Color.White

            }, 1, 3);
            BackgroundColor = Color.Yellow;
            Padding = new Thickness(20,10,10,10);
           
            Content = g2;
        }
    }
}
