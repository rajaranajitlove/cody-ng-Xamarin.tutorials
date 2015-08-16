using System;
using System.Linq;

using Xamarin.Forms;

namespace XamarinFormDemo
{
    public class App : Application
    {
        public App ()
        {
            // --- form view ---
            //MainPage = new FirstContentPage();
            //MainPage = new FirstXamlPage();
            MainPage = new FirstListViewPage(FirstListViewPage.ViewType.CustomType_CustomCell);

            // --- form layout ---
            //MainPage = new XamlStackLayoutPage();
            //MainPage = new XamlScrollViewPage();
            //MainPage = new XamlAbsoluteLayoutPage();
            //MainPage = new RelativeLayoutPage();

            // --- form page ---
            MainPage = new NavigationPage( new HomeNavigationPage() );
        }

        protected override void OnStart ()
        {
            // Handle when your app starts
        }

        protected override void OnSleep ()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume ()
        {
            // Handle when your app resumes
        }
    }
}

