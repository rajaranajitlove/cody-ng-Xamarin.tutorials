using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Media;
using Xamarin.Forms;

// registers the class that implements IPictureTaker for runtime, so Xamarin knows to load this class for Android
[assembly: Dependency(typeof(XamarinFormDemo.Droid.MainActivity))]


namespace XamarinFormDemo.Droid
{
    [Activity (Label = "XamarinFormDemo.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity, IPictureTaker
    {
        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate (bundle);

            global::Xamarin.Forms.Forms.Init (this, bundle);

            LoadApplication (new App ());
        }

        protected override async void OnActivityResult (int requestCode, Result resultCode, Intent data)
        {
            if (resultCode == Result.Canceled)
                return;

            var mediaFile = await data.GetMediaFileExtraAsync (Forms.Context); // asynchronous
            System.Diagnostics.Debug.WriteLine (mediaFile.Path);

            // send message
            MessagingCenter.Send<IPictureTaker, string>(this, "pictureTaken", mediaFile.Path);

        }

        #region IPictureTaker implementation

        public void SnapPicture ()
        {
            var activity = Forms.Context as Activity;

            var picker = new MediaPicker (activity);

            var intent = picker.GetTakePhotoUI (new StoreCameraMediaOptions {
                Name = "test.jpg",
                Directory = "TestDirectory"
            });

            activity.StartActivityForResult (intent, 1);

        }

        #endregion
    }
}

