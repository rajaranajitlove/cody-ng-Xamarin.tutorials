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
    class MySQLiteRepoAsync
    {
        SQLiteAsyncConnection _conn;


        public MySQLiteRepoAsync ()
        {
            _conn = DependencyService.Get<ISQLite> ().GetAsyncConnection ();

            //var tbl = _conn.GetTableInfo ("WeatherObservation");

            //if (tbl.Count == 0) {


            //}
        }

        public async Task InitAsync ()
        {
            await _conn.CreateTableAsync<WeatherObservation> ();
        }

        public async Task<int> SaveWeatherObservation (WeatherObservation w)
        {

            if (w.ID != 0) {
                await _conn.UpdateAsync (w);
                return w.ID;
            } else {
                return await _conn.InsertAsync (w);
            }
        }

        public async Task<IEnumerable<WeatherObservation>> GetWeatherObservation ()
        {

            return  await _conn.Table<WeatherObservation> ().ToListAsync ();
                
            
        }

        public async Task<WeatherObservation> GetWeatherObservation (int id)
        {
            return await _conn.Table<WeatherObservation> ().Where (c => c.ID == id).FirstOrDefaultAsync ();
        }

        public async Task<WeatherObservation> GetWeatherObservation (long lng, long lat)
        {
            return await _conn.Table<WeatherObservation> ()
                    .Where (c => c.Lng == lng && c.Lat == lat)
                    .FirstOrDefaultAsync ();
        }

        public async Task<int> DeleteWeatherObservation (int id)
        {
            return await _conn.DeleteAsync (id);
        }
    }
}




