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

            var btn3 = new Button (){ Text = "Master/Detail (binding)" };
            btn3.Clicked += (object sender, EventArgs e)  => 
            {
                Navigation.PushAsync (new PersonMasterDetailDB() );
            };

            var btn4 = new Button (){ Text = "Tabbed" };
            btn4.Clicked += (object sender, EventArgs e)  => 
            {
                var tabpage = new TabbedPage ();
                tabpage.Title = "Persons";
                foreach(var p in PersonEx.Get ())
                {
                    var page = new PersonExPageDB ();
                    page.BindingContext = p;
                    tabpage.Children.Add (page);
                }

                Navigation.PushAsync (tabpage);
            };

            var btn5 = new Button (){ Text = "Carousel" };
            btn5.Clicked += (object sender, EventArgs e)  => 
            {
                var tabpage = new CarouselPage ();
                tabpage.Title = "Persons";
                foreach(var p in PersonEx.Get ())
                {
                    var page = new PersonExPageDB ();
                    page.BindingContext = p;
                    tabpage.Children.Add (page);
                }

                Navigation.PushAsync (tabpage);                
            };

            Content = new StackLayout { 
                Spacing = 10,
                Children = {btn1, btn2, btn3, btn4, btn5}   
            };
        }
    }
}


