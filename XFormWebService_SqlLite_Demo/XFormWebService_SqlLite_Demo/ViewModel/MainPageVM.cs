using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace XFormWebService_SqlLite_Demo
{
    public class MainPageVM : INotifyPropertyChanged
    {
        public MainPageVM ()
        {
        }

        #region properties

        string _station;

        public string StationName {
            get{ return _station; }
            set {
                _station = value;
                NotifyPropertyChanged ();
            }
        }

        string _elevation;

        public string Elevation {
            get{ return _elevation; }
            set {
                _elevation = value;
                NotifyPropertyChanged ();
            }
        }

        string _temperature;

        public string Temperature {
            get{ return _temperature; }
            set {
                _temperature = value;
                NotifyPropertyChanged ();
            }
        }

        string _humidity;

        public string Humidity {
            get{ return _humidity; }
            set {
                _humidity = value;
                NotifyPropertyChanged ();
            }
        }

        #endregion

        string GetWeatherUrl(double latitude, double longitude)
        {
            var username = "demo";
            var urlFormat = "http://api.geonames.org/findNearByWeatherJSON?lat={0}&lng={1}&username={2}";
            var url = string.Format (urlFormat, latitude, longitude, username);

            return url;
        }

        public async Task GetWeatherAsync (double latitude, double longitude)
        {
            var url = GetWeatherUrl ( latitude, longitude);

            HttpClient client = new HttpClient ();
            client.BaseAddress = new Uri (url);

            var response = await client.GetAsync (client.BaseAddress);

            response.EnsureSuccessStatusCode ();

            var jsonResult = response.Content.ReadAsStringAsync ().Result;
            var weather = JsonConvert.DeserializeObject<WeatherResult> (jsonResult);

            if (weather != null &&
               weather.weatherObservation != null) {
                SetValues (weather);

                var w = weather.weatherObservation;
              
                //SaveDb (w);
                await SaveDbAsync (w);
            }
        }

        void SaveDb(WeatherObservation w)
        {
             var db = DbRepo.Get;

            var observation = db.GetWeatherObservation (w.Lng, w.Lat);
            if (observation == null) {
                w.TimeStamp = DateTime.Now;
                db.SaveWeatherObservation (w);
            }
        }

        async Task SaveDbAsync(WeatherObservation w)
        {
            var db = await DbAsynRepo.Get();

            var observation = await db.GetWeatherObservation (w.Lng, w.Lat);
            if (observation == null) {
                w.TimeStamp = DateTime.Now;
                await db.SaveWeatherObservation (w);
            }
        }

        void SetValues(WeatherResult weather)
        {
            this.StationName = weather.weatherObservation.StationName;
            this.Elevation = weather.weatherObservation.Elevation.ToString ();
            this.Temperature = weather.weatherObservation.Temperature.ToString ();
            this.Humidity = weather.weatherObservation.Humidity.ToString ();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void NotifyPropertyChanged ([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null) {
                PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
            }
        }
    }
}

