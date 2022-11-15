using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades
{
    public class DirectorTecnico : Persona
    {
        //----ATRIBUTOS Y PROPIEDADES----//

        private static Tipo tipo;

        //----CONSTRUCTOR----//

        static DirectorTecnico()
        {
            tipo = Tipo.Tecnico;
        }

        public DirectorTecnico(string nombre, string apellido) : base(nombre, apellido) { }

        //----METODOS----//

        public override string FichaTecnica()
        {
            return Nombre.ToUpper() + " " + Apellido.ToUpper() + ", director tecnico.";
        }
    }
}
