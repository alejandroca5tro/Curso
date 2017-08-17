using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _17julio._2
{
    class bet:ContentPage
    {
        public bet()
        {
            ContentView apuesta = new ContentView
            {
                BackgroundColor = Color.Green,
                Padding = new Thickness(40),
                HorizontalOptions = LayoutOptions.Fill,
                Content = new StackLayout()
                {
                    Children =
                    {
                        new Label
                        {
                            Text="BET 365",
                            FontSize=30,
                            TextColor=Color.Yellow,
                            HorizontalOptions=LayoutOptions.Start
                        },
                        new Label
                        {
                            Text="Tu casa de apuestas por internet",
                            FontSize=20,
                            TextColor=Color.Yellow,
                            HorizontalOptions=LayoutOptions.Start
                        },
                        new ContentView
                        {
                            BackgroundColor=Color.White,
                            Content=new StackLayout()
                            {
                                Children=
                                {
                                    new Entry
                                    {
                                        Placeholder="Usuario",
                                        PlaceholderColor=Color.Black
                                    },
                                    new Entry
                                    {
                                        Placeholder="Contraseña",
                                        PlaceholderColor=Color.Black,
                                        IsPassword=true,
                                        Keyboard=Keyboard.Numeric
                                    },
                                    new ContentView
                                    {
                                        BackgroundColor=Color.Yellow,
                                        Content= new StackLayout
                                        {
                                            Children=
                                            {
                                                new Button
                                                {
                                                    Text="Aceptar",
                                                    BackgroundColor=Color.Green,
                                                    TextColor=Color.Yellow
                                                },
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                
            };
            this.Padding = new Thickness(10, 20, 10, 5);
            this.Content = new StackLayout
            {
                Children =
                {
                    apuesta
                }
            };

        }
    }
}
