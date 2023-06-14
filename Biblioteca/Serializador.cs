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
    }
}
