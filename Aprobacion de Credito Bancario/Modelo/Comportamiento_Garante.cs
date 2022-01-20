using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Comportamiento_Garante
    {
        [Key]
        public int ComportamientGaranteId { get; set; }
        public double Deuda_casas_comerciales { get; set; }
        public double Deuda_otras_entidades_financieras { get; set; }
        public bool CalculoDeudasGarante { get; set; }
        public DateTime fecha_deuda { get; set; }
        public Garante_Det Garante_Det { get; set; }
        public int GaranteDetId { get; set; }
     
    }
}
