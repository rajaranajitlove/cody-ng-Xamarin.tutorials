using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormDemo
{
    public partial class FirstXamlPage : ContentPage
    {
        public FirstXamlPage ()
        {
            InitializeComponent ();
        }

        void OnColorSliderChanged(Object sender, EventArgs e)
        {
            var red = sliderRed.Value;
            var green = sliderGreen.Value;
            var blue = sliderBlue.Value;

            boxviewColor.Color = Color.FromRgb (red, green, blue);
        }
    }
}

