using System.Collections.Generic;
using Proyecto.Core.Models;
using Proyecto.Core.Repos;

namespace Proyecto.Core.Servicios
{
    public class JugadorServicios
    {
        private JugadorRepo _jugadorRepo = new JugadorRepo();

        public List<Jugador> ObtenerTodos()
        {
            return _jugadorRepo.ObtenerTodos();
        }

        public Jugador? ObtenerPorId(int idJugador)
        {
            return _jugadorRepo.ObtenerPorId(idJugador);
        }
    }
}