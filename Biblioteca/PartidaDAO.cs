using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class PartidaDAO
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        static PartidaDAO()
        {
            cadenaConexion = @"Server=.;Database=Generala_DB;Trusted_Connection=True;";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static List<Juego> ListaPartidas(string nombreUsuario)
        {
            List<Juego> partidas = new List<Juego>();
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "SELECT * FROM Partidas WHERE jugadorUno = @jugadorUno";
            comando.Parameters.AddWithValue("@jugadorUno", nombreUsuario);
                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    partidas.Add(new Juego(Convert.ToInt32(dataReader["ID"]), dataReader["jugadorUno"].ToString(), dataReader["jugadorDos"].ToString(),
                    Convert.ToInt32(dataReader["puntosJugaUno"]), Convert.ToInt32(dataReader["puntosJugaDos"]), dataReader["ganador"].ToString(),
                    dataReader["perdedor"].ToString(), Convert.ToInt32(dataReader["partidasGanadas"]), Convert.ToInt32(dataReader["partidasPerdidas"])));
                }

                dataReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return partidas;
        }

        public static void GuardarPartida(Juego partida)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "INSERT INTO Partidas (jugadorUno, jugadorDos, puntosJugaUno, puntosJugaDos, ganador, perdedor, partidasGanadas, partidasPerdidas)" +
                    " VALUES (@jugadorUno, @jugadorDos, @puntosJugaUno, @puntosJugaDos, @ganador, @perdedor, @partidasGanadas, @partidasPerdidas)";
                comando.Parameters.AddWithValue("@jugadorUno", partida.JugadorUno.Nombre);
                comando.Parameters.AddWithValue("@jugadorDos", partida.JugadorDos.Nombre);
                comando.Parameters.AddWithValue("@puntosJugaUno", partida.PuntosJugadorUno);
                comando.Parameters.AddWithValue("@puntosJugaDos", partida.PuntosJugadorDos);
                comando.Parameters.AddWithValue("@ganador", partida.Ganador);
                comando.Parameters.AddWithValue("@perdedor", partida.Perdedor);
                comando.Parameters.AddWithValue("@partidasGanadas", partida.JugadorUno.PartidasGanadas);
                comando.Parameters.AddWithValue("@partidasPerdidas", partida.JugadorUno.PartidasPerdidas);

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
