using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFormWebService_SqlLite_Demo
{
    public partial class MainPage : ContentPage
    {
        MainPageVM _vm;
        bool _done = false;

        public MainPage ()
        {
            _vm = new MainPageVM ();
            BindingContext = _vm;

            InitializeComponent ();
        }

        public async void OnClicked (object o, EventArgs e)
        {
            if (string.IsNullOrEmpty (this.Longitude.Text) ||
               string.IsNullOrEmpty (this.Latitude.Text)) {
                await DisplayAlert ("Invalid input", "Must enter both Longitude and Latitude", "Close");
                return;
            }
            var longitude = double.Parse (this.Longitude.Text);
            var latitude = double.Parse (this.Latitude.Text);


            await _vm.GetWeatherAsync (latitude, longitude);

        }

        public async void OnShowAllClicked(Object o, EventArgs e)
        {
            var p = new WeatherMasterPage ();

           
            await Navigation.PushAsync( p);
        }


        protected override void OnAppearing ()
        {
            _done = false;
            Device.StartTimer (TimeSpan.FromSeconds (1), () => {
                Resources ["CurrentTime"] = DateTime.Now.ToString ();
                return (!_done);
            });
            base.OnAppearing ();
        }

        protected override void OnDisappearing ()
        {
            _done = true;
            base.OnDisappearing ();
        }
    }
}

