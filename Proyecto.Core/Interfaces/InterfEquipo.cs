using System.Collections.Generic;
using Proyecto.Core.Models;

namespace Proyecto.Core.Interfaces
{
    public interface IEquipoRepo
    {
        List<Equipo> ObtenerTodos();
        Equipo? ObtenerPorId(int id);
        void Agregar(Equipo equipo);
    }
}