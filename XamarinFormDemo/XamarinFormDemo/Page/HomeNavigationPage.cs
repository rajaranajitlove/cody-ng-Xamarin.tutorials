using System;
using System.Linq;

using Xamarin.Forms;

namespace XamarinFormDemo
{
    public class HomeNavigationPage : ContentPage
    {
        public HomeNavigationPage ()
        {
            Padding = new Thickness (10, Device.OnPlatform (20, 0, 0), 10, 0);
            Title = "Pages";

            var btn1 = new Button (){ Text = "Person's Page" };
            btn1.Clicked += (object sender, EventArgs e)  => 
            {
                Navigation.PushAsync ( new PersonExPage(PersonEx.Get ().First() ) );
            };

            var btn2 = new Button (){ Text = "Master/Detail" };
            btn2.Clicked += (object sender, EventArgs e)  => 
            {
                Navigation.PushAsync ( new PersonMasterDetailPage() );
            };

            var btn3 = new Button (){ Text = "" };
            btn3.Clicked += (object sender, EventArgs e)  => 
            {
            };

            var btn4 = new Button (){ Text = "" };
            btn4.Clicked += (object sender, EventArgs e)  => 
            {
            };

            Content = new StackLayout { 
                Spacing = 10,
                Children = {btn1, btn2, btn3, btn4}   
            };
        }
    }
}


