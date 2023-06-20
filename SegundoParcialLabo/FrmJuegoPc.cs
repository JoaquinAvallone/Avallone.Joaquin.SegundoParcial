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
        Juego? partida;
        int[,]? tiradasJuga1;
        int[,]? tiradasJuga2;
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken;
        public FrmJuegoPc()
        {
            InitializeComponent();
            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;
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
                    if (cancellationToken.IsCancellationRequested)
                    {
                        return;
                    }
                    tiradas[t, i] = random.Next(1, 7);
                }
            }
        }

        public async void RellenarTiradas()
        {
           
            TirarDados(tiradasJuga1);
            TirarDados(tiradasJuga2);
            listBJuga1.Items.Clear();
            listBJuga2.Items.Clear();

            for (int t = 0; t < 8; t++)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    return;
                }
                string tiradaJuga1 = string.Join("-", Enumerable.Range(0, 5).Select(i => tiradasJuga1[t, i].ToString()));
                string tiradaJuga2 = string.Join("-", Enumerable.Range(0, 5).Select(i => tiradasJuga2[t, i].ToString()));

                await Task.Delay(300);
                listBJuga1.Items.Add(tiradaJuga1);
                await Task.Delay(300);
                listBJuga2.Items.Add(tiradaJuga2);
            }

            CalcularPuntosJuga1();
            CalcularPuntosJuga2();
            CalcularTotalPuntosP1();
            CalcularTotalPuntosP2();
            await Task.Delay(500);
            Task.Run(() => { Ganador(); });

        }


        public async void CalcularPuntosJuga1()
        {
            List<int[]> tiradas = new List<int[]>();
            int[] excluidos = new int[6];
            int puntos = 0;
            int[] num_cant = new int[2];

            for (int t = 0; t < 8; t++)
            {
                int[] tirada = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    tirada[i] = tiradasJuga1[t, i];
                }
                tiradas.Add(tirada);
            }
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
            int[] excluidos = new int[6];
            int puntos = 0;
            int[] num_cant = new int[2];

            for (int t = 0; t < 8; t++)
            {
                int[] tirada = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    tirada[i] = tiradasJuga2[t, i];
                }
                tiradas.Add(tirada);
            }

            foreach (int[] item in tiradas)
            {
                num_cant = Juego.ObtenerNumeroMasRepetido(item, excluidos);

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
                if (lblDado1P2.Text == "-" && num_cant[0] == 1)
                {
                    puntos = num_cant[0] * num_cant[1];
                    lblDado1P2.Text = puntos.ToString();
                    panel1P2.BackColor = Color.FromArgb(10, 64, 30);
                    Juego.AgregarExcluido(excluidos, 1);
                    continue;
                }
                if (lblDado2P2.Text == "-" && num_cant[0] == 2)
                {
                    puntos = num_cant[0] * num_cant[1];
                    lblDado2P2.Text = puntos.ToString();
                    panel2P2.BackColor = Color.FromArgb(10, 64, 30);
                    Juego.AgregarExcluido(excluidos, 2);
                    continue;
                }
                if (lblDado3P2.Text == "-" && num_cant[0] == 3)
                {
                    puntos = num_cant[0] * num_cant[1];
                    lblDado3P2.Text = puntos.ToString();
                    panel3P2.BackColor = Color.FromArgb(10, 64, 30);
                    Juego.AgregarExcluido(excluidos, 3);
                    continue;
                }
                if (lblDado4P2.Text == "-" && num_cant[0] == 4)
                {
                    puntos = num_cant[0] * num_cant[1];
                    lblDado4P2.Text = puntos.ToString();
                    panel4P2.BackColor = Color.FromArgb(10, 64, 30);
                    Juego.AgregarExcluido(excluidos, 4);
                    continue;
                }
                if (lblDado5P2.Text == "-" && num_cant[0] == 5)
                {
                    puntos = num_cant[0] * num_cant[1];
                    lblDado5P2.Text = puntos.ToString();
                    panel5P2.BackColor = Color.FromArgb(10, 64, 30);
                    Juego.AgregarExcluido(excluidos, 5);
                    continue;
                }
                if (lblDado6P2.Text == "-" && num_cant[0] == 6)
                {
                    puntos = num_cant[0] * num_cant[1];
                    lblDado6P2.Text = puntos.ToString();
                    panel6P2.BackColor = Color.FromArgb(10, 64, 30);
                    Juego.AgregarExcluido(excluidos, 6);
                    continue;
                }
            }
        }
        public void CalcularTotalPuntosP1()
        {
            int score = 0;

            string[] valoresLabel = new string[]
            {
                lblDado1P1.Text,
                lblDado2P1.Text,
                lblDado3P1.Text,
                lblDado4P1.Text,
                lblDado5P1.Text,
                lblDado6P1.Text,
                lblEscaleraP1.Text,
                lblfullP1.Text,
                lblPokerP1.Text,
                lblGeneralaP1.Text
            };

            foreach (string item in valoresLabel)
            {
                if (int.TryParse(item, out int valor))
                {
                    score += valor;
                }
            }

            lblPuntosP1.Text = score.ToString();
            partida.PuntosJugadorUno = score;
        }

        public void CalcularTotalPuntosP2()
        {
            int score = 0;

            string[] valoresLabel = new string[]
            {
                lblDado1P2.Text,
                lblDado2P2.Text,
                lblDado3P2.Text,
                lblDado4P2.Text,
                lblDado5P2.Text,
                lblDado6P2.Text,
                lblEscaleraP2.Text,
                lblFullP2.Text,
                lblPokerP2.Text,
                lblGeneralaP2.Text
            };

            foreach (string item in valoresLabel)
            {
                if (int.TryParse(item, out int valor))
                {
                    score += valor;
                }
            }

            lblPuntosP2.Text = score.ToString();
            partida.PuntosJugadorDos = score;

            if (partida.PuntosJugadorUno > partida.PuntosJugadorDos)
            {
                partida.Ganador = jugadorUno.Nombre;
                partida.Perdedor = jugadorDos.Nombre;
                jugadorUno.PartidasGanadas++;
            }
            else
            {
                partida.Ganador = jugadorDos.Nombre;
                partida.Perdedor = jugadorUno.Nombre;
                jugadorUno.PartidasPerdidas++;
            }
            Juego partidaDB = new Juego(jugadorUno.Nombre, jugadorDos.Nombre, partida.PuntosJugadorUno, partida.PuntosJugadorDos, partida.Ganador, partida.Perdedor, jugadorUno.PartidasGanadas, jugadorUno.PartidasPerdidas);
            PartidaDAO.GuardarPartida( partidaDB );
        }

        public void Ganador()
        {
            FrmGanador frmGanador = new FrmGanador(partida);
            frmGanador.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
        }
    }
}
