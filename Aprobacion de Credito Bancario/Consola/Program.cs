using Modelo;
using System;
using Helpers;

namespace Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Cliente
            Modelo.Cliente JoseFlores = new Cliente()
            {
                NombreCliente = "Jose Francisco",
                ApellidoCliente = "Flores Salgado",
                CedulaCliente = "1725236215",
                TelefonoCliente = "123123",
                Garante = new Garante()
                {
                    NombreGarante = "Karla Susana",
                    ApellidoGarante = "Perez Suarez",
                    CedulaGarante = "1725241123",
                    TelefonoGarante = "123123"
                }
            };

            //Cliente Det
            Cliente_Det clienteDetalle = new Cliente_Det()
            {
                AvaluoBienParticular = 15000,
                Deuda_otros_bancos = 3000,
                Gastos_cliente = 150,
                ingreso_mensual_cliente = 800
            };

            Garante_Det garanteDetalle = new Garante_Det()
            {
                AvaluoBienParticular = 20000,
                Deuda_otros_bancos = 1000,
                Gastos_garante = 150,
                ingreso_mensual_garante = 850
            };


            //Historial Cliente
            Historial_Cliente HistorialJoseFlores = new Historial_Cliente() 
            
            { 
                DiasRetrasoCliente = 14, 
                Cliente = JoseFlores, 
                CantidadPagada = 10, 
                CantidadSolicitada = 150, 
                FechaPagoReal = new DateTime (2021,02,15),
                FechaPagoSolicitada= new DateTime(2021, 02, 15), 
                NumeroCuota = 1, 
                Saldo = 140
            };

            Historial_Garante HistorialKarlaPerez = new Historial_Garante()

            {
                DiasRetrasoGarante = 14,
                CantidadPagada = 150,
                CantidadSolicitada = 150,
                FechaPagoReal = new DateTime(2021, 02, 22),
                FechaPagoSolicitada = new DateTime(2021, 02, 22),
                NumeroCuota = 1,
                Saldo = 0
            };

            //Costo Cuota
            

            Costo_Cuota CostoCuota = new Costo_Cuota() 
            { MontoSolicitado = 10000f, 
                NumeroCuotas = 16, 
                
                
            };

            OpCosto_Cuota operacion = new OpCosto_Cuota(CostoCuota);
            operacion.CalCuota();
            CostoCuota.CalculoCuota = operacion.CalCuota();

        }
    }
}
