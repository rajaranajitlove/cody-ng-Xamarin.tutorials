using System;

using Xamarin.Forms;

namespace XamarinFormDemo
{
    public class RelativeLayoutPage : ContentPage
    {
        public RelativeLayoutPage ()
        {

            var layout = new RelativeLayout ();

            var label1 = new Label () {
                Text = "label-1"
            };

            layout.Children.Add (label1,
                Constraint.Constant (0),
                Constraint.RelativeToParent ( parent =>
                    {
                        return parent.Height /2;
                    })
            );

            // relative to another view
            var label2 = new Label () {
                Text = "label-2 relative to label-1"
            };

            layout.Children.Add (label2,
                Constraint.RelativeToView (label1, (parent, otherView) =>
                    {
                        return otherView.X + otherView.Width;
                    }),
                Constraint.RelativeToView (label1, (Parent, otherView) =>
                    {
                        return otherView.Y - otherView.Height; // above
                        //return otherView.Y + otherView.Height; // below
                        //return otherView.Y; // same height
                    })
            );

            var label3 = new Label () {
                Text = "label-3"
            };

            // *** caution ***
            // Want to right-aligned label-3 with label-2
            layout.Children.Add (label3,
                Constraint.RelativeToView (label2, (parent, otherView) =>
                    {
                        // *** caution ***
                        // label3.Width is unknown at this time, because the layout
                        // calculates label-3's sizes in the process of adding it.
                        return (otherView.X + otherView.Width) - label3.Width;
                    }),
                Constraint.RelativeToView (label1, (Parent, otherView) =>
                    {
                        return otherView.Y; // same height
                    })
            );
            // *** this step is required to fix label-3's width problem ***
            label3.SizeChanged += (o, e) => {layout.ForceLayout (); };


            Content = layout;
        }
    }
}


