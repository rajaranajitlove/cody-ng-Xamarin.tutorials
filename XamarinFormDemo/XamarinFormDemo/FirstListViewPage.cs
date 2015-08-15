using System;
using System.Diagnostics;
using System.Linq;

using Xamarin.Forms;

namespace XamarinFormDemo
{
	public class FirstListViewPage : ContentPage
	{
        public enum ViewType
        {
            SimpleType,
            CustomType,
            CustomType_CustomCell
        };

        public FirstListViewPage (ViewType viewType)
		{

			//Padding = new Thickness (0, 20, 0, 0);

			// platform-specific value
			Padding = new Thickness (0, Device.OnPlatform(20,0,0), 0, 0);

            var lv = new ListView ();

            switch (viewType) {
            case ViewType.SimpleType:
                Init_SimpleDataType(lv);
                break;
            case ViewType.CustomType:
                Init_CustomData(lv);
                break;
            case ViewType.CustomType_CustomCell:
                Init_CustomData_CustomCell (lv);
                break;
            }
           

			lv.ItemSelected += (sender, e) =>  
			{
				if( e.SelectedItem != null)
				{
					Debug.WriteLine("Selected: " + e.SelectedItem );
					lv.SelectedItem = null; // clear selection
				}
			};

			Content = lv;
		}

        void Init_CustomData_CustomCell(ListView lv)
        {
            lv.ItemsSource = Person.Get();

            // custom cell class display
            var cell = new DataTemplate (typeof(PersonCell));

            lv.ItemTemplate = cell;
        }

        void Init_CustomData(ListView lv)
        {
            lv.ItemsSource = Person.Get();

            // multi-line display
            var cell = new DataTemplate (typeof(TextCell));
            cell.SetBinding (TextCell.TextProperty, new Binding ("Name"));
            cell.SetBinding (TextCell.DetailProperty, new Binding ("Age"));
            cell.SetValue (TextCell.TextColorProperty, Color.Red);
            cell.SetValue (TextCell.DetailColorProperty, Color.Blue);

            lv.ItemTemplate = cell;
        }

        void Init_SimpleDataType(ListView lv)
		{
			var names = new[] {
				"Joe",
				"Mary",
				"Sam",
				"Gary",
				"Gilbert",
				"Gerry"
			};

//			var result = 
//				(from n in names
//					     where  n.StartsWith ("G")
//				         select n
//			).ToArray();
//          return result;

            lv.ItemsSource = names;
            //lv.ItemsSource = result;


            var cell = new DataTemplate (typeof(TextCell));
            cell.SetBinding (TextCell.TextProperty, new Binding ("."));
            cell.SetValue (TextCell.TextColorProperty, Color.Red);

            lv.ItemTemplate = cell;
		}
	}
}


