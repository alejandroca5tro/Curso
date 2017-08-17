using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejemplo5._1
{
    public class ListItemCell : ViewCell
    {
        public ListItemCell()
        {
            Label titleLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontSize = 25,
                FontAttributes = Xamarin.Forms.FontAttributes.Bold,
                TextColor = Color.White
            };
            titleLabel.SetBinding(Label.TextProperty, "Title");

            Label descLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontSize = 12,
                TextColor = Color.White
            };
            descLabel.SetBinding(Label.TextProperty, "Description");

            StackLayout viewLayoutItem = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Vertical,
                Children = { titleLabel, descLabel }
            };

            Label priceLabel = new Label
            {
                HorizontalOptions = LayoutOptions.End,
                FontSize = 12,
                TextColor = Color.Aqua
            };
            priceLabel.SetBinding(Label.TextProperty, "Price");
            var button = new Button
            {
                Text = "Buy Now",
                BackgroundColor = Color.Teal,
                HorizontalOptions = LayoutOptions.EndAndExpand
            };
            button.SetBinding(Button.CommandParameterProperty, new Binding("."));

            button.Clicked += (sender, e) =>
            {
                var b = (Button)sender;
                var item = (ListItem)b.CommandParameter;
                ((ContentPage)((ListView)((StackLayout)((StackLayout)b.Parent)
               .Parent).Parent).Parent).DisplayAlert("Clicked", item.Title.ToString() +
               " button was clicked", "OK");

                //((ContentPage)((ListView)((StackLayout)((StackLayout)b.ParentView)
                //.ParentView).ParentView).ParentView).DisplayAlert("Clicked", item.Title.ToString() +
                //" button was clicked", "OK");
                //opcion alternativa las de arriba no funcionan
                string texto = item.Title.ToString() + " button was clicked";
                Debug.WriteLine(texto);
            };
            StackLayout viewLayout = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Horizontal,
                Padding = new Thickness(25, 10, 55, 15),
                Children = { viewLayoutItem, priceLabel,button }
            };

            View = viewLayout;
            //Añadimos Buttons 1

            //Añadimos Buttons
            var moreAction = new MenuItem { Text = "More" };
            moreAction.SetBinding(MenuItem.CommandParameterProperty, new Binding("."));
            moreAction.Clicked += (sender, e) =>
            {
                var mi = ((MenuItem)sender);
                var item = (ListItem)mi.CommandParameter;
                Debug.WriteLine("More clicked on row:" + item.Title.ToString());
            };
            var deleteAction = new MenuItem { Text = "Delete", IsDestructive = true };
            deleteAction.SetBinding(MenuItem.CommandParameterProperty, new Binding("."));
            deleteAction.Clicked += (sender, e) =>
            {
                var mi = ((MenuItem)sender);
                var item = (ListItem)mi.CommandParameter;
                Debug.WriteLine("Delete clicked on row" + item.Title.ToString());
            };
            ContextActions.Add(moreAction);
            ContextActions.Add(deleteAction);

        }
    }
}
