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
           


        public void OnItemTapped(object o, EventArgs e)
        {
        }
    }
}

