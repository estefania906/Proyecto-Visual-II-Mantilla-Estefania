using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Historial_Cliente
    {
        [Key]
        public int HistorialClienteId { get; set; }
        public double NumeroCuota { get; set; }
        public DateTime FechaPagoReal { get; set; }
        public DateTime FechaPagoSolicitada { get; set; }
        public double CantidadPagada { get; set; }
        public double CantidadSolicitada { get; set; }
        public double Saldo { get; set; }
        public bool DiasRetrasoCliente { get; set; }

        public Cliente_Det Cliente_Det { get; set; }
        public int ClienteDetId { get; set; }

    }
}
