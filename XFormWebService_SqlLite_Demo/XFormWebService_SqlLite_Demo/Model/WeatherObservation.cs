using System;

namespace XFormWebService_SqlLite_Demo
{
    public class WeatherObservation
    {
        public string WeatherCondition{ get; set; }

        public long Elevation{ get; set; }

        public string CountryCode { get; set; }

        public string CloudCode { get; set; }

        public long Longitude { get; set; }

        public long Temperature { get; set; }

        public long DewPoint{ get; set; }

        public long WindSpeed{ get; set; }

        public long Humidity{ get; set; }

        public string StationName{ get; set; }

        public DateTime TimeStamp { get; set; }

        public long Latitude { get; set; }

        public long HectoPascAltimeter { get; set; }


        
    }
}
