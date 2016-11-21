using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace weather_app.Models
{
    public class ResponseSensor
    {
            public Summary summary { get; set; }
            public List<Mark> resources { get; set; }
    }
}