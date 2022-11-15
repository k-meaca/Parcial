using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2POO.Entidades;
using System.IO;

namespace Parcial2POO.Datos
{
    public static class ManejadorDeArchivos
    {

        //----METOODS----//

        //--PRIVADOS--//

        private static Persona ConstruirPersona(string dato)
        {
            string[] informacion = dato.Split('|');

            string nombre = informacion[0];
            string apellido = informacion[1];

            if (informacion.Length > 3)
            {
                int numero = Convert.ToInt32(informacion[2]);
                bool esCapitan = Convert.ToBoolean(informacion[3]);

                return new Jugador(nombre, apellido, esCapitan, numero);
            }

            return new DirectorTecnico(nombre, apellido);
        }

        private static string ConstruirLinea(dynamic persona)
        {
            if(persona is Jugador)
            {
                Jugador jugador = (Jugador)persona;

                return jugador.Nombre + "|" + jugador.Apellido + "|" + jugador.Numero.ToString() 
                    + "|" + jugador.EsCapitan.ToString() + "|" + "1";
            }
            else
            {
                DirectorTecnico tecnico = (DirectorTecnico)persona;

                return tecnico.Nombre + "|" + tecnico.Apellido + "|" + "2";
            }
        }

        //--PUBLICOS--//

        public static void Guardar(string rutaArchivo, Equipo equipo, List<Persona> personas)
        {

            using (StreamWriter escritor = new StreamWriter(rutaArchivo, true))
            {
                foreach (Persona persona in personas)
                {
                    string linea = ConstruirLinea(persona);
                    escritor.WriteLine(linea);
                }
            }
        }

        public static List<Persona> Leer(string rutaArchivo)
        {
            List<Persona> lista = new List<Persona>();

            if (File.Exists(rutaArchivo))
            {
                using (StreamReader lector = new StreamReader(rutaArchivo))
                {
                    while (!lector.EndOfStream)
                    {
                        Persona objeto = ConstruirPersona(lector.ReadLine());
                        lista.Add(objeto);
                    }
                }
            }

            return lista;
        }

    }
}
