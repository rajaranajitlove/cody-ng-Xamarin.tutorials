using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFormWebService_SqlLite_Demo
{
    public partial class MainPage : ContentPage
    {
        MainPageVM _vm;

        public MainPage ()
        {
            _vm = new MainPageVM ();
            BindingContext = _vm;

            InitializeComponent ();
        }

        public async void OnClicked(object o, EventArgs e){
            var longitude = double.Parse (this.Longitude.Text);
            var latitude = double.Parse (this.Latitude.Text);

            var username = "demo";
            var urlFormat = "http://api.geonames.org/findNearByWeatherJSON?lat={0}&lng={1}&username={2}";

            var url = string.Format (urlFormat, latitude, longitude, username);

            await _vm.GetWeatherAsync (url);

        }
    }
}

