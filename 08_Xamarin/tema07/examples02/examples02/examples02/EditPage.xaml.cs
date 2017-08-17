using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace examples02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditPage : ContentPage
    {
        private Employee employee;

        public EditPage(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;

            updateButton.Clicked += UpdateButton_Clicked;
        }

        private async void UpdateButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameEntry.Text))
            {
                await DisplayAlert("Error", "Debe ingresar un nombre", "Aceptar");
                nameEntry.Focus();
                return;
            }

            if (string.IsNullOrEmpty(lastNameEntry.Text))
            {
                await DisplayAlert("Error", "Debe ingresar apellidos", "Aceptar");
                nameEntry.Focus();
                return;
            }

            if (string.IsNullOrEmpty(salaryEntry.Text))
            {
                await DisplayAlert("Error", "Debe ingresar un salario", "Aceptar");
                nameEntry.Focus();
                return;
            }

            Employee employee = new Employee
            {
                Id = this.employee.Id,
                Active = activeSwitch.IsToggled,
                LastName = lastNameEntry.Text,
                Name = nameEntry.Text,
                Salary = decimal.Parse(salaryEntry.Text),
                ContractDate = contractDateDP.Date
            };

            using (var data = new DataAccesss())
            {
                data.UpdateEmployee(employee);
            }

            await DisplayAlert("Confirmación", "Empleado actualizado correctamente", "Aceptar");
            await Navigation.PushAsync(new HomePage());
        }
    }
}