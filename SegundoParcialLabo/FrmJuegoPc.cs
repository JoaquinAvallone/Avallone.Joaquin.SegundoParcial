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
            tiradasJuga1 = new int[8, 5];
            tiradasJuga2 = new int[8, 5];
            partida = new Juego(jugadorUno, jugadorDos);

            CargarImagenes();
            lblPlayer1.Text = jugadorUno.Nombre;
            lblPlayer2.Text = jugadorDos.Nombre;
            RellenarTiradas();
            CalcularPuntosJuga1();
            CalcularPuntosJuga2();
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

            for (int t = 0; t < 8; t++)
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

            for (int t = 0; t < 8; t++)
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
            int[] tirada5 = new int[5];
            int[] tirada6 = new int[5];
            int[] tirada7 = new int[5];
            int[] tirada8 = new int[5];
            int[] excluidos = new int[] { 0, 0, 0, 0, 0, 0 };
            int puntos = 0;
            int[] num_cant = new int[2];

            for (int i = 0; i < 5; i++)
            {
                tirada1[i] = tiradasJuga1[0, i];
                tirada2[i] = tiradasJuga1[1, i];
                tirada3[i] = tiradasJuga1[2, i];
                tirada4[i] = tiradasJuga1[3, i];
                tirada5[i] = tiradasJuga1[4, i];
                tirada6[i] = tiradasJuga1[5, i];
                tirada7[i] = tiradasJuga1[6, i];
                tirada8[i] = tiradasJuga1[7, i];
            }
            tiradas.Add(tirada1);
            tiradas.Add(tirada2);
            tiradas.Add(tirada3);
            tiradas.Add(tirada4);
            tiradas.Add(tirada5);
            tiradas.Add(tirada6);
            tiradas.Add(tirada7);
            tiradas.Add(tirada8);

            foreach (int[] item in tiradas)
            {
                num_cant = Juego.ObtenerNumeroMasRepetido(item, excluidos);

                if (panelEscaleraP1.BackColor == Color.FromArgb(14, 89, 41))
                {
                    if (Juego.EsEscalera(item))
                    {
                        lblEscaleraP1.Text = "20";
                        panelEscaleraP1.BackColor = Color.FromArgb(10, 64, 30);
                        continue;
                    }
                }
                if (panelFullP1.BackColor == Color.FromArgb(14, 89, 41))
                {
                    if (Juego.EsFull(item))
                    {
                        lblfullP1.Text = "30";
                        panelFullP1.BackColor = Color.FromArgb(10, 64, 30);
                        continue;
                    }
                }
                if (panelPokerP1.BackColor == Color.FromArgb(14, 89, 41))
                {
                    if (Juego.EsPoker(item))
                    {
                        lblPokerP1.Text = "40";
                        panelPokerP1.BackColor = Color.FromArgb(10, 64, 30);
                        continue;
                    }
                }
                if (panelGeneralaP1.BackColor == Color.FromArgb(14, 89, 41))
                {
                    if (Juego.EsGenerala(item))
                    {
                        lblGeneralaP1.Text = "50";
                        panelGeneralaP1.BackColor = Color.FromArgb(10, 64, 30);
                        continue;
                    }
                }
                if (lblDado1P1.Text == "-" && num_cant[0] == 1)
                {
                    puntos = num_cant[0] * num_cant[1];
                    lblDado1P1.Text = puntos.ToString();
                    panel1P1.BackColor = Color.FromArgb(10, 64, 30);
                    Juego.AgregarExcluido(excluidos, 1);
                    continue;
                }
                if (lblDado2P1.Text == "-" && num_cant[0] == 2)
                {
                    puntos = num_cant[0] * num_cant[1];
                    lblDado2P1.Text = puntos.ToString();
                    panel2P1.BackColor = Color.FromArgb(10, 64, 30);
                    Juego.AgregarExcluido(excluidos, 2);
                    continue;
                }
                if (lblDado3P1.Text == "-" && num_cant[0] == 3)
                {
                    puntos = num_cant[0] * num_cant[1];
                    lblDado3P1.Text = puntos.ToString();
                    panel3P1.BackColor = Color.FromArgb(10, 64, 30);
                    Juego.AgregarExcluido(excluidos, 3);
                    continue;
                }
                if (lblDado4P1.Text == "-" && num_cant[0] == 4)
                {
                    puntos = num_cant[0] * num_cant[1];
                    lblDado4P1.Text = puntos.ToString();
                    panel4P1.BackColor = Color.FromArgb(10, 64, 30);
                    Juego.AgregarExcluido(excluidos, 4);
                    continue;
                }
                if (lblDado5P1.Text == "-" && num_cant[0] == 5)
                {
                    puntos = num_cant[0] * num_cant[1];
                    lblDado5P1.Text = puntos.ToString();
                    panel5P1.BackColor = Color.FromArgb(10, 64, 30);
                    Juego.AgregarExcluido(excluidos, 5);
                    continue;
                }
                if (lblDado6P1.Text == "-" && num_cant[0] == 6)
                {
                    puntos = num_cant[0] * num_cant[1];
                    lblDado6P1.Text = puntos.ToString();
                    panel6P1.BackColor = Color.FromArgb(10, 64, 30);
                    Juego.AgregarExcluido(excluidos, 6);
                    continue;
                }
            }
        }

        public void CalcularPuntosJuga2()
        {
            List<int[]> tiradas = new List<int[]>();
            int[] tirada1 = new int[5];
            int[] tirada2 = new int[5];
            int[] tirada3 = new int[5];
            int[] tirada4 = new int[5];

            for (int i = 0; i < 5; i++)
            {
                tirada1[i] = tiradasJuga2[0, i];
                tirada2[i] = tiradasJuga2[1, i];
                tirada3[i] = tiradasJuga2[2, i];
                tirada4[i] = tiradasJuga2[3, i];
            }
            tiradas.Add(tirada1);
            tiradas.Add(tirada2);
            tiradas.Add(tirada3);
            tiradas.Add(tirada4);

            foreach (int[] item in tiradas)
            {
                if (panelEscaleraP2.BackColor == Color.FromArgb(14, 89, 41))
                {
                    if (Juego.EsEscalera(item))
                    {
                        lblEscaleraP2.Text = "20";
                        panelEscaleraP2.BackColor = Color.FromArgb(10, 64, 30);
                    }
                }
                if (panelFullP2.BackColor == Color.FromArgb(14, 89, 41))
                {
                    if (Juego.EsFull(item))
                    {
                        lblFullP2.Text = "30";
                        panelFullP2.BackColor = Color.FromArgb(10, 64, 30);
                    }
                }
                if (panelPokerP2.BackColor == Color.FromArgb(14, 89, 41))
                {
                    if (Juego.EsPoker(item))
                    {
                        lblPokerP2.Text = "40";
                        panelPokerP2.BackColor = Color.FromArgb(10, 64, 30);
                    }
                }
                if (panelGeneralaP2.BackColor == Color.FromArgb(14, 89, 41))
                {
                    if (Juego.EsGenerala(item))
                    {
                        lblGeneralaP2.Text = "50";
                        panelGeneralaP2.BackColor = Color.FromArgb(10, 64, 30);
                    }
                }

            }
        }
    }
}
