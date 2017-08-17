using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _17julio._2
{
    class horizontal:ContentPage
    {
        public horizontal()
        {
            StackLayout caja = new StackLayout
            {
                Spacing = 1,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    new Label
                    {
                        Text="Start is flush left",
                        HorizontalOptions=LayoutOptions.Start
                    },
                    new Label
                    {
                        Text="Center",
                        HorizontalOptions=LayoutOptions.Center
                    },
                    new Label
                    {
                        Text="End",
                        HorizontalOptions=LayoutOptions.End
                    }

                }
            };
            StackLayout hori = new StackLayout
            {
                Spacing=1,
                Orientation=StackOrientation.Horizontal,
                Children =
                {
                    new Label
                    {
                        Text="Start ----"
                        
                    },
                    new Label
                    {
                        Text="------center------",
                        HorizontalOptions=LayoutOptions.CenterAndExpand

                    },
                    new Label
                    {
                        Text="-----end"
                    }
                }
            };
            Padding = new Thickness(10);
            Content = hori;
            
            //Content = caja;
        }
    }
}
