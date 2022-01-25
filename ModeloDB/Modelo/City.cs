using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class City
    {
        [Key]
        public int city_id { get; set; }

        public string city { get; set; }

        public DateTime last_update { get; set; }

        public Country Country { get; set; }
        public int country_id { get; set; }

        public List<Address> Address { get; set; }
    }
}
