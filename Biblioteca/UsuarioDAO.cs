using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class UsuarioDAO
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        static UsuarioDAO() 
        {
            cadenaConexion = @"Server=.;Database=Generala_DB;Trusted_Connection=True;";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static List<Usuario> ListaUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "SELECT nombreCompleto, nombreUsuario, email, contraseña FROM Usuarios";
                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    usuarios.Add(new Usuario(dataReader["nombreCompleto"].ToString(), dataReader["nombreUsuario"].ToString(), dataReader["email"].ToString(), dataReader["contraseña"].ToString()));
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

            return usuarios;
        }

        public static void GuardarUsuario(Usuario usuario)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "INSERT INTO Usuarios (nombreCompleto, nombreUsuario, email, contraseña) VALUES (@nombreCompleto, @nombreUsuario, @email, @contraseña)";
                comando.Parameters.AddWithValue("@nombreCompleto", usuario.NombreCompleto);
                comando.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                comando.Parameters.AddWithValue("@email", usuario.Email);
                comando.Parameters.AddWithValue("@contraseña", usuario.Contraseña);

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
