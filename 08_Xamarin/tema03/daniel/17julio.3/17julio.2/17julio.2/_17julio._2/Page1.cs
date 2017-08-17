using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace _17julio._2
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            Label Nombre = new Label()
            {
                Text="Daniel",
                FontSize=28,
                HorizontalOptions=LayoutOptions.Center
            };
            Label Apellidos = new Label()
            {
                Text = "Garcia Lindo",
                FontSize = 28,
                HorizontalOptions = LayoutOptions.Center
            };
            Button btn1 = new Button
            {
                Text="Concatenar",
                BackgroundColor=Color.Azure,
                FontSize=Device.GetNamedSize(NamedSize.Large,typeof(Button)),
                HorizontalOptions=LayoutOptions.Center,
                VerticalOptions=LayoutOptions.Fill
            };
            btn1.Clicked += (sender, args) =>
             {
                 btn1.Text = Nombre.Text + " " + Apellidos.Text;
                 Nombre.Text = "";
                 Apellidos.Text = "";
             };
            StackLayout caja = new StackLayout
            {
                Children =
                {
                    Nombre,Apellidos,btn1

                }

            };
            Content = caja;

        }
    }
}