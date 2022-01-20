using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ModeloDB
{
    class ModeloDB : DbContext
    {
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Cliente_Det> cliente_det { get; set; }
        public DbSet<Comportamiento_Cliente> comportamiento_cliente { get; set; }
        public DbSet<Comportamiento_Garante> comportamiento_garante { get; set; }

        public DbSet<Costo_Cuota> costo_cuota { get; set; }
        public DbSet<Declaracion_Patrimonio_Cliente> declaracion_cliente { get; set; }

        public DbSet<Declaracion_Patrimonio_Garante> declaracion_garante { get; set; }
        public DbSet<Garante> garante { get; set; }
        public DbSet<Garante_Det> garante_det { get; set; }
        public DbSet<Gastos_Cliente> gastos_cliente { get; set; }

        public DbSet<Historial_Cliente> historial_cliente { get; set; }

        public DbSet<Historial_Garante> historial_garante { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder options)

        {
            options.UseSqlServer("Server = ACER\\MSSQLSERVER2; initial catalog= Credito ; trusted_connection=true;");
        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cliente_Det
            modelBuilder.Entity<Cliente_Det>()
                .HasOne(cliente_det => cliente_det.Cliente)
                .WithMany(cliente => cliente.Cliente_Det)
                .HasForeignKey(cliente_det => cliente_det.ClienteId);

            // Comportamiento Cliente
            modelBuilder.Entity<Comportamiento_Cliente>()
                .HasOne(comportamiento_cliente => comportamiento_cliente.Cliente_Det)
                .WithMany(cliente_det => cliente_det.Comportamiento_Cliente)
                .HasForeignKey(comportamiento_cliente => comportamiento_cliente.ClienteDetId);

            // Declaracion Cliente
            modelBuilder.Entity<Declaracion_Patrimonio_Cliente>()
                .HasOne(declaracion_cliente => declaracion_cliente.Cliente_Det)
                .WithMany(cliente_det => cliente_det.Declaracion_Patrimonio_Cliente)
                .HasForeignKey(declaracion_cliente => declaracion_cliente.ClienteDetId);

            // Historial Cliente
            modelBuilder.Entity<Historial_Cliente>()
                .HasOne(historial_cliente => historial_cliente.Cliente_Det)
                .WithMany(cliente_det => cliente_det.Historial_Cliente)
                .HasForeignKey(historial_cliente => historial_cliente.ClienteDetId);

            // Gastos Cliente
            modelBuilder.Entity<Gastos_Cliente>()
                .HasOne(gastos_cliente => gastos_cliente.Cliente_Det)
                .WithMany(cliente_det => cliente_det.Gasto_Cliente)
                .HasForeignKey(gastos_cliente => gastos_cliente.ClienteDetId);

            // Garante
            modelBuilder.Entity<Garante>()
                .HasOne(garante => garante.Cliente)
                .WithMany(cliente => cliente.Garante)
                .HasForeignKey(garante => garante.ClienteId);

            // Garante Det 
            modelBuilder.Entity<Garante_Det>()
                .HasOne(garante_det => garante_det.Garante)
                .WithMany(garante => garante.Garante_Det)
                .HasForeignKey(garante_det => garante_det.GaranteId);

            // Comportamiento Garante
            modelBuilder.Entity<Comportamiento_Garante>()
                .HasOne(comportamiento_garante => comportamiento_garante.Garante_Det)
                .WithMany(garante_det => garante_det.Comportamiento_Garante)
                .HasForeignKey(comportamiento_garante => comportamiento_garante.GaranteDetId);

            // Declaracion Garante
            modelBuilder.Entity<Declaracion_Patrimonio_Garante>()
                .HasOne(declaracion_garante => declaracion_garante.Garante_Det)
                .WithMany(garante_det => garante_det.Declaracion_Patrimonio_Garante)
                .HasForeignKey(declaracion_garante => declaracion_garante.GaranteDetId);

            // Historial Garante
            modelBuilder.Entity<Historial_Garante>()
                .HasOne(historial_garante => historial_garante.Garante_Det)
                .WithMany(garante_det => garante_det.Historial_Garante)
                .HasForeignKey(historial_garante => historial_garante.GaranteDetId);

            // Costo Cuota
            modelBuilder.Entity<Costo_Cuota>()
                .HasOne(costo_cuota => costo_cuota.Cliente)
                .WithMany(cliente => cliente.Costo_Cuota)
                .HasForeignKey(costo_cuota => costo_cuota.ClienteId);

        }

    }
}
