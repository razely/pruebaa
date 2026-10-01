using System.Collections.Generic;
using Proyecto.Core.Models;

namespace Proyecto.Core.Interfaces
{
    public interface IUsuarioRepo
    {
        List<Usuario> ObtenerTodos();
        Usuario? ObtenerPorId(int idUsuario);
        Usuario? ValidarLogin(string email, string pass);
        void Agregar(Usuario usuario);
    }
}