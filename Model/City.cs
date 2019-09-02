using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Model
{
    public class Country
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
    }


    public class City
    {
        public string Key { get; set; }
        public string LocalizedName { get; set; }
        public Country Country { get; set; }
    }
}
