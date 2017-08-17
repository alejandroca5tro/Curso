using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace examples02
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            Label employeeLbl = new Label
            {
                Text = "Empleados",
                FontSize = 24,
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Black
            };

            Entry nameEntry = new Entry
            {
                Placeholder = "Nombre",
                TextColor = Color.Black
            };

            Entry lastNameEntry = new Entry
            {
                Placeholder = "Apellido",
                TextColor = Color.Black
            };

            Entry salaryEntry = new Entry
            {
                Placeholder = "Salario",
                TextColor = Color.Black,
                Keyboard = Keyboard.Numeric
            };

            DatePicker contractDateDP = new DatePicker { };

            Label activeLbl = new Label
            {
                Text = "Activo",
                FontSize = 18,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.EndAndExpand
            };

            Switch activeSwitch = new Switch
            {
                IsToggled = true,
                HorizontalOptions = LayoutOptions.End
            };

            Button addButton = new Button
            {
                Text = "Agregar",
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Yellow,
                TextColor = Color.Black
            };

            ListView listViewList = new ListView { };

            StackLayout mainSL = new StackLayout
            {
                Children =
                {
                    employeeLbl,
                    nameEntry,
                    lastNameEntry,
                    salaryEntry,

                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            contractDateDP,
                            activeLbl,
                            activeSwitch
                        }
                    },

                    addButton,
                    listViewList
                }
            };

            listViewList.ItemSelected += ListViewList_ItemSelected;

            addButton.Clicked += async (sender, e) =>
            {
                if (string.IsNullOrEmpty(nameEntry.Text))
                {
                    await DisplayAlert("Error", "Debes ingresar un nombre", "Aceptar");
                    nameEntry.Focus();
                }

                if (string.IsNullOrEmpty(lastNameEntry.Text))
                {
                    await DisplayAlert("Error", "Debes ingresar apellidos", "Aceptar");
                    lastNameEntry.Focus();
                }

                if (string.IsNullOrEmpty(salaryEntry.Text))
                {
                    await DisplayAlert("Error", "Debes ingresar un salario", "Aceptar");
                    salaryEntry.Focus();
                    return;
                }

                Employee employee = new Employee()
                {
                    Name = nameEntry.Text,
                    LastName = lastNameEntry.Text,
                    Active = activeSwitch.IsToggled,
                    Salary = decimal.Parse(salaryEntry.Text),
                    ContractDate = contractDateDP.Date
                };

                using (var data = new DataAccesss())
                {
                    data.InsertEmployee(employee);
                    listViewList.ItemsSource = data.GetEmployees();
                }

                nameEntry.Text = string.Empty;
                lastNameEntry.Text = string.Empty;
                salaryEntry.Text = string.Empty;
                contractDateDP.Date = DateTime.Now;
                await DisplayAlert("Mensaje", "Empleado creado correctamente", "Aceptar");
            };

            listViewList.ItemTemplate = new DataTemplate(typeof(EmployeeCell));

            using (var data = new DataAccesss())  
            {
                listViewList.ItemsSource = data.GetEmployees();
            }

            Content = new ScrollView
            {
                Content = mainSL
            };
        }

        private void ListViewList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new EditPage((Employee)e.SelectedItem));
        }
    }
}