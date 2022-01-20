using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Declaracion_Patrimonio_Cliente
    {
        [Key]
        public int  DeclaracionPatrimonioClienteId { get; set; }
        public string NombreBien { get; set; }
        public double AvaluoBienParticular { get; set; }
        public double AvaluoBienMunicipio { get; set; }
        public bool CalculoPatrimonioCliente { get; set; }
        public Cliente_Det Cliente_Det { get; set; }
        public int ClienteDetId { get; set; }


    }
}
