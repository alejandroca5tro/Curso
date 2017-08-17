using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace examples
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            Title = "Navegación Jerárquica";

            Label homeLabel = new Label
            {
                Text = "Home Page",
                FontSize = 40
            };

            Button homeButton = new Button
            {
                Text = "Ve a la segunda página"
            };
            homeButton.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new SecondPage());
            };

            Button button = new Button
            {
                Text = "Mostrar alerta"
            };
            button.Clicked += async (sender, e) =>
            {
                await DisplayAlert("ATENCIÓN", "Descubrir el valor de navegación", "OK");
            };

            Button button1 = new Button
            {
                Text = "Show Alert with Feedback"
            };
            button1.Clicked += async (sender, e) =>
            {
                var answer =  await DisplayAlert("Start", "¿Estás dispuesto a seguir?", "OK", "CANCEL");
            };

            Button button2 = new Button
            {
                Text = "Show ActionSheet"
            };
            Label label = new Label
            {
                Text = ""
            };
            button2.Clicked += async (sender, e) =>
            {
                string action = await DisplayActionSheet("Options", "Cancel", null, "Here", "There", "Everywhere");
                label.Text = "Action is: " + action;
            };

            StackLayout stackLayout = new StackLayout
            {
                Children =
                {
                    homeLabel, homeButton, button, button1, button2, label
                }
            };

            Content = stackLayout;
        }
    }
}