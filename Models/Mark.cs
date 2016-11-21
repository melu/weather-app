using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;


namespace weather_app.Models
{
    [DataContract]
    public class Mark
    {
        [DataMember(Name="ayto:latitude")]
        private float? latitude;

        [DataMember(Name="ayto:longitude")]
        private float? longitude;

        [DataMember(Name="ayto:temperature")]
        private float? temperature;

        [DataMember(Name="uri")]
        private string uri { get; set; }

        public Mark()
        {
        }

        public Mark(float lat, float lon, float temp){
            this.latitude = lat;
            this.longitude = lon;
            this.temperature = temp;
        }
    }
}
