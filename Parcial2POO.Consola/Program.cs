using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2POO.Entidades;
using Parcial2POO.Datos;

namespace Parcial2POO.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //            **Huracán de San Rafael Futbol**
            //Nómina Jugadores:
            //            PANDOLFI Juan, camiseta número 11
            //MARCHANT Julio, camiseta número 8
            //MEDRAN Ezequiel, camiseta número 12
            //PEREDA John, camiseta número 24
            //NAVAS Fernando, capitán del equipo, camiseta número 11
            //JORGE HABEGER, director técnico

            Jugador pandolfi = new Jugador("Juan", "panDoLfi", false, 11);
            Jugador navas = new Jugador("FERNANDO", "navas", true, 1);
            Jugador mechant = new Jugador("juLIO", "MERChant", false, 8);
            Jugador meaca = new Jugador("kevin", "meaca", true, 9);
            Jugador medran = new Jugador("EZEQuiel", "medrian", false, 12);
            Jugador pereda = new Jugador("jOHn", "perEda", false, 24);

            DirectorTecnico habeger = new DirectorTecnico("jorge", "habeger");

            Equipo huracan = new Equipo(habeger, "Huracan de San Rafael");

            huracan = huracan + pandolfi;
            huracan = huracan + navas;
            huracan = huracan + mechant;
            huracan = huracan + meaca;
            huracan = huracan + medran;
            huracan = huracan + pereda;

            Console.WriteLine(huracan);

            huracan = huracan - navas;
            huracan = huracan + meaca;

            huracan.Deporte = Deporte.Basquet;

            Console.WriteLine(huracan);

            //List<Jugador> jugadores = new List<Jugador>()
            //{
            //    pandolfi,
            //    navas,
            //    mechant,
            //    meaca,
            //    medran,
            //    pereda,
            //};

            //Serializador<List<Jugador>>.SerializarJSON("Jugadores.json", jugadores);

            List<Jugador> jugadorJSON = Serializador<List<Jugador>>.DeserealizarJSON("Jugadores.json");

            foreach(Jugador j in jugadorJSON)
            {
                Console.WriteLine(j.FichaTecnica());
            }

            Console.ReadKey();

        }
    }
}
