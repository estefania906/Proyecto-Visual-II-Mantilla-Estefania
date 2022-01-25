using System;
using ModeloDB;
using Modelo;
using System.Collections.Generic;

namespace Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Address Uno = new Address()
            {
                address = "Av la Gasca",
                address2 = "La prensa",
                district = "Barrio Nuevo",
                postal_code = "17052", 
                phone = "0999152523", 
                last_update = new DateTime(2022, 01, 24)

            };
            Address Dos = new Address()
            {
                address = "Av Las Casas",
                address2 = "La Juan Torres",
                district = "La Tola",
                postal_code = "17053",
                phone = "0999152321",
                last_update = new DateTime(2022, 01, 24)

            };
            Address Tres = new Address()
            {
                address = "Av Delfines",
                address2 = "La prensa",
                district = "Barrio Azul",
                postal_code = "17054",
                phone = "0999152525",
                last_update = new DateTime(2022, 01, 24)

            };
            Address Cuatro = new Address()
            {
                address = "Av las Flores",
                address2 = "La Gardenia",
                district = "La Floresta",
                postal_code = "17055",
                phone = "0999152528",
                last_update = new DateTime(2022, 01, 24)

            };
            Address Cinco = new Address()
            {
                address = "Av Frutas",
                address2 = "Av Cardenal de la Torre",
                district = "Solanda",
                postal_code = "17062",
                phone = "0999155852",
                last_update = new DateTime(2022, 01, 24)

            };
            Address Seis = new Address()
            {
                address = "Av Soles",
                address2 = "Av La tierra",
                district = "Luluncoto",
                postal_code = "17085",
                phone = "0999152552",
                last_update = new DateTime(2022, 01, 24)

            };
            Address Siete = new Address()
            {
                address = "Av la Floresta",
                address2 = "La prensa",
                district = "Barrio Viejo",
                postal_code = "170547",
                phone = "0999152559",
                last_update = new DateTime(2022, 01, 24)

            };
            Address Ocho = new Address()
            {
                address = "Av Ajavi",
                address2 = "Haiti",
                district = "Barrio Morado",
                postal_code = "17012",
                phone = "0999152523",
                last_update = new DateTime(2022, 01, 24)

            };
            Address Nueve = new Address()
            {
                address = "Av Conejos",
                address2 = "La Amazonas",
                district = "Mariscal",
                postal_code = "17056",
                phone = "0999152523",
                last_update = new DateTime(2022, 01, 24)

            };
            Address Diez = new Address()
            {
                address = "Av la Haitiana",
                address2 = "La prensa",
                district = "La Vicentina",
                postal_code = "17052",
                phone = "0999152523",
                last_update = new DateTime(2022, 01, 24)

            };
            List<Address> listaAddress = new List<Address>() { Uno, Dos, Tres, Cuatro, Cinco, Seis, Siete, Ocho, Nueve, Diez };

            City CitUno = new City()
            {
                city = "Quito",
                last_update = new DateTime(2022, 01, 24)

            };
            City CitDos = new City()
            {
                city = "Guayaquil",
                last_update = new DateTime(2022, 01, 24)

            };
            City CitTres = new City()
            {
                city = "Ambato",
                last_update = new DateTime(2022, 01, 24)

            };
            City CitCuatro = new City()
            {
                city = "Riobamba",
                last_update = new DateTime(2022, 01, 24)

            };
            City CitCinco = new City()
            {
                city = "Ibarra",
                last_update = new DateTime(2022, 01, 24)

            };
            List<City> listaCity = new List<City>() { CitUno, CitDos, CitTres, CitCuatro, CitCinco };

            Country CouUno = new Country()
            {
                country = "Ecuador",
                last_update = new DateTime(2022, 01, 24)

            };
            Country CouDos = new Country()
            {
                country = "Brasil",
                last_update = new DateTime(2022, 01, 24)

            };
            Country CouTres = new Country()
            {
                country = "Argentina",
                last_update = new DateTime(2022, 01, 24)

            };
            Country CouCuatro = new Country()
            {
                country = "Usa",
                last_update = new DateTime(2022, 01, 24)

            };
            List<Country> listaCountry = new List<Country>() { CouUno, CouDos, CouTres, CouCuatro };


            Uno.City = CitUno;
            Dos.City = CitDos;
            Tres.City = CitTres;
            Cuatro.City = CitDos;
            Cinco.City = CitCinco;
            Seis.City = CitDos;
            Siete.City = CitUno;
            Ocho.City = CitTres;
            Nueve.City = CitCuatro;
            Diez.City = CitDos;

            CitUno.Country = CouUno;
            CitDos.Country = CouDos;
            CitTres.Country = CouTres;
            CitCuatro.Country = CouCuatro;
            CitCinco.Country = CouUno;


            ModeloDB.ModeloDB repos = new ModeloDB.ModeloDB();

            repos.country.AddRange(listaCountry);
            repos.address.AddRange(listaAddress);


            Console.WriteLine("Carga de datos iniciales ...");
            repos.SaveChanges(); 
        }
    }
}
