using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Serializador
    {
        public static void SerializarJson<T>(string path, T obj)
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.WriteIndented = true;

            string json = JsonSerializer.Serialize(obj, jsonSerializerOptions);

            File.WriteAllText(path, json);
        }

        public static Usuario? DeserializarUsuarioActualJson()
        {
            if (!File.Exists("UsuarioActual.json"))
            {
                return null;
            }
            using (StreamReader sr = new StreamReader("UsuarioActual.json"))
            {
                string stringJson = sr.ReadToEnd();

                Usuario? objeto = (Usuario?)JsonSerializer.Deserialize<Usuario>(stringJson);

                return objeto;
            }
        }

        public static Jugador? DeserializarJugadorUnoJson()
        {
            if (!File.Exists("JugadorUno.json"))
            {
                return null;
            }
            using (StreamReader sr = new StreamReader("JugadorUno.json"))
            {
                string stringJson = sr.ReadToEnd();

                Jugador? objeto = (Jugador?)JsonSerializer.Deserialize<Jugador>(stringJson);

                return objeto;
            }
        }

        public static Jugador? DeserializarJugadorDosJson()
        {
            if (!File.Exists("JugadorDos.json"))
            {
                return null;
            }
            using (StreamReader sr = new StreamReader("JugadorDos.json"))
            {
                string stringJson = sr.ReadToEnd();

                Jugador? objeto = (Jugador?)JsonSerializer.Deserialize<Jugador>(stringJson);

                return objeto;
            }
        }

        public static List<Jugador>? DeserializarJugadoresJson()
        {
            if (!File.Exists("Jugadores.json"))
            {
                return null;
            }
            using (StreamReader sr = new StreamReader("Jugadores.json"))
            {
                string stringJson = sr.ReadToEnd();

                List<Jugador>? objeto = (List<Jugador>?)JsonSerializer.Deserialize<List<Jugador>>(stringJson);

                return objeto;
            }
        }
    }
}
