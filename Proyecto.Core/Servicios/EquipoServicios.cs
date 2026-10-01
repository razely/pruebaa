using System.Collections.Generic;
using Proyecto.Core.Models;
using Proyecto.Core.Repos;

namespace Proyecto.Core.Servicios
{
    public class EquipoServicios
    {
        private EquipoRepo _equipoRepo = new EquipoRepo();

        public List<Equipo> ObtenerTodos()
        {
            return _equipoRepo.ObtenerTodos();
        }

        public Equipo? ObtenerPorId(int idEquipo)
        {
            return _equipoRepo.ObtenerPorId(idEquipo);
        }
    }
}