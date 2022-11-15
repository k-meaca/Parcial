using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Parcial2POO.Datos
{
    public static class Serializador<T> where T: class, new()
    {
        //----ATRIBUTOS----//

        private static XmlSerializer serializador;

        //----METODOS----//

        //--PUBLICOS--//

        public static void SerializarXML(string rutaArchivo, T dato)
        {
            using (StreamWriter escritor = new StreamWriter(rutaArchivo))
            {
                serializador = new XmlSerializer(typeof(T));
                serializador.Serialize(escritor, dato);
            }
        }

        public static T DeserealizarXML(string rutaArchivo)
        {
            using (StreamReader lector = new StreamReader(rutaArchivo))
            {
                serializador = new XmlSerializer(typeof(T));
                T datos = serializador.Deserialize(lector) as T;
                return datos;
            }
        }

        public static T DeserealizarJSON(string rutaArchivo)
        {
            using (StreamReader lector = new StreamReader(rutaArchivo))
            {
                string json = lector.ReadToEnd();

                T dato = JsonSerializer.Deserialize<T>(json);

                return dato;
            }
        }

        public static void SerializarJSON(string rutaArchivo, T dato)
        {
            using (StreamWriter escritor = new StreamWriter(rutaArchivo))
            {
                JsonSerializerOptions opciones = new JsonSerializerOptions();

                opciones.WriteIndented = true;

                string json = JsonSerializer.Serialize(dato, opciones);

                escritor.WriteLine(json);
            }
        }
    }
}
