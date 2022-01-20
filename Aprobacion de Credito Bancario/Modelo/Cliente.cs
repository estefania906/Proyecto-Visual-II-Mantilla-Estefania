using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string CedulaCliente { get; set; }
        public string TelefonoCliente { get; set; }

        //La relacion con declaracion patrimonio cliente
        public List<Cliente_Det> Cliente_Det { get; set; }
        public List<Garante> Garante { get; set; }
        public List<Costo_Cuota> Costo_Cuota { get; set; }

    }
}
