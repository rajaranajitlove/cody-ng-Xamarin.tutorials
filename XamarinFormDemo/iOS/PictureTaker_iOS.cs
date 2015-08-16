using System;
using System.Diagnostics;

using Xamarin.Media;
using Xamarin.Forms;

using XamarinFormDemo;

// registers the class that implements IPictureTaker for runtime, so Xamarin knows to load this class for iOS
[assembly: Dependency(typeof(XamarinFormDemo.iOS.PictureTaker_iOS))]

namespace XamarinFormDemo.iOS
{
    public class PictureTaker_iOS : IPictureTaker
    {
        public async void SnapPicture ()
        {
            var picker = new MediaPicker ();

            var mediaFile = await picker.PickPhotoAsync (); // this asynchronous
            Debug.WriteLine (mediaFile.Path);

            // send message
            MessagingCenter.Send<IPictureTaker, string>(this, "pictureTaken", mediaFile.Path);

        }
    }
}

