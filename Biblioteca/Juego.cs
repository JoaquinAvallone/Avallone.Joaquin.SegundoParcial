using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Juego
    {
        private Jugador Jugador;

        public Juego(Jugador jugador)
        {
            Jugador = jugador;
        }

        internal Jugador Jugador1 { get => Jugador; set => Jugador = value; }


        public void EsEscalera()
        {

        }

        public void EsFull()
        {

        }

        public void EsPoker()
        {

        }

        public void EsGenerala()
        {

        }
    }
}
