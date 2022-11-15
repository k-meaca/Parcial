using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades
{
    public abstract class Persona
    {
        //----ATRIBUTOS Y PROPIEDADES----//

        private string nombre, apellido;

        public string Nombre { get => nombre; }

        public string Apellido { get => apellido; }


        //----CONSTRUCTOR----//

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        //----METODOS----//

        //--PRIVADOS--//

        private string FormatoNombre()
        {
            string nombreAux = nombre[0].ToString().ToUpper() + nombre.Substring(1).ToLower();
            string apellidoAux = apellido[0].ToString().ToUpper() + nombre.Substring(1).ToLower();

            return nombreAux + " " + apellidoAux;
        }

        //--PUBLICOS--//

        public abstract string FichaTecnica();

        public virtual string NombreCompleto()
        {
            return FormatoNombre();
        }

    }
}
