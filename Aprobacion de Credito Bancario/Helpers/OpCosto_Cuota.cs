using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Helpers
{
    public class OpCosto_Cuota
    {
        Costo_Cuota costo_cuota { get; set; }
        
        public  OpCosto_Cuota (Costo_Cuota costo_cuota) {

            this.costo_cuota = costo_cuota;
        
        }

      public double CalCuota(){


            double c = costo_cuota.MontoSolicitado * 12;
            return c;


        }

       /* public double CalAmortizacion ()
        {

        
            double a = CalCuota() - (CalTasaInteres() * co);
            return a;


        }

        public double CalTasaInteres()
        {

            double t = 1 - (Math.Pow((1 + TasaAnual), 1/12));
            return t;


        }
        public double CalPagoMensual()
        {

            double p = CalAmortizacion() + (CalTasaInteres() * MontoSolicitado) + 10F;
            return p;


        }

        public double CalPatrimonio()
        {

            double dp =  MontoSolicitado * 0.04;
            return dp;


        }

        public double CalGastos()
        {

            double ct = gasto_agua + gasto_luz + gasto_internet + gasto_telefono ;
            return ct;


        }

        public bool ApruebaGastos()
        {

            bool ag ;
            ag = gastos_totales > MontoSolicitado ;
            return ag;

        }

        public DateTime CalFecha() { 
        

        
        }*/
    }
}
