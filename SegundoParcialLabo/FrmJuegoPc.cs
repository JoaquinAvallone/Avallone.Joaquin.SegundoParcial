using Biblioteca;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcialLabo
{
    public partial class FrmJuegoPc : Form
    {
        Jugador? jugadorUno;
        Jugador? jugadorDos;
        Juego partida;
        int[,] tiradasJuga1;
        int[,] tiradasJuga2;
        public FrmJuegoPc()
        {
            InitializeComponent();
        }

        private void FrmJuegoPc_Load(object sender, EventArgs e)
        {
            jugadorUno = Serializador.DeserializarJugadorUnoJson();
            jugadorDos = Serializador.DeserializarJugadorDosJson();
            tiradasJuga1 = new int[4, 5];
            tiradasJuga2 = new int[4, 5];
            partida = new Juego(jugadorUno, jugadorDos);

            CargarImagenes();
            lblPlayer1.Text = jugadorUno.Nombre;
            lblPlayer2.Text = jugadorDos.Nombre;
            RellenarTiradas();
            CalcularPuntosJuga1();
        }

        public void CargarImagenes()
        {
            picBDado1P1.ImageLocation = "dados/Dado1.png";
            picBDado2P1.ImageLocation = "dados/dado2.png";
            picBDado3P1.ImageLocation = "dados/dado3.png";
            picBDado4P1.ImageLocation = "dados/dado4.png";
            picBDado5P1.ImageLocation = "dados/dado5.png";
            picBDado6P1.ImageLocation = "dados/dado6.png";
            picBDado1P2.ImageLocation = "dados/dado1.png";
            picBDado2P2.ImageLocation = "dados/dado2.png";
            picBDado3P2.ImageLocation = "dados/dado3.png";
            picBDado4P2.ImageLocation = "dados/dado4.png";
            picBDado5P2.ImageLocation = "dados/dado5.png";
            picBDado6P2.ImageLocation = "dados/dado6.png";
            picBP1.ImageLocation = "fotoPlayers/player1.png";
            picBP2.ImageLocation = "fotoPlayers/player2.png";
        }

        public void TirarDados(int[,] tiradas)
        {
            int[] dados = new int[5];
            Random random = new Random();

            for (int t = 0; t < 4; t++)
            {
                for (int i = 0; i < 5; i++)
                {
                    tiradas[t,i] = random.Next(1, 7);
                }
            }
        }

        public void RellenarTiradas()
        {
            TirarDados(tiradasJuga1);
            TirarDados(tiradasJuga2);
            listBJuga1.Items.Clear();
            listBJuga2.Items.Clear();

            for (int t = 0; t < 4; t++)
            {
                string tiradaJuga1 = string.Join("-", Enumerable.Range(0, 5).Select(i => tiradasJuga1[t, i].ToString()));
                string tiradaJuga2 = string.Join("-", Enumerable.Range(0, 5).Select(i => tiradasJuga2[t, i].ToString()));

                listBJuga1.Items.Add(tiradaJuga1);
                listBJuga2.Items.Add(tiradaJuga2);
            }
        }
        public void CalcularPuntosJuga1()
        {
            List<int[]> tiradas = new List<int[]>();
            int[] tirada1 = new int[5];
            int[] tirada2 = new int[5];
            int[] tirada3 = new int[5];
            int[] tirada4 = new int[5];

            for(int i = 0; i < 5; i++)
            {
                tirada1[i] = tiradasJuga1[0,i];
                tirada2[i] = tiradasJuga1[1,i];
                tirada3[i] = tiradasJuga1[2,i];
                tirada4[i] = tiradasJuga1[3,i];
            }
            tiradas.Add(tirada1);
            tiradas.Add(tirada2);
            tiradas.Add(tirada3);
            tiradas.Add(tirada4);

            foreach (int[] item in tiradas)
            {
                if (panelEscaleraP1.BackColor == Color.FromArgb(10, 64, 30))
                {
                    if (Juego.EsEscalera(item))
                    {                                              
                        lblEscaleraP1.Text = "20";   
                        panelEscaleraP1.BackColor = Color.FromArgb(14, 89, 41);
                    }
                }
            }
        }
    }
}
