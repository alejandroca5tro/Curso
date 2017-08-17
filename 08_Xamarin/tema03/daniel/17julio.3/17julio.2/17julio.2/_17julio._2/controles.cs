using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _17julio._2
{
    class controles:ContentPage
    {
        public controles()
        {
            Label eventValue = new Label();
            Label pageValue = new Label();

            Picker pico = new Picker
            {
                Title="Elementos",
                VerticalOptions=LayoutOptions.CenterAndExpand
            };
            var options = new List<String> { "First", "Second", "Thrid", "Fourth" };
            foreach (string optionName in options)
            {
                pico.Items.Add(optionName);

            }
            pico.SelectedIndexChanged+=(sender,args)=>
            {
                pageValue.Text = pico.Items[pico.SelectedIndex];

            };

            DatePicker datePicker = new DatePicker
            {
                Format="D",
                VerticalOptions=LayoutOptions.CenterAndExpand
            };
            datePicker.DateSelected += (object sender, DateChangedEventArgs e) =>
              {
                  eventValue.Text = e.NewDate.ToString();
                  pageValue.Text = datePicker.Date.ToString();
              };

            TimePicker reloj = new TimePicker
            {
                Format="T",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            reloj.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName==TimePicker.TimeProperty.PropertyName)
                {
                    pageValue.Text = reloj.Time.ToString();
                }
            };

            Switch swither = new Switch
            {
                HorizontalOptions=LayoutOptions.Center,
                VerticalOptions=LayoutOptions.CenterAndExpand
            };
            swither.Toggled += (sender, e) =>
            {
                eventValue.Text = e.Value.ToString();
                pageValue.Text = swither.IsToggled.ToString();
            };

            Stepper stepper = new Stepper
            {
                Minimum=0,
                Maximum=10,
                Increment=1,
                HorizontalOptions=LayoutOptions.Center,
                VerticalOptions=LayoutOptions.CenterAndExpand
            };
            stepper.ValueChanged += (sender, e) =>
            {
                eventValue.Text = e.NewValue.ToString();
                pageValue.Text = stepper.Value.ToString();
            };

            Slider slider = new Slider
            {
                Minimum=0,
                Maximum=100,
                Value=20,
                VerticalOptions=LayoutOptions.Center,
                WidthRequest=300
            };
            slider.ValueChanged += (sender, e) =>
             {
                 eventValue.Text = e.NewValue.ToString();
                 pageValue.Text = slider.Value.ToString();
             };



            Padding = new Thickness(10, 20, 10, 5);
            Content = new StackLayout
            {
                HorizontalOptions=LayoutOptions.Center,
                Children =
                {
                    eventValue,pageValue,pico,datePicker,reloj,stepper,slider,swither
                }
            };
        }
    }
}
