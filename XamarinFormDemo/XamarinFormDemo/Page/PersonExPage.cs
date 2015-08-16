using System;

using Xamarin.Forms;

namespace XamarinFormDemo
{
    public class PersonExPage : ContentPage
    {
        public PersonExPage (PersonEx person)
        {
            Padding = new Thickness (10, Device.OnPlatform (20, 0, 0), 10, 0);
            BackgroundColor = Color.Gray;

            Title = person.NickName;

            var lbName = new Label () {
                Text = person.Name,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };

            var lbAge = new Label () {
                Text = person.Age.ToString(),
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
            };
            var lbBio = new Label () {
                Text = person.Biography,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
            };

            Content = new ScrollView {
                Content = new StackLayout{
                    Spacing = 10,
                    Children = {lbName, lbAge, lbBio}
                }
            };
        }
    }
}


