using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace exercise02_2
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            Entry n1 = new Entry
            {
                Placeholder = "Inserta un número",
                VerticalOptions = LayoutOptions.Center,
                Keyboard = Keyboard.Text
            };

            Entry n2 = new Entry
            {
                Placeholder = "Inserta otro número",
                VerticalOptions = LayoutOptions.Center,
                Keyboard = Keyboard.Text
            };

            Button btnAdd = new Button
            {
                BackgroundColor = Color.Yellow,
                Text = "SUMAR",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill,                
            };

            Button btnSub = new Button
            {
                BackgroundColor = Color.Yellow,
                Text = "RESTAR",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill,
            };

            Button btnPro = new Button
            {
                BackgroundColor = Color.Yellow,
                Text = "MULTIPLICAR",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill,
            };

            Button btnDiv = new Button
            {
                BackgroundColor = Color.Yellow,
                Text = "DIVIDIR",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill,
            };

            btnAdd.Clicked += (sender, args) =>
            {                
                btnAdd.Text = (Convert.ToInt32(n1.Text) + Convert.ToInt32(n2.Text)).ToString();   
            };

            btnSub.Clicked += (sender, args) =>
            {
                btnSub.Text = (Convert.ToInt32(n1.Text) - Convert.ToInt32(n2.Text)).ToString();
            };

            btnPro.Clicked += (sender, args) =>
            {
                btnPro.Text = (Convert.ToInt32(n1.Text) * Convert.ToInt32(n2.Text)).ToString();
            };

            btnDiv.Clicked += (sender, args) =>
            {
                btnDiv.Text = (Convert.ToDecimal(n1.Text) / Convert.ToDecimal(n2.Text)).ToString("0.00");
            };

            StackLayout sLN1 = new StackLayout
            {
                Children =
                {
                    n1
                }
            };

            StackLayout sLN2 = new StackLayout
            {
                Children =
                {
                    n2
                }
            };

            StackLayout sLInsertNumbers = new StackLayout
            {
                Children =
                {
                    sLN1, sLN2
                }
            };

            StackLayout sLButtons1 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    btnAdd, btnSub
                }
            };

            StackLayout sLButtons2 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    btnPro, btnDiv
                }
            };

            StackLayout sLButtons = new StackLayout
            {
                Children =
                {
                    sLButtons1, sLButtons2
                }
            };

            StackLayout sLMain = new StackLayout
            {
                Children =
                {
                    sLInsertNumbers, sLButtons
                }
            };

            ScrollView sVMain = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = sLMain
            };

            Content = sVMain;
        }
    }
}