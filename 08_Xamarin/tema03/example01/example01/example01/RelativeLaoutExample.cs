using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace example01
{
    class RelativeLaoutExample : ContentPage
    {
        int m1 = 6;
        int m2 = 10;

        public RelativeLaoutExample()
        {
            RelativeLayout relativeLayout = new RelativeLayout();
            Label upperLeft = new Label
            {
                Text = "Upper Left",
                FontSize = 20
            };
            relativeLayout.Children.Add(upperLeft, Constraint.Constant(m1), Constraint.Constant(m2));

            Label below = new Label
            {
                Text = " Below Upper Left",
                FontSize = 15
            };

            relativeLayout.Children.Add(below, Constraint.Constant(m1), Constraint.Constant(m2));

            Content = relativeLayout;
        }
    }
}
