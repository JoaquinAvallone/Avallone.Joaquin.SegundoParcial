using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Juego
    {
        private Jugador jugadorUno;
        private Jugador jugadorDos;
        private int puntosJugadorUno;
        private int puntosJugadorDos;
        private string ganador;
        public Juego(Jugador jugadorUno, Jugador jugadorDos)
        {
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
        }

        public Jugador JugadorUno { get => jugadorUno; set => jugadorUno = value; }
        public Jugador JugadorDos { get => jugadorDos; set => jugadorDos = value; }
        public int PuntosJugadorUno { get => puntosJugadorUno; set => puntosJugadorUno = value; }
        public int PuntosJugadorDos { get => puntosJugadorDos; set => puntosJugadorDos = value; }


        public static bool EsEscalera(int[] dados)
        {
            for(int i = 0; i < dados.Length; i++)
            {
                if((dados.Contains(1) || dados.Contains(6)) && dados.Contains(2) && dados.Contains(3) && dados.Contains(4) && dados.Contains(5))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool EsFull(int[] dados)
        {
            Array.Sort(dados);

            if ((dados[0] == dados[1] && dados[1] == dados[2] && dados[3] == dados[4]) ||
                (dados[0] == dados[1] && dados[2] == dados[3] && dados[3] == dados[4]))
            {
                return true;
            }
            return false;

        }


        public static bool EsPoker(int[] dados)
        {
            Array.Sort(dados);

            if ((dados[0] == dados[1] && dados[1] == dados[2] && dados[2] == dados[3]) ||
                (dados[1] == dados[2] && dados[2] == dados[3] && dados[3] == dados[4]))
            {
                return true;
            }

            return false;
        }

        public static bool EsGenerala(int[] dados)
        {
            for (int i = 0; i < dados.Length - 1; i++)
            {
                for (int j = 1; j < dados.Length; j++)
                {
                    if (dados[i] != dados[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static int CantidadDadosIguales(int n, int[] dados)
        {
            int contador = 0;

            for(int i = 0; i < dados.Length; i++)
            {
                if (dados[i] == n)
                {
                    contador++;
                }
            }

            return contador;
        }

        public static void DeterminarGanador(Juego juego)
        {
            if(juego.puntosJugadorUno > juego.puntosJugadorDos)
            {
                juego.ganador = juego.jugadorUno.Nombre;
            }
            else
            {
                juego.ganador = juego.jugadorDos.Nombre;
            }
        }
    }
}
