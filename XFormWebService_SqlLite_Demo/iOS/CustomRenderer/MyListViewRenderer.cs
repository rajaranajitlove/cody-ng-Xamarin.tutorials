using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(XFormWebService_SqlLite_Demo.MyListView), typeof(XFormWebService_SqlLite_Demo.iOS.MyListViewRenderer))]

namespace XFormWebService_SqlLite_Demo.iOS {
    public class MyListViewRenderer : ListViewRenderer {
        protected override void OnElementChanged(ElementChangedEventArgs<ListView> e) {
            base.OnElementChanged(e);
            if (Control != null) {
                Control.SeparatorColor = UIKit.UIColor.Red;
            }
        }

    }
}

