using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _17julio._2
{
    class Pagina5:ContentPage
    {
        string contra = "chope12";
        public Pagina5()
        {
            Label titulo = new Label()
            {
                Text="FORMULARIO DE VALIDACION",
                FontSize=40,
                HorizontalOptions=LayoutOptions.Center,
                BackgroundColor=Color.Yellow
            };
            Entry user = new Entry
            {
                Placeholder = "UserName",
                Keyboard = Keyboard.Text,
                BackgroundColor=Color.Orange

            };

            Entry pass = new Entry
            {
                Placeholder = "Password",
                Keyboard = Keyboard.Text,
                IsPassword=true,
                BackgroundColor = Color.Orange

            };
            Button btn1 = new Button
            {
                Text = "ACEPTAR",
                BackgroundColor = Color.Silver,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill

            };
            

            Button btn2 = new Button
            {
                Text = "CANCELAR",
                BackgroundColor = Color.Silver,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill

            };
            
            Image image = new Image
            {
                Source = "b60d85053805086eb22ad98c6288e23f.png",
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Fill,
                IsVisible=false
            };
            btn1.Clicked += (sender, args) =>
            {
                if (pass.Text==contra)
                {
                    image.IsVisible = true;
                }

            };

            btn2.Clicked += (sender, args) =>
            {
                image.IsVisible = false;
            };
            StackLayout contenedor = new StackLayout
            {
                Children =
                {
                    titulo,
                    user,
                    pass,
                    btn1,
                    btn2,
                    image

                }

            };
            Padding = new Thickness(10);
            Content = contenedor;

        }
    }
}
