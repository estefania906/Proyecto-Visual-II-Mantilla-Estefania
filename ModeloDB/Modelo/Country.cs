using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Country
    {
        [Key]
        public int country_id { get; set; }

        public string country { get; set; }

        public DateTime last_update { get; set; }

        public List<City> City { get; set; }
    }
}
