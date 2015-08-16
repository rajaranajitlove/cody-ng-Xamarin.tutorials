using System;

using Xamarin.Forms;

namespace XamarinFormDemo
{
    public class PlatformPage : ContentPage
    {
        public PlatformPage ()
        {
            Padding = new Thickness (20, Device.OnPlatform (40, 20, 0), 10, 20);

            var btn = new Button () {
                Text = "Take Picture"
            };

            btn.Clicked += (sender, e) => 
            {
                // take picture
                // at runtime, the dependency service will find the IPictureTaker that has
                // been registered with the corresponding platform.
                IPictureTaker picturetaker = DependencyService.Get<IPictureTaker>();

                picturetaker.SnapPicture ();
            };

            var image = new Image () {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // subscribe to message
            MessagingCenter.Subscribe <IPictureTaker, string>(this, "pictureTaken",
                (sender, arg) =>
                {
                    image.Source = ImageSource.FromFile (arg);
                }
            );

            Content = new StackLayout {
                Spacing = 10,
                Children = {btn, image}
            };
        }
    }
}


