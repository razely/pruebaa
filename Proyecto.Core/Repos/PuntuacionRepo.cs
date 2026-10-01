using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Proyecto.Core.Interfaces;
using Proyecto.Core.Models;

namespace Proyecto.Core.Repos
{
    public class PuntuacionRepo : IPuntuacionRepo
    {
        public List<Puntuacion> ObtenerPorJugador(int idJugador)
        {
            using var db = Conexion.ObtenerConexion();
            string sql = @"SELECT idPuntuacion AS IdPuntuacion, 
                                  idJugador AS IdJugador, 
                                  numFecha AS NumFecha, 
                                  nota AS Nota 
                           FROM Puntuacion 
                           WHERE idJugador = @IdJugador";
            return db.Query<Puntuacion>(sql, new { IdJugador = idJugador }).ToList();
        }

        public void Agregar(Puntuacion puntuacion)
        {
            using var db = Conexion.ObtenerConexion();
            string sql = @"INSERT INTO Puntuacion (idJugador, numFecha, nota) 
                           VALUES (@IdJugador, @NumFecha, @Nota)";
            db.Execute(sql, puntuacion);
        }
    }
}