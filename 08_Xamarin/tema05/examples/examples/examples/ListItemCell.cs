﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace examples
{
    public class ListItemCell : ViewCell
    {
        public ListItemCell()
        {
            Label titleLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontSize = 25,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.White
            };
            titleLabel.SetBinding(Label.TextProperty, "Title");

            Label descLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontSize = 12,
                TextColor = Color.White
            };
            descLabel.SetBinding(Label.DetailProperty, "Description");

            StackLayout viewLayoutItem = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Vertical,
                Children =
                {
                    titleLabel, descLabel
                }
            };

            Label priceLabel = new Label
            {
                HorizontalOptions = LayoutOptions.End,
                FontSize = 12,
                TextColor = Color.Aqua
            };
            priceLabel.SetBinding(Label.TextProperty, "Price");

            var button = new Button()
            {
                Text = "Comprar ahora",
                BackgroundColor = Color.Teal,
                HorizontalOptions = LayoutOptions.EndAndExpand
            };
            button.SetBinding(Button.CommandParameterProperty, new Binding("."));

            button.Clicked += (sender, e) =>
            {
                var b = (Button)sender;
                var item = (ListItemCustom)b.CommandParameter;
                //((ContentPage)((ListView)((StackLayout)((StackLayout)b.Parent).Parent).Parent).Parent).DisplayAlert("Clicked", item.Title.ToString() + " button was clicked", "OK");
                Debug.WriteLine("Has seleccionado el elemento: " + item.Title.ToString());
            };

            StackLayout viewLayout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Horizontal,
                Padding = new Thickness(25, 10, 55, 15),
                Children =
                {
                    viewLayoutItem, priceLabel, button
                }
            };

            View = viewLayout;

            var moreAction = new MenuItem { Text = "More" };
            moreAction.SetBinding(MenuItem.CommandParameterProperty, new Binding("."));
            moreAction.Clicked += (sender, e) =>
            {
                var mi = ((MenuItem)sender);
                var item = (ListItemCustom)mi.CommandParameter;
                Debug.WriteLine("More clicked: " + item.Title.ToString());
            };
            ContextActions.Add(moreAction);

            var deleteAction = new MenuItem { Text = "Delete", IsDestructive=true };
            deleteAction.SetBinding(MenuItem.CommandParameterProperty, new Binding("."));
            deleteAction.Clicked += (sender, e) =>
            {
                var mi = ((MenuItem)sender);
                var item = (ListItemCustom)mi.CommandParameter;
                Debug.WriteLine("Delete clicked on row: " + item.Title.ToString());
            };
            ContextActions.Add(deleteAction);
        }
    }
}
