using System.Collections.Generic;
using Proyecto.Core.Models;

namespace Proyecto.Core.Interfaces
{
    public interface IJugadorRepo
    {
        List<Jugador> ObtenerTodos();
        Jugador? ObtenerPorId(int idJugador);
        void Agregar(Jugador jugador);
    }
}