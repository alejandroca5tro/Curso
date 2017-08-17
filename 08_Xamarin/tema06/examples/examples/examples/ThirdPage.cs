using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace examples
{
    public class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            Label label = new Label
            {
                Text = "Tercera Página",
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
