using System.Data;
using MySqlConnector;

namespace Proyecto.Core.Repos
{
    public static class Conexion
    {
        public static string CadenaConexion { get; set; } = "Server=localhost;Database=5to_grandt67;User=root;Password=gatorojo07;";

        public static IDbConnection ObtenerConexion()
        {
            return new MySqlConnection(CadenaConexion);
        }
    }
}