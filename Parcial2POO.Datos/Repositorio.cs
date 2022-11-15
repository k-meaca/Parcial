using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2POO.Entidades;

namespace Parcial2POO.Datos
{
    public class Repositorio : IRepositorio<Persona>
    {

        //----ATRIBUTOS Y PROPIEDADES----//

        private readonly string ruta_archivo;
        List<Persona> listaPersonas;

        private string Personas { get => ruta_archivo; }

        //----CONSTRUCTOR----//

        public Repositorio()
        {
            ruta_archivo = "Personas.txt";
            listaPersonas = ManejadorDeArchivos.Leer(ruta_archivo);
        }

        //----METODOS----//

        //--PUBLICOS--//

        public int GetCantidad()
        {
            return listaPersonas.Count;
        }

        public List<Persona> GetLista()
        {
            return listaPersonas;
        }
    }
}
