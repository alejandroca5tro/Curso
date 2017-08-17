using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _17julio._2
{
    class Relative:ContentPage
    {
        public Relative()
        {
            RelativeLayout relativeLayout = new RelativeLayout();
            Label upperLeft = new Label
            {
                Text ="Upper Left",
                FontSize=20

            };
            relativeLayout.Children.Add(upperLeft,
                Constraint.Constant(0), Constraint.Constant(0));
            Label below = new Label
            {
                Text="Below Upper Left",
                FontSize=15
            };
            relativeLayout.Children.Add(below,Constraint.Constant(0),
                Constraint.RelativeToView(upperLeft, (parent, sibling)=>
                {
                    return sibling.Y + sibling.Height;

            }));

            Label contantLabel = new Label
            {
                Text = "Constant are absolute",
                FontSize = 20
            };
            relativeLayout.Children.Add(contantLabel,
                Constraint.Constant(100),
                Constraint.Constant(100),
                Constraint.Constant(50),
                Constraint.Constant(200));

            Label halfwayDown = new Label
            {
                Text="un estado relativo al parent",
                FontSize=15
            };
            relativeLayout.Children.Add(halfwayDown, Constraint.RelativeToParent((parent) =>
                 {
                     return parent.Width / 2;
                 }),
            Constraint.RelativeToParent((parent) =>
            {
                return parent.Height / 2;
            }));
            BoxView box = new BoxView
            {
                Color=Color.Accent,
                HorizontalOptions=LayoutOptions.Start,
                VerticalOptions=LayoutOptions.StartAndExpand
            };
            relativeLayout.Children.Add(box, Constraint.Constant(10),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height / 2;

                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width / 2;
                }));

            Content = relativeLayout;
        }
    }
}
