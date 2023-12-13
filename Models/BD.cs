using System;
using Dapper;
using System.Data;
using System.Linq;
using System.Threading;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

public static class BD
{
    private static string _connectionString = "Server=localhost;Database=TPEquiposJugadores;Trusted_Connection=True;";

    public static List<Equipo> ObtenerEquipos(){
        string sql = "SELECT * FROM Equipos;";
        using (SqlConnection db = new SqlConnection(_connectionString)){
            return db.Query<Equipo>(sql).ToList();
        }
    }

    public static Equipo ObtenerEquipo(int idEquipo){
        string sql = "SELECT * FROM Equipos WHERE idEquipo = @idEquipo";
        using (SqlConnection db = new SqlConnection(_connectionString)){
            return db.QueryFirstOrDefault<Equipo>(sql, new {idEquipo});
        }
    }

    public static List<Jugador> ObtenerJugadores(int idEquipo){
        string sql = "SELECT * FROM Jugadores WHERE idEquipo = @idEquipo";
        using (SqlConnection db = new SqlConnection(_connectionString)){
             return db.Query<Jugador>(sql, new {idEquipo} ).ToList();
        }
    }

    public static Jugador ObtenerJugador(int idJugador){
        string sql = "SELECT * FROM Jugadores WHERE idJugador = @idJugador";
        using (SqlConnection db = new SqlConnection(_connectionString)){
            return db.QueryFirstOrDefault<Jugador>(sql, new {idJugador});
        }
    }
}