using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Gastos_Cliente
    {
        [Key]
        public int GastosId { get; set; }
        public double gasto_agua { get; set; }
        public double gasto_luz { get; set; }
        public double gasto_telefono { get; set; }
        public double gasto_internet { get; set; }
        public double gastos_totales { get; set; }

        public bool aprobacion_gastos { get; set; }
        public Cliente_Det Cliente_Det { get; set; }
        public int ClienteDetId { get; set; }

        
    }
}
