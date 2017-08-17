using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _17julio._2
{
    class frames:ContentPage
    {
        public frames()
        {
            Padding = 20;
            this.Content = new Frame
            {
                Content = new StackLayout
                {
                    Spacing=13,
                    Children =
                    {
                        new Label {Text="Framed",FontSize=40,TextColor=Color.Yellow}
                    }
                },
                BackgroundColor=Color.Aquamarine,
                OutlineColor=Color.Red
            };
        }
    }
}
