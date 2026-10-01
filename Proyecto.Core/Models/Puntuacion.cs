namespace Proyecto.Core.Models;

public class Puntuacion
{
    public int IdPuntuacion { get; set; }
    public int IdJugador { get; set; }
    public int NumFecha { get; set; }
    public decimal Nota {get; set; }
}