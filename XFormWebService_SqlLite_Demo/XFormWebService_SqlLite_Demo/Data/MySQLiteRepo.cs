using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

using SQLite;
using Xamarin.Forms;

namespace XFormWebService_SqlLite_Demo
{
    public class MySQLiteRepo
    {
        SQLiteConnection _conn;
        static object _locker = new object();

        public MySQLiteRepo ()
        {
            _conn = DependencyService.Get<ISQLite> ().GetConnection ();

            var tbl = _conn.GetTableInfo ("WeatherObservation");

            if (tbl.Count == 0) {
                _conn.CreateTable<WeatherObservation> ();
            }
        }

        public int SaveWeatherObservation(WeatherObservation w) {
            lock (_locker) {
                if (w.ID != 0) {
                    _conn.Update(w);
                    return w.ID;
                } else {
                    return _conn.Insert(w);
                }
            }
        }

        public IEnumerable<WeatherObservation> GetWeatherObservation() {
            lock (_locker) {
                return (from c in _conn.Table<WeatherObservation>()
                    select c).ToList();
            }
        }

        public WeatherObservation GetWeatherObservation(int id) {
            lock (_locker) {
                return _conn.Table<WeatherObservation>().Where(c => c.ID == id).FirstOrDefault();
            }
        }

        public WeatherObservation GetWeatherObservation(long lng, long lat) {
            lock (_locker) {
                return _conn.Table<WeatherObservation>()
                    .Where(c => c.Lng == lng && c.Lat == lat)
                    .FirstOrDefault();
            }
        }

        public int DeleteWeatherObservation(int id) {
            lock (_locker) {
                return _conn.Delete<WeatherObservation>(id);
            }
        }
    }
}


