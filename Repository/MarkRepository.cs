using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using weather_app.Models;

namespace weather_app.Repository
{
    public class MarkRepository
    {
        public MarkRepository()
        {

        }

        public IEnumerable<Mark> GetAll(){
            var url = "http://datos.santander.es/api/rest/datasets/sensores_smart_env_monitoring.json?items=651";
            var retValue = new List<Mark>();
            using(var client = new HttpClient()){
                //client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(url).Result;

                if(response.IsSuccessStatusCode){
                    var res = response.Content.ReadAsAsync<ResponseSensor>().Result;
                    retValue = res.resources;
                }

            }

            return retValue;
        }
    }
}
