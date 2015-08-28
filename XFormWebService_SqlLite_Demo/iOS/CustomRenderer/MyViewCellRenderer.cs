using System;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(XFormWebService_SqlLite_Demo.MyViewCell), typeof(XFormWebService_SqlLite_Demo.iOS.MyViewCellRenderer))]

namespace XFormWebService_SqlLite_Demo.iOS {
    public class MyViewCellRenderer : ViewCellRenderer {
        public override UIKit.UITableViewCell GetCell(Xamarin.Forms.Cell item, UIKit.UITableViewCell reusableCell, UIKit.UITableView tv) {
            var cell = base.GetCell(item, reusableCell, tv);

            // this doesn't seem to do anything...am i missing something??
            cell.BackgroundColor = UIColor.Red;
            return cell;
        }

    }
}

