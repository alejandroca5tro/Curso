using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace examples
{
    class PickerStepperSliderExamples : ContentPage
    {
        public PickerStepperSliderExamples()
        {
            Label eventValue = new Label();
            Label pageValue = new Label();

            Picker picker = new Picker
            {
                Title = "Despliega la lista de elementos",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var options = new List<String> { "First", "Second", "Third", "Fourth" };

            foreach (string optionName in options)
            {
                picker.Items.Add(optionName);
            };

            picker.SelectedIndexChanged += (sender, args) =>
              {
                  pageValue.Text = picker.Items[picker.SelectedIndex];
              };

            DatePicker datePicker = new DatePicker
            {
                Format = "d",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            datePicker.DateSelected += (object sender, DateChangedEventArgs e) =>
              {
                  eventValue.Text = e.NewDate.ToString();
                  pageValue.Text = datePicker.Date.ToString();
              };

            TimePicker timePicker = new TimePicker
            {
                Format = "t",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            timePicker.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
                {
                    pageValue.Text = timePicker.Time.ToString();
                }
            };

            Stepper stepper = new Stepper
            {
                Minimum = 0,
                Maximum = 10,
                Increment = 2,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            stepper.ValueChanged += (sender, e) =>
            {
                eventValue.Text = e.NewValue.ToString();
                pageValue.Text = stepper.Value.ToString();
            };

            Slider slider = new Slider
            {
                Minimum = 0,
                Maximum = 10,
                Value = 20,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 300
            };

            slider.ValueChanged += (sender, e) =>
            {
                eventValue.Text = Convert.ToInt32(e.NewValue).ToString();
                pageValue.Text = slider.Value.ToString();
            };

            Switch switcher = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            switcher.Toggled += (sender, e) =>
            {
                eventValue.Text = switcher.IsToggled.ToString();
            };

            Padding = new Thickness(10, 20, 10, 5);

            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    eventValue,
                    pageValue,
                    picker,
                    datePicker,
                    timePicker,
                    stepper,
                    slider
                }
            };        
        }
    }
}
