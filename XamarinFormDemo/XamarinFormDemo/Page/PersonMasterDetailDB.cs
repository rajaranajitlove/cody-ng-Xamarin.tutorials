using System;
using System.Linq;

using Xamarin.Forms;

namespace XamarinFormDemo
{
    // copied from PersonMasterDetailPage.cs for databinding
    public class PersonMasterDetailDB : MasterDetailPage
    {
        public PersonMasterDetailDB ()
        {

            var lv = new ListView ();
            lv.ItemsSource = PersonEx.Get ();

            lv.ItemSelected += (sender, e) => {
                if( e.SelectedItem != null )
                {
                    // set up the detail page
                    //Detail = new PersonExPageDB(e.SelectedItem as PersonEx); remove this
                    Detail.BindingContext = e.SelectedItem; // *** databinding ***


                    // ... and to hide the master page
                    IsPresented = false;
                }
            };

            Master = new ContentPage {
                Title = "Person",
                Content = lv
            };

            Detail = new PersonExPageDB ();
            Detail.BindingContext = PersonEx.Get ().First (); // *** databinding ***
        }
    }
}


