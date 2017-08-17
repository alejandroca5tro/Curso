using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    class GridExample
    {
        public GridExample()
        {
            Grid grid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions =
                {
                    new RowDefinition {Height = GridLength.Auto },
                    new RowDefinition {Height = new GridLength(200, GridUnitType.Auto) },
                    new RowDefinition {Height = new GridLength(200, GridUnitType.Auto) },
                    new RowDefinition {Height = GridLength.Auto }
                },

                ColumnDefinitions =
                {
                    new ColumnDefinition {Width = GridLength.Auto },
                    new ColumnDefinition {Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition {Width = GridLength.Auto }
                }
            };

            grid.Children.Add(new Label
            {
                Text = "Yo soy el 0,0",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
            }, 0, 0);

            grid.Children.Add(new Label
            {
                Text = "Yo soy el 1,3",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
            }, 1, 3);

           




        }
    }
}
