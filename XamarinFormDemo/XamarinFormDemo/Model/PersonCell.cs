using System;
using Xamarin.Forms;

namespace XamarinFormDemo
{
    public class PersonCell : ViewCell
    {
        public PersonCell ()
        {
            var nameLabel = new Label(){     
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontAttributes = FontAttributes.Bold
            };
            nameLabel.SetBinding (Label.TextProperty, new Binding("Name") );

            var ageLabel = new Label(){
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                XAlign = TextAlignment.End,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            ageLabel.SetBinding (Label.TextProperty, new Binding("Age") );

            View = new StackLayout {
                Children = {nameLabel, ageLabel},
                Orientation = StackOrientation.Horizontal
            };

        }
    }
}

