using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Address
    {
        [Key]
        public int address_id { get; set; }

        public string address { get; set; }

        public string address2 { get; set; }

        public string district { get; set; }

        public string postal_code { get; set; }

        public string phone { get; set; }

        public DateTime last_update { get; set; }

        public City City { get; set; }
        public int city_id { get; set; }
    }
}
