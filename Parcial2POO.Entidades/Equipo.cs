using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades
{
    public class Equipo
    {
        //----ATRIBUTO Y PROPIEDADES----//

        private static Deporte deporte;
        private List<Jugador> jugadores;
        private DirectorTecnico tecnico;
        private string nombre;


        public Deporte Deporte { get => deporte; set => deporte = value; }

        //----CONSTRUCTORES----//

        static Equipo()
        {
            deporte = Deporte.Futbol;
        }

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(DirectorTecnico tecnico, string nombre) : this()
        {
            this.tecnico = tecnico;
            this.nombre = nombre;
        }

        public Equipo(DirectorTecnico tecnico, string nombre, Deporte deporte) : this(tecnico, nombre)
        {
            Deporte = deporte;
        }

        //----METODOS----//


        //--PUBLICOS--//
        public static bool operator == (Equipo equipo, Jugador jugador)
        {
            return equipo.jugadores.Any(j => j == jugador);
        }

        public static bool operator != (Equipo equipo, Jugador jugador)
        {
            return !(equipo == jugador);
        }

        public static Equipo operator +(Equipo equipo, Jugador jugador)
        {
            if( equipo != jugador)
            {
                if( !jugador.EsCapitan || equipo.ExisteCapitan())
                    equipo.jugadores.Add(jugador);
            }

            return equipo;
        }

        public bool ExisteCapitan()
        {
            return jugadores.Count(j => j.EsCapitan) < 1;
        }

        public static Equipo operator - (Equipo equipo, Jugador jugador)
        {
            if(equipo == jugador)
            {
                equipo.jugadores.Remove(jugador);
            }

            return equipo;
        }

        public static implicit operator string (Equipo equipo)
        {
            StringBuilder informacion = new StringBuilder();

            informacion.AppendLine($"**{equipo.nombre} {Equipo.deporte}**");
            informacion.AppendLine("Nomina Jugadores:");

            foreach (Jugador jugador in equipo.jugadores)
            {
                informacion.AppendLine(jugador.FichaTecnica());
            }

            informacion.AppendLine(equipo.tecnico.FichaTecnica());

            return informacion.ToString();
        }

    }
}
