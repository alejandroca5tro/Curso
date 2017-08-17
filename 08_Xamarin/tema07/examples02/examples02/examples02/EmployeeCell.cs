using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace examples02
{
    public class EmployeeCell : ViewCell
    {
        public EmployeeCell()
        {
            var idLbl = new Label
            {
                TextColor = Color.Black,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            idLbl.SetBinding(Label.TextProperty, new Binding("Id"));

            var nameLbl = new Label
            {
                TextColor = Color.Black,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            nameLbl.SetBinding(Label.TextProperty, new Binding("Name"));

            var lastNameLbl = new Label
            {
                TextColor = Color.Black,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            lastNameLbl.SetBinding(Label.TextProperty, new Binding("LastName"));

            var salaryLbl = new Label
            {
                TextColor = Color.Black,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            salaryLbl.SetBinding(Label.TextProperty, new Binding("Salary"));

            var contractDateLbl = new Label
            {
                TextColor = Color.Black,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            contractDateLbl.SetBinding(Label.TextProperty, new Binding("ContractDate"));

            var activeSwitchLbl = new Label
            {
                TextColor = Color.Black,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            activeSwitchLbl.SetBinding(Label.TextProperty, new Binding("Active"));

            View = new StackLayout
            {        
                           
                Children =
                {
                    idLbl,
                    nameLbl,
                    lastNameLbl,
                    salaryLbl,
                    contractDateLbl,
                    activeSwitchLbl
                }
            };
        }
    }
}
