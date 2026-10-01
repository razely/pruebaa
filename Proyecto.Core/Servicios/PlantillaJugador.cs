using System.Collections.Generic;
using Proyecto.Core.Models;
using Proyecto.Core.Repos;

namespace Proyecto.Core.Servicios
{
    public class PlantillaJugadorServicios
    {
        private PlantillaJugadorRepo _plantillaJugadorRepo = new PlantillaJugadorRepo();

        public List<PlantillaJugador> ObtenerPorPlantilla(int idPlantilla)
        {
            return _plantillaJugadorRepo.ObtenerPorPlantilla(idPlantilla);
        }

        public void AgregarJugadorAPlantilla(PlantillaJugador plantillaJugador)
        {
            _plantillaJugadorRepo.Agregar(plantillaJugador);
        }
    }
}