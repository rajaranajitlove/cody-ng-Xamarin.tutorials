using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

using SQLite;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace XFormWebService_SqlLite_Demo
{
    static class DbRepo
    {
        public static readonly Lazy<MySQLiteRepo> _db = 
            new Lazy<MySQLiteRepo> (() => new MySQLiteRepo ());

        public static MySQLiteRepo Get {
            get {
                return _db.Value;
            }
        }
        
    }

    static class DbAsynRepo
    {
        public static async Task<MySQLiteRepoAsync> Get ()
        {
            
            var rep = new MySQLiteRepoAsync ();
            await rep.InitAsync ();

            return rep;

        }

    }
}

