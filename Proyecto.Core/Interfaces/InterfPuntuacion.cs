using System.Collections.Generic;
using Proyecto.Core.Models;

namespace Proyecto.Core.Interfaces
{
    public interface IPuntuacionRepo
    {
        List<Puntuacion> ObtenerPorJugador(int idJugador);
        void Agregar(Puntuacion puntuacion);
    }
}