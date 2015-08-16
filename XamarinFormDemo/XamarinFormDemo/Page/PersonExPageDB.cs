using System;

using Xamarin.Forms;

namespace XamarinFormDemo
{
    // copied from PersonExPage.cs for databinding
    public class PersonExPageDB : ContentPage
    {
        public PersonExPageDB ()
        {
            Padding = new Thickness (10, Device.OnPlatform (20, 0, 0), 10, 0);
            BackgroundColor = Color.Gray;

            //Title = person.NickName;
            this.SetBinding (ContentPage.TitleProperty, "NickName");

            var lbName = new Label () {
                //Text = person.Name,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };
            lbName.SetBinding (Label.TextProperty, "Name");

            var lbAge = new Label () {
                //Text = person.Age.ToString(),
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
            };
            lbAge.SetBinding (Label.TextProperty, "Age");

            var lbBio = new Label () {
                //Text = person.Biography,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
            };
            lbBio.SetBinding (Label.TextProperty, "Biography");

            Content = new ScrollView {
                Content = new StackLayout{
                    Spacing = 10,
                    Children = {lbName, lbAge, lbBio}
                }
            };
        }
    }
}


