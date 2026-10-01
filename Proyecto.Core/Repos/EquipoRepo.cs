using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Proyecto.Core.Interfaces;
using Proyecto.Core.Models;

namespace Proyecto.Core.Repos
{
    public class EquipoRepo : IEquipoRepo
    {
        public List<Equipo> ObtenerTodos()
        {
            using var db = Conexion.ObtenerConexion();
            // Mapeamos la columna 'equipo' de MySQL a la propiedad 'Nombre' de C#
            string sql = "SELECT idEquipo AS IdEquipo, equipo AS Nombre FROM Equipo";
            return db.Query<Equipo>(sql).ToList();
        }

        public Equipo? ObtenerPorId(int id)
        {
            using var db = Conexion.ObtenerConexion();
            string sql = "SELECT idEquipo AS IdEquipo, equipo AS Nombre FROM Equipo WHERE idEquipo = @Id";
            return db.QueryFirstOrDefault<Equipo>(sql, new { Id = id });
        }

        public void Agregar(Equipo equipo)
        {
            using var db = Conexion.ObtenerConexion();
            string sql = "INSERT INTO Equipo (equipo) VALUES (@Nombre)";
            db.Execute(sql, equipo);
        }
    }
}