using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace examples
{
    public class NumberPage : ContentPage
    {
        public NumberPage()
        {
            this.SetBinding(ContentPage.TitleProperty, "Name");
            Label label = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                Font = Font.SystemFontOfSize(40)
            };
            label.SetBinding(Label.TextProperty, "Number");
            Content = label;
        }
    }
}