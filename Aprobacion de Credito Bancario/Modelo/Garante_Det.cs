using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Garante_Det
    {
        [Key]
        public int GaranteDetId { get; set; }
        public Garante Garante { get; set; }
        public int GaranteId { get; set; }
        public List<Declaracion_Patrimonio_Garante> Declaracion_Patrimonio_Garante { get; set; }
        public List<Comportamiento_Garante> Comportamiento_Garante { get; set; }
        public List<Historial_Garante> Historial_Garante { get; set; }

    }
}
