using System;
using System.Linq;

using Xamarin.Forms;

namespace XamarinFormDemo
{
    public class PersonMasterDetailPage : MasterDetailPage
    {
        public PersonMasterDetailPage ()
        {

            var lv = new ListView ();
            lv.ItemsSource = PersonEx.Get ();

            lv.ItemSelected += (sender, e) => {
                if( e.SelectedItem != null )
                {
                    // set up the detail page
                    Detail = new PersonExPage(e.SelectedItem as PersonEx);

                    // ... and to hide the master page
                    IsPresented = false;
                }
            };

            Master = new ContentPage {
                Title = "Person",
                Content = lv
            };

            Detail = new PersonExPage (PersonEx.Get ().First ());
        }
    }
}


