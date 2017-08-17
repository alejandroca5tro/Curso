using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace _17julio._2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            boton.Clicked += (sender, args) =>
            {
                boton.Text = "It is So";

            };
            var tapp = new TapGestureRecognizer();
            tapp.Tapped += async (s, e) =>
              {
                  image.Opacity = .5;
                  await Task.Delay(200);
                  image.Opacity = 1;

              };
            image.GestureRecognizers.Add(tapp);

        }
    }
}