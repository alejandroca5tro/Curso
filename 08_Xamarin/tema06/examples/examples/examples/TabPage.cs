﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace examples
{
    public class TabPage : TabbedPage
    {
        public TabPage()
        {
            Title = "Tabbed Page";
            Children.Add(new HomePage()
            {
                Title="Home Page",
                Icon = "start.png"
            });
            Children.Add(new HomePage()
            {
                Title = "Home Page",
                Icon = "start.png"
            });
            Children.Add(new SecondPage()
            {
                Title = "Home Page",
                Icon = "start.png"
            });
            Children.Add(new ThirdPage()
            {
                Title = "Home Page",
                Icon = "start.png"
            });

        }
    }
}