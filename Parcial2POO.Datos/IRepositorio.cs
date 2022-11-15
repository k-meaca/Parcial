using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2POO.Entidades;

namespace Parcial2POO.Datos
{
    public interface IRepositorio<Persona>
    {
        int GetCantidad();

        List<Persona> GetLista();
    }
}
