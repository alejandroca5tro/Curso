using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    class ContentViewExample : ContentPage
    {
        public ContentViewExample()
        {

            Label label = new Label()
            {
                Text = "Una label",
            };

            ContentView contentView = new ContentView
            {
                BackgroundColor = Color.Teal,
                Padding = new Thickness(40),
                HorizontalOptions = LayoutOptions.Fill,
                Content = new StackLayout
                {
                    Children =
                    {
                        //Text = "Podemos opner cualquier valor, stacklayout, etc",
                    
                    }
                }
            };

            Content = contentView;
        }
    }
}
