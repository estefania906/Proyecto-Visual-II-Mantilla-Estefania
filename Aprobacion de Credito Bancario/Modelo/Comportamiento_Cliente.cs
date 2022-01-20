using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Comportamiento_Cliente
    {
        [Key]
        public int ComportamientClienteId { get; set; }
        public double Deuda_casas_comerciales { get; set; }
        public double Deuda_otras_entidades_financieras { get; set; }
        public DateTime fecha_deuda { get; set; }
        public bool CalculoDeudasCliente { get; set; }
        public Cliente_Det Cliente_Det { get; set; }
        public int ClienteDetId { get; set; }
      


    }
}
