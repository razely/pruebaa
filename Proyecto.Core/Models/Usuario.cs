using System.ComponentModel;

namespace Proyecto.Core.Models;

public class Usuario
{
    public int IdUsuario { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime FechaNacimiento { get; set; }
    public string Pass { get; set; } = string.Empty;
    public bool Administrador { get; set; }
}