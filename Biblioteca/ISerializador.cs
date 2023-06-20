using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface ISerializador<T> where T : class
    {
        public void SerializarJson<T>(string path, T obj);
        public Usuario? DeserializarUsuarioActualJson();
        public Jugador? DeserializarJugadorUnoJson();
        public Jugador? DeserializarJugadorDosJson();
        public List<Jugador>? DeserializarJugadoresJson();
    }
}
