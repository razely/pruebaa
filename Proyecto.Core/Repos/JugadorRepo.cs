using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Proyecto.Core.Interfaces;
using Proyecto.Core.Models;

namespace Proyecto.Core.Repos
{
    public class JugadorRepo : IJugadorRepo
    {
        public List<Jugador> ObtenerTodos()
        {
            using var db = Conexion.ObtenerConexion();
            string sql = @"SELECT idJugador AS IdJugador, 
                                  idEquipo AS IdEquipo, 
                                  nombre AS Nombre, 
                                  apellido AS Apellido, 
                                  apodo AS Apodo, 
                                  fechaNacimiento AS FechaNacimiento, 
                                  cotizacion AS Cotizacion, 
                                  posicion AS Posicion 
                           FROM Jugador";
            return db.Query<Jugador>(sql).ToList();
        }

        public Jugador? ObtenerPorId(int id)
        {
            using var db = Conexion.ObtenerConexion();
            string sql = @"SELECT idJugador AS IdJugador, 
                                  idEquipo AS IdEquipo, 
                                  nombre AS Nombre, 
                                  apellido AS Apellido, 
                                  apodo AS Apodo, 
                                  fechaNacimiento AS FechaNacimiento, 
                                  cotizacion AS Cotizacion, 
                                  posicion AS Posicion 
                           FROM Jugador 
                           WHERE idJugador = @Id";
            return db.QueryFirstOrDefault<Jugador>(sql, new { Id = id });
        }

        public void Agregar(Jugador jugador)
        {
            using var db = Conexion.ObtenerConexion();
            string sql = @"INSERT INTO Jugador (idEquipo, nombre, apellido, apodo, fechaNacimiento, cotizacion, posicion) 
                           VALUES (@IdEquipo, @Nombre, @Apellido, @Apodo, @FechaNacimiento, @Cotizacion, @Posicion)";
            db.Execute(sql, jugador);
        }
    }
}