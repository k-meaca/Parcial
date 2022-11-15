using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades
{
    public class Jugador : Persona
    {
        //----ATRIBUTOS Y PROPIEDADES----//

        private bool esCapitan;
        private int numero;
        private static Tipo tipo;

        public bool EsCapitan { get => esCapitan; }

        public int Numero { get => numero; }


        //----CONSTRUCTORES----//

        static Jugador()
        {
            tipo = Tipo.Jugador;
        }



        public Jugador(string nombre, string apellido, bool esCapitan, int numero) : base(nombre, apellido)
        {
            this.esCapitan = esCapitan;
            this.numero = numero;
        }

        public Jugador(string nombre, string apellido) : this(nombre, apellido, false, 0) { }

        //----METODOS----//


        //--PUBLICOS--//

        public override string FichaTecnica()
        {
            string ficha = Apellido.ToUpper() + " " + ( Nombre[0].ToString().ToUpper() + Nombre.Substring(1).ToLower() ) + ", ";

            if (esCapitan)
            {
                ficha += "capitan del equipo, ";
            }

            ficha += $"camiseta numero {numero}";

            return ficha;
        }

        public static bool operator ==(Jugador jugador, Jugador otroJugador)
        {
            bool mismoNombre = jugador.NombreCompleto() == otroJugador.NombreCompleto();
            bool mismoNumero = jugador.Numero == otroJugador.Numero;

            return mismoNombre && mismoNumero;
        }

        public static bool operator !=(Jugador jugador, Jugador otroJugador)
        {
            return !(jugador == otroJugador);
        }

        public static explicit operator int (Jugador jugador)
        {
            return jugador.Numero;
        }

        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is Jugador))
            {
                return false;
            }
            return this == (Jugador)obj;
        }
    }
}
