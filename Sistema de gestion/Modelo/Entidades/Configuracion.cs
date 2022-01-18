using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.NewFolder
{
    public class Configuracion
    {
        public int CreditoMaximo { get; set }
        public string EscuelaNombre { get; set }
        public float NotaMaxima { get; set }

        //La relacion con periodos 
        public Periodo PeriodoVigente { get; set }
        
        public int PeriodoId { get; set }
        public float PesoNota1 { get; set }
        public float PesoNota2 { get; set }
        public float PesoNota3 { get; set }


    }
}
