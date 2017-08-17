using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace exercise04_1
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {      
            Label lblTop = new Label
            {
                FontSize = 25,
                BackgroundColor = Color.Orange,
                TextColor = Color.White,
                Text = "Registro de Nacimientos"
            };

            Entry name = new Entry
            {
                FontSize = 18,
                Placeholder = "Nombre del recién nacido",
                TextColor = Color.Black
            };                     

            Label lblBD = new Label
            {
                FontSize = 18,
                Text = "Fecha de Nacimiento"
            };

            DatePicker dPBirthDate = new DatePicker
            {   
                Date = DateTime.Now,
                Format = "d",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label lblBH = new Label
            {
                FontSize = 18,
                Text = "Hora de nacimiento"
            };

            TimePicker tPBirthHour = new TimePicker
            {
                Format = "t",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label lblFA = new Label
            {
                FontSize = 18,
                Text = "La edad del padre es: 25"
            };

            Slider sldFatherAge = new Slider
            {
                Minimum = 0,
                Maximum = 65,
                Value = 25,
            };

            Label lblMA = new Label
            {
                FontSize = 18,
                Text = "La edad de la madre es: 25"
            };

            Slider sldMotherAge = new Slider
            {
                Minimum = 0,
                Maximum = 65,
                Value = 25,
            };

            Button btnAccept = new Button
            {
                Text = "Aceptar"
            };

            Label lblInfo = new Label
            {
                TextColor = Color.Black,
                FontSize = 18,
                IsVisible = false
            };

            sldFatherAge.ValueChanged += (sender, e) =>
            {
                lblFA.TextColor = Color.Black;
                lblFA.Text = String.Format("La edad del padre es: {0}", Convert.ToInt32(e.NewValue));
            };

            sldMotherAge.ValueChanged += (sender, e) =>
            {
                lblMA.TextColor = Color.Black;
                lblMA.Text = String.Format("La edad de la madre es: {0}", Convert.ToInt32(e.NewValue));
            };

            btnAccept.Clicked += (sender, args) =>
            {
                lblInfo.IsVisible = true;
                if (name.Text == null)
                {
                    lblInfo.Text = "Escribe un nombre para el bebé";
                }
                else
                {
                    lblInfo.Text =
                    "Nombre del bebé: " + name.Text
                    + "\nFecha de nacimiento: " + dPBirthDate.Date.Day.ToString() + "/" + dPBirthDate.Date.Month.ToString() + "/" + dPBirthDate.Date.Year.ToString()
                    + "\nHora de nacimiento: " + tPBirthHour.Time.Hours.ToString("00") + ":" + tPBirthHour.Time.Minutes.ToString("00")
                    + "\n" + lblFA.Text
                    + "\n" + lblMA.Text;
                }
            };

            ContentView cVShowInfo = new ContentView
            {
                Content = new StackLayout()
                {
                    Children =
                    {
                        lblInfo
                    }             
                }                
            };

            ScrollView cVMain = new ScrollView
            {
                Padding = new Thickness(30, 10, 30, 10),
                Content = new StackLayout()
                {
                    Children =
                    {
                        lblTop,
                        name,
                        lblBD,
                        dPBirthDate,
                        lblBH,
                        tPBirthHour,
                        lblFA,
                        sldFatherAge,
                        lblMA,
                        sldMotherAge,
                        btnAccept,
                        cVShowInfo
                    }
                }
            };

            StackLayout sLMain = new StackLayout
            {
                Children =
                {
                    cVMain
                }
            };            

            Content = sLMain;

        }
    }
}

