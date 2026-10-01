namespace Proyecto.Core.Models;

public class Jugador
{
    public int IdJugador { get ; set; }
    public int IdEquipo { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string? Apodo { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public decimal Cotizacion { get; set; }
    public string Posicion { get; set;} = string.Empty;
}