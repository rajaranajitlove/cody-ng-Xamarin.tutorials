using System;
using Xamarin.Forms;

namespace XFormWebService_SqlLite_Demo
{


    public class ValidateInputInteger_Trigger : TriggerAction<Entry>
    {
        protected override void Invoke (Entry sender)
        {
            int parsed;
            bool valid = int.TryParse (sender.Text, out parsed);
            if (!valid) {
                sender.TextColor = Color.Red;
            } else {
                //sender.TextColor = Color.Black;
            }
        }
    }

}

