using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente_Det
    {
        [Key]
        public int ClienteDetId { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public List<Declaracion_Patrimonio_Cliente> Declaracion_Patrimonio_Cliente { get; set; }
        public List<Comportamiento_Cliente> Comportamiento_Cliente { get; set; }
        public List<Historial_Cliente> Historial_Cliente { get; set; }
        public List<Gastos_Cliente> Gasto_Cliente { get; set; }
        public List<Costo_Cuota> Costo_Cuota { get; set; }


    }
}
