using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFormWebService_SqlLite_Demo
{
    public partial class WeatherDetailsPage : ContentPage
    {
        public WeatherDetailsPage (WeatherObservation data)
        {
            BindingContext = data;
            InitializeComponent ();
        }
    }
}

