using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _17julio._2
{
    class Pagina4:MainPage
    {
        public Pagina4()
        {
            Entry n1 = new Entry
            {
                Placeholder = "Primer Numero",
                Keyboard = Keyboard.Numeric,
                
            };

            Entry n2 = new Entry
            {
                Placeholder = "Segundo Numero",
                Keyboard = Keyboard.Numeric,
                
            };
            Button btnSuma = new Button
            {
                Text = "SUMAR",
                BackgroundColor = Color.Yellow,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
               
            };
            btnSuma.Clicked += (sender, args) =>
            {
                var suma = Convert.ToInt32(n1.Text) + Convert.ToInt32(n2.Text);
                btnSuma.Text = suma.ToString();
            };

            Button btnResta = new Button
            {
                Text = "RESTAR",
                BackgroundColor = Color.Yellow,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
                
            };
            btnResta.Clicked += (sender, args) =>
            {
                var resta = Convert.ToInt32(n1.Text) - Convert.ToInt32(n2.Text);
                btnResta.Text = resta.ToString();
            };

            Button btnMulti = new Button
            {
                Text = "MULTIPLICAR",
                BackgroundColor = Color.Yellow,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
                
            };
            btnMulti.Clicked += (sender, args) =>
            {
                var multi = Convert.ToInt32(n1.Text) * Convert.ToInt32(n2.Text);
               btnMulti.Text = multi.ToString();
            };

            Button btnDividir = new Button
            {
                Text = "DIVIDIR",
                BackgroundColor = Color.Yellow,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
                
            };
            btnDividir.Clicked += (sender, args) =>
            {
                var divi = Convert.ToInt32(n1.Text) / Convert.ToInt32(n2.Text);
                btnDividir.Text = divi.ToString();
            };
            StackLayout botonera1 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    btnSuma,btnResta
                },
                
            };

            StackLayout botonera2 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    btnMulti,btnDividir
                },
                
            };
            StackLayout contenedor = new StackLayout
            {
                Children =
                {
                    n1,n2,
                    botonera1,
                    botonera2
              
                }

            };
            Content = contenedor;
        }

    }
}
