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


            await _vm.GetWeatherAsync ( latitude, longitude);

        }
    }
}

