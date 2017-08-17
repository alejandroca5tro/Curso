using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace exercise06_2
{
    public class secondPage : ContentPage
    {
        public secondPage()
        {
            Title = "Prueba";
            Label homeLabel = new Label
            {
                Text = "Second Page",
                FontSize = 40
            };
            var stackLayout = new StackLayout
            {
                Children = { homeLabel }
            };
            this.Content = stackLayout;
        }
    }
}