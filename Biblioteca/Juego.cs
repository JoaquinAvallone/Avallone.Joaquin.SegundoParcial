using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Juego
    {
        Jugador Jugador;
        private int[] dados;

        public Juego(int[] dados)
        {
            this.dados = new int[5];
        }

        public int[] Dados { get => dados; set => dados = value; }

        public void TirarDados()
        {
            Random random = new Random();
            for(int i = 0; i > dados.Length; i++)
            {
                dados[i] = random.Next(1,7);
            }
        }

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
