using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace exerciseProposed
{
    class Class1 : ContentPage
    {
        public Class1()
        {
            Label lbl1 = new Label
            {
                Text = "BET365",
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.White
            };


            ContentView mainCV = new ContentView
            {

                BackgroundColor = Color.Green,
                Padding = new Thickness(40),
                HorizontalOptions = LayoutOptions.Fill,
                Content = 
                {
                    lbl1
                }
            };

            

            StackLayout mainSL = new StackLayout
            {
                Children =
                {
                    mainCV
                }
            };

            Padding = new Thickness(10, 5);
            Content = mainSL;
        }
    }
}
