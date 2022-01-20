using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Declaracion_Patrimonio_Garante
    {
        [Key]
        public int DeclaracionPatrimonioGaranteId { get; set; }
        public string NombreBien { get; set; }
        public double AvaluoBienParticular { get; set; }
        public double AvaluoBienMunicipio { get; set; }
        public bool CalculoPatrimonioGarante { get; set; }
        public Garante_Det Garante_Det { get; set; }
        public int GaranteDetId { get; set; }


    }
}
