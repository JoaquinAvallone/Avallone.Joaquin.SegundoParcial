using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jugador
    {
        private string nombre;
        private int[] dados;
        private int partidasGanadas;
        private int partidasPerdidas;

        public Jugador()
        {
            this.dados = new int[5];
        }
        public Jugador(string nombre):this()
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int[] Dados { get => dados; set => dados = value; }
        public int PartidasGanadas { get => partidasGanadas; set => partidasGanadas = value; }
        public int PartidasPerdidas { get => partidasPerdidas; set => partidasPerdidas = value; }

        public int[] TirarDados()
        {
            Random random = new Random();
            for (int i = 0; i > 5; i++)
            {
                dados[i] = random.Next(1, 7);
            }
            return dados;
        }

   


    }
}
