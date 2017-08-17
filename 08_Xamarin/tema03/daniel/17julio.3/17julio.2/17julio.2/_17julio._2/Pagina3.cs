using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _17julio._2
{
    class Pagina3: MainPage
    {
        public Pagina3()
        {
            Image image = new Image
            {
                Source = "b60d85053805086eb22ad98c6288e23f.png",
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Fill,
                Opacity=.5
            };
            Button btn1 = new Button
            {
                Text = "Aumentar",
                BackgroundColor = Color.Azure,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill,
                IsVisible=false
            };
            btn1.Clicked += (sender, args) =>
            {
                image.Opacity += .1;
            };

            Button btn2 = new Button
            {
                Text = "Disminuir",
                BackgroundColor = Color.Azure,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill,
                IsVisible=false
            };
            btn2.Clicked += (sender, args) =>
            {
                image.Opacity -= .1;
            };
            var toque = new TapGestureRecognizer();

            toque.Tapped +=  (s, e) =>
             {
                 
                 btn1.IsVisible = true;
                 btn2.IsVisible = true;
                

             };
            image.GestureRecognizers.Add(toque);


            Entry entradaUsuario = new Entry
            {
                Placeholder="Usename",
                Keyboard=Keyboard.Text,
                IsPassword=true
            };

            BoxView boxView = new BoxView
            {
                Color=Color.Silver,
                WidthRequest=150,
                HeightRequest=150,
                HorizontalOptions=LayoutOptions.StartAndExpand,
                VerticalOptions=LayoutOptions.Fill
            };

            StackLayout botonera = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    btn1,btn2
                },
                HeightRequest = 1500
            };
            StackLayout contenedor = new StackLayout
            {
                Children =
                {

                    //image,botonera,
                    boxView

                }

            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions=LayoutOptions.FillAndExpand,
                Content=contenedor
            };
            Content = scrollView;
        }
    }
}
