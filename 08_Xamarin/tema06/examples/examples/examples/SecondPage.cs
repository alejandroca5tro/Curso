using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace examples
{
    class SecondPage : ContentPage
    {
        public SecondPage()
        {
            Label label = new Label
            {
                Text = "Segunda Página",
                FontSize = 40
            };

            StackLayout stackLayout = new StackLayout
            {
                Children = { label }
            };
            Content = stackLayout;
        }
    }
}
