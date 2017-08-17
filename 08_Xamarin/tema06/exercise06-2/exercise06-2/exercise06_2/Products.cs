using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace exercise06_2
{
    public class Products : ContentPage
    {
        public class ListProduct
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
        }

        public Products()
        {
            Title = "Listado de Productos";

            Image logoCarrefour = new Image
            {
                Source = "carrefour.jpg",
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill
            };

            ListView productsListView = new ListView()
            {
                ItemTemplate = new DataTemplate(typeof(ViewCell))
                {
                    Bindings =
                    {
                        new StackLayout
                        {
                            Children =
                            {
                                new Label
                                {
                                    BindingContext = "Name",
                                }
                            }
                        }                                       
                    }
                }
            };

            List<ListProduct> productList = new List<ListProduct>
            {
                new ListProduct
                {
                    Name = "X65",
                    Description = "hp doble núcleo",
                    Price = "545.0€"
                },
                new ListProduct
                {
                    Name = "XM23",
                    Description = "hp pavilion 65",
                    Price = "645.5€"
                },
                new ListProduct
                {
                    Name = "XN32",
                    Description = "hp 76 HD-SOLID",
                    Price = "760.9€"
                }
            };

            productsListView.ItemsSource = productList;

            StackLayout mainSL = new StackLayout
            {
                Children =
                {
                    logoCarrefour, 
                    productsListView
                }
            };

            Content = mainSL;
        }
    }
}