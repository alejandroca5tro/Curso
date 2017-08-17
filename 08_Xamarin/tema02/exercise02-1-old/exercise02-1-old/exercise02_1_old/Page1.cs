using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace exercise02_1_old
{
    public class Page1 : ContentPage
    {
        string password = "kepasa";
        public Page1()
        {    
            Label lbl1 = new Label
            {
                Text = "Formulario de Validación de datos",
                FontSize = 40,
                BackgroundColor = Color.Blue,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Center
            };

            Entry entryUser = new Entry
            {
                Placeholder = "Usuario",
                BackgroundColor = Color.Gray,
                VerticalOptions = LayoutOptions.Center,
                Keyboard = Keyboard.Text
            };

            Entry entryPassword = new Entry
            {
                Placeholder = "Contraseña",
                BackgroundColor = Color.Gray,
                VerticalOptions = LayoutOptions.Center,
                Keyboard = Keyboard.Text,
                IsPassword = true                
            };

            Button btnAccept = new Button
            {
                Text = "Aceptar",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BackgroundColor = Color.Black,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            Button btnCancel = new Button
            {
                Text = "Cancelar",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BackgroundColor = Color.Black,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            Image image = new Image
            {
                Source = "forest.jpg",  
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.End,
                IsVisible = false
            };

            btnAccept.Clicked += (sender, args) =>
            {
                if (entryPassword.Text == password)
                {
                    image.IsVisible = true;
                }
            };

            btnCancel.Clicked += (sender, args) =>
            {
                entryUser.Text = "";
                entryPassword.Text = "";
                image.IsVisible = false;
            };

            StackLayout sLLogin = new StackLayout
            {
                Children =
                {
                    entryUser, entryPassword
                }
            };

            StackLayout sLButtons = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    btnAccept, btnCancel
                }
            };                    

            StackLayout sLMain = new StackLayout
            {
                Children =
                {
                    lbl1, sLLogin, sLButtons, image
                }
            };

            Padding = new Thickness(10);
            Content = sLMain;
        }
    }
}