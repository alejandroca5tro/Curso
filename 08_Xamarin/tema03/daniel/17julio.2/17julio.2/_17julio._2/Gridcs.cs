using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _17julio._2
{
    class Gridcs:ContentPage
    {
        public Gridcs()
        {
            Grid g1 = new Grid
            {
                VerticalOptions=LayoutOptions.FillAndExpand,
                RowDefinitions =
                {
                    new RowDefinition { Height=GridLength.Auto},
                    new RowDefinition {Height=new GridLength(200,GridUnitType.Auto)},
                    new RowDefinition {Height=new GridLength(200,GridUnitType.Auto)},
                    new RowDefinition { Height=GridLength.Auto}

                },
                ColumnDefinitions =
                {
                    new ColumnDefinition {Width=GridLength.Auto},
                    new ColumnDefinition {Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition {Width=GridLength.Auto}
                }
            };
            g1.Children.Add(new Label
            {
                Text="yo soy el 0.0",
                FontSize=30,
                FontAttributes=FontAttributes.Bold,
            },0,0);
            g1.Children.Add(new Label
            {
                Text = "yo soy el 1.3",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                TextColor=Color.Black,
                BackgroundColor=Color.Lime
            }, 1, 3,1,2);
            g1.Children.Add(new Label
            {
                Text = "yo soy el 0.3",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
               
            }, 0,3);
            Padding = new Thickness(10,20,10,5);
            Content = g1;
        }
    }
}
