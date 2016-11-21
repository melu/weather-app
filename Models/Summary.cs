using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace weather_app.Models
{
    public class Summary
    {
        public int items { get; set; }
        public int items_per_page { get; set; }
        public int pages { get; set; }
        public int current_page { get; set; }
    }
}