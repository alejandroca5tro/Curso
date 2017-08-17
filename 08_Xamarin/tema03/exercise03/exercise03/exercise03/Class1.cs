using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace exercise03
{
    class Class1 : ContentPage
    {
        public Class1()
        {
            Grid mainGrid = new Grid
            {
                BackgroundColor = Color.Accent
                ,
                ColumnSpacing = 3,
                RowSpacing = 3,
                VerticalOptions = LayoutOptions.FillAndExpand,                

                RowDefinitions =
                {
                    new RowDefinition { Height=GridLength.Auto},
                    new RowDefinition { Height=GridLength.Auto},
                    new RowDefinition { Height=GridLength.Auto}

                },
                ColumnDefinitions =
                {
                    //new ColumnDefinition {Width= new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition {Width= GridLength.Auto},
                    new ColumnDefinition {Width= new GridLength(1, GridUnitType.Star)},
                }
            };

            mainGrid.Children.Add(new Label
            {
                Text = "USUARIO:",
                FontSize = 15,
                FontAttributes = FontAttributes.Bold,
            }, 0, 0);

            mainGrid.Children.Add(new Entry
            {
                Placeholder = "Nombre Usuario",
                FontSize = 15,
                FontAttributes = FontAttributes.Bold,
            }, 1, 0);

            mainGrid.Children.Add(new Label
            {
                Text = "DIRECCIÓN:",
                FontSize = 15,
                FontAttributes = FontAttributes.Bold,
            }, 0, 1);

            mainGrid.Children.Add(new Entry
            {
                Placeholder = "Dirección",
                FontSize = 15,
                FontAttributes = FontAttributes.Bold,
            }, 1, 1);

            mainGrid.Children.Add(new Button
            {
                BackgroundColor = Color.Cyan,
                Text = "ACEPTAR",
                FontSize = 15,
                FontAttributes = FontAttributes.Bold,
            }, 0, 2);

            mainGrid.Children.Add(new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Cyan,              
                Text = "CANCELAR",
                FontSize = 15,
                FontAttributes = FontAttributes.Bold,
            }, 1, 2);

            Padding = new Thickness(10);
            Content = mainGrid;
        }
    }
}
