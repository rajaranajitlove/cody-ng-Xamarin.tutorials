using System;
using System.IO;
using Xamarin.Forms;

using XFormWebService_SqlLite_Demo.iOS;

[assembly: Dependency (typeof(SQLite_iOS))]
namespace XFormWebService_SqlLite_Demo.iOS
{

    public class SQLite_iOS : ISQLite
    {
        public SQLite_iOS ()
        {
        }

        string Path
        {
            get{ return "/Users/cody/Projects/Xamarin/XFormWebService_SqlLite_Demo/weather.db"; }
        }

        string Path2
        {
            get{ return "/Users/cody/Projects/Xamarin/XFormWebService_SqlLite_Demo/weatherAsyn.db"; }
        }

        public SQLite.SQLiteConnection GetConnection ()
        {
            //              var sqliteFilename = "Contact.db";
            //              string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal); // Documents folder
            //              string libraryPath = Path.Combine (documentsPath, "..", "Library"); // Library folder
            //              var path = Path.Combine(libraryPath, sqliteFilename);

            //var path = "weather.db";
            var path = this.Path;


            var conn = new SQLite.SQLiteConnection (path);

            return conn;
        }

        public SQLite.SQLiteAsyncConnection GetAsyncConnection ()
        {
            var path = this.Path2;


            var conn = new SQLite.SQLiteAsyncConnection (path);

            return conn;
        }


    }
}

