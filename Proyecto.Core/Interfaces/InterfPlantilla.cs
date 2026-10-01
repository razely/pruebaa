using System.Collections.Generic;
using Proyecto.Core.Models;

namespace Proyecto.Core.Interfaces
{
    public interface IPlantillaRepo
    {
        List<Plantilla> ObtenerTodas();
        Plantilla? ObtenerPorUsuario(int idUsuario);
        void Agregar(Plantilla plantilla);
    }
}