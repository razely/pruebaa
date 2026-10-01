using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Proyecto.Core.Interfaces;
using Proyecto.Core.Models;

namespace Proyecto.Core.Repos
{
    public class PlantillaJugadorRepo : IPlantillaJugadorRepo
    {
        public List<PlantillaJugador> ObtenerTodos()
        {
            using var db = Conexion.ObtenerConexion();
            string sql = @"SELECT idPlantilla AS IdPlantilla, 
                                  idJugador AS IdJugador, 
                                  esTitular AS EsTitular 
                           FROM PlantillaJugador";
            return db.Query<PlantillaJugador>(sql).ToList();
        }

        public List<PlantillaJugador> ObtenerPorPlantilla(int idPlantilla)
        {
            using var db = Conexion.ObtenerConexion();
            string sql = @"SELECT idPlantilla AS IdPlantilla, 
                                  idJugador AS IdJugador, 
                                  esTitular AS EsTitular 
                           FROM PlantillaJugador 
                           WHERE idPlantilla = @IdPlantilla";
            return db.Query<PlantillaJugador>(sql, new { IdPlantilla = idPlantilla }).ToList();
        }

        public void Agregar(PlantillaJugador plantillaJugador)
        {
            using var db = Conexion.ObtenerConexion();
            string sql = @"INSERT INTO PlantillaJugador (idPlantilla, idJugador, esTitular) 
                           VALUES (@IdPlantilla, @IdJugador, @EsTitular)";
            db.Execute(sql, plantillaJugador);
        }
    }
}