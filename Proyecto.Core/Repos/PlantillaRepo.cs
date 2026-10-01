using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Proyecto.Core.Interfaces;
using Proyecto.Core.Models;

namespace Proyecto.Core.Repos
{
    public class PlantillaRepo : IPlantillaRepo
    {
        public List<Plantilla> ObtenerTodas()
        {
            using var db = Conexion.ObtenerConexion();
            string sql = @"SELECT idPlantilla AS IdPlantilla, 
                                  idUsuario AS IdUsuario 
                           FROM Plantilla";
            return db.Query<Plantilla>(sql).ToList();
        }

        public Plantilla? ObtenerPorUsuario(int idUsuario)
        {
            using var db = Conexion.ObtenerConexion();
            string sql = @"SELECT idPlantilla AS IdPlantilla, 
                                  idUsuario AS IdUsuario 
                           FROM Plantilla 
                           WHERE idUsuario = @IdUsuario";
            return db.QueryFirstOrDefault<Plantilla>(sql, new { IdUsuario = idUsuario });
        }

        public void Agregar(Plantilla plantilla)
        {
            using var db = Conexion.ObtenerConexion();
            string sql = "INSERT INTO Plantilla (idUsuario) VALUES (@IdUsuario)";
            db.Execute(sql, plantilla);
        }
    }
}