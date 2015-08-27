using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XFormWebService_SqlLite_Demo
{
    public class WeatherMasterPageVM
    {
        List<WeatherObservation> _data;

        public List<WeatherObservation> WeatherObservations {
            get {
                return _data;
            }
        }

        public WeatherMasterPageVM ()
        {
            var t = Task.Run ( async() => await Init() );
            t.Wait ();
        }

        public async Task Init ()
        { 
            var db = await DbAsynRepo.Get ().ConfigureAwait (false);

            _data = await db.GetWeatherObservations ().ConfigureAwait (false);

        }


    }
}

