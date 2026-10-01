using Proyecto.Core.Repos;

namespace Proyecto.Core.Servicios
{
    public class PuntuacionServicios
    {
        private PuntuacionRepo _puntuacionRepo = new PuntuacionRepo();
        private PlantillaJugadorRepo _plantillaJugadorRepo = new PlantillaJugadorRepo();

        public decimal CalcularPuntaje(int idPlantilla)
        {
            decimal total = 0;
            
            // suscamos los jugadores que pertenecen a la plantilla
            var jugadores = _plantillaJugadorRepo.ObtenerPorPlantilla(idPlantilla);

            // sumamos los puntos de cada jugador
            foreach (var pj in jugadores)
            {
                var puntuaciones = _puntuacionRepo.ObtenerPorJugador(pj.IdJugador);
                foreach (var p in puntuaciones)
                {
                    total += p.Nota; // Sumamos la nota de cada puntuación
                }
            }

            return total;
        }
    }
}