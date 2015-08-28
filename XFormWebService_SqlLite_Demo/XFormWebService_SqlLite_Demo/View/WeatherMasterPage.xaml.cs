using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace XFormWebService_SqlLite_Demo
{
    public partial class WeatherMasterPage : ContentPage
    {
        WeatherMasterPageVM _vm;

        public WeatherMasterPage ()
        {
            _vm = new WeatherMasterPageVM ();


            BindingContext = _vm;

            InitializeComponent ();
        }

        protected override void OnAppearing ()
        {
            // set the dynamic style value
            Resources ["ListCount"] = "Number of previous searches: " + _vm.WeatherObservations.Count.ToString () ;


            base.OnAppearing ();
        }


        public void OnItemTapped (object o, ItemTappedEventArgs e)
        {
            var data = e.Item as WeatherObservation;
            Navigation.PushAsync(new WeatherDetailsPage(data));
        }
    }
}

