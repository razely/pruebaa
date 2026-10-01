using System.Collections.Generic;
using Proyecto.Core.Models;

namespace Proyecto.Core.Interfaces
{
    public interface IPlantillaJugadorRepo
    {
        List<PlantillaJugador> ObtenerTodos();
        List<PlantillaJugador> ObtenerPorPlantilla(int idPlantilla);
        void Agregar(PlantillaJugador plantillaJugador);
    }
}