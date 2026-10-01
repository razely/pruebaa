using Proyecto.Core.Models;
using Proyecto.Core.Repos;

namespace Proyecto.Core.Servicios
{
    public class PlantillaServicios
    {
        private PlantillaRepo _plantillaRepo = new PlantillaRepo();

        public Plantilla? ObtenerPorUsuario(int idUsuario)
        {
            return _plantillaRepo.ObtenerPorUsuario(idUsuario);
        }

        public void CrearPlantilla(Plantilla plantilla)
        {
            _plantillaRepo.Agregar(plantilla);
        }
    }
}