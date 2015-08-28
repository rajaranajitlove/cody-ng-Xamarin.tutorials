using System;
using Xamarin.Forms;
//using System.ServiceModel.Channels;

namespace XFormWebService_SqlLite_Demo
{
    public class MyViewCell : ViewCell {
        protected override void OnBindingContextChanged() {
            View.BindingContext = BindingContext;
            base.OnBindingContextChanged();
        }
    }
}

