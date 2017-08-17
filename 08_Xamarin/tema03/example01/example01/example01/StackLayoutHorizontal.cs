using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace example01
{
    class StackLayoutHorizontal
    {
        public StackLayoutHorizontal()
        {
            StackLayout stackLayout = new StackLayout
            {
                Spacing = 1,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    new Label
                    {
                        Text="Start is flush left",
                        HorizontalOptions=LayoutOptions.Start,
                    },

                    new Label
                    {
                        Text = "Center",
                        HorizontalOptions = LayoutOptions.Start,
                    },

                      new Label
                    {
                        Text="End",
                        HorizontalOptions=LayoutOptions.Start,
                    },
                }
            };

            StackLayout stackLayoutHorizontal = new StackLayout
            {
                Spacing = 1,
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new Label
                    {
                        Text="Start ----",
                        HorizontalOptions=LayoutOptions.Start,
                    },

                    new Label
                    {
                        Text = "--- Center ---",
                        HorizontalOptions = LayoutOptions.Start,
                    },

                      new Label
                    {
                        Text="---- End",
                        HorizontalOptions=LayoutOptions.Start,
                    },
                }
            };
        }
    }
}
