using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Proyecto.Core.Interfaces;
using Proyecto.Core.Models;

namespace Proyecto.Core.Repos
{
    public class UsuarioRepo : IUsuarioRepo
    {
        public List<Usuario> ObtenerTodos()
        {
            using var db = Conexion.ObtenerConexion();
            string sql = @"SELECT idUsuario AS IdUsuario, 
                                  nombre AS Nombre, 
                                  email AS Email, 
                                  pass AS Pass 
                           FROM Usuario";
            return db.Query<Usuario>(sql).ToList();
        }

        public Usuario? ObtenerPorId(int idUsuario)
        {
            using var db = Conexion.ObtenerConexion();
            string sql = @"SELECT idUsuario AS IdUsuario, 
                                  nombre AS Nombre, 
                                  email AS Email, 
                                  pass AS Pass 
                           FROM Usuario 
                           WHERE idUsuario = @Id";
            return db.QueryFirstOrDefault<Usuario>(sql, new { Id = idUsuario });
        }

        public Usuario? ValidarLogin(string email, string pass)
        {
            using var db = Conexion.ObtenerConexion();
            string sql = @"SELECT idUsuario AS IdUsuario, 
                                  nombre AS Nombre, 
                                  email AS Email, 
                                  pass AS Pass 
                           FROM Usuario 
                           WHERE email = @Email AND pass = @Pass";
            return db.QueryFirstOrDefault<Usuario>(sql, new { Email = email, Pass = pass });
        }

        public void Agregar(Usuario usuario)
        {
            using var db = Conexion.ObtenerConexion();
            string sql = "INSERT INTO Usuario (nombre, email, pass) VALUES (@Nombre, @Email, @Pass)";
            db.Execute(sql, usuario);
        }
    }
}