using System;
using SQLite;

namespace XFormWebService_SqlLite_Demo
{
    public class WeatherObservation
    {
        [PrimaryKeyAttribute, AutoIncrement]
        public int ID { get; set; }

        public string WeatherCondition{ get; set; }

        public long Elevation{ get; set; }

        public string CountryCode { get; set; }

        public string CloudCode { get; set; }

        public long Lng { get; set; }

        public long Temperature { get; set; }

        public long DewPoint{ get; set; }

        public long WindSpeed{ get; set; }

        public long Humidity{ get; set; }

        public string StationName{ get; set; }

        public DateTime TimeStamp { get; set; }

        public long Lat { get; set; }

        public long HectoPascAltimeter { get; set; }


        
    }
}
