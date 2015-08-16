using System;
using Xamarin.Forms;

namespace XamarinFormDemo
{
	public class FirstContentPage : ContentPage
	{
		public FirstContentPage ()
		{
			var label1 = new Label {
				Text = "My Label",
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
				FontAttributes = FontAttributes.Bold
			};

			var entry1 = new Entry {
				Placeholder = "Please enter something"
			};

			var button1 = new Button {
				Text = "Click Me!"
			};
			button1.Clicked += (sender, e) => {
				label1.Text = "User typed: " + entry1.Text;
			};

			Content = new StackLayout {
				Padding = 30,
				Spacing = 10,
				Children = {label1, entry1, button1}
			};
		}
	}
}

