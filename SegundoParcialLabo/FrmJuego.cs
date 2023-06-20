using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace SegundoParcialLabo
{
    public delegate void NotificarFinDelJuego();
    public partial class FrmJuego : Form
    {
        public event NotificarFinDelJuego JuegoTerminado;
        Jugador? jugadorUno;
        Jugador? jugadorDos;
        Juego partida;
        bool terminoLaPartida = false;
        bool checkPartida = true;
        public FrmJuego()
        {
            InitializeComponent();
        }

        private void FrmJuego_Load(object sender, EventArgs e)
        {
            Serializador<Jugador> serializador = new Serializador<Jugador>();
            jugadorUno = serializador.DeserializarJugadorUnoJson();
            jugadorDos = serializador.DeserializarJugadorDosJson();
            partida = new Juego(jugadorUno, jugadorDos);

            CargarImagenes();
            rBtn1.Checked = true;
            picBP1.BackColor = Color.LightCoral;
            lblPlayer1.Text = jugadorUno.Nombre;
            lblPlayer2.Text = jugadorDos.Nombre;

            JuegoTerminado += Ganador;
            Task.Run(() => { CheckFinPartida(); });
        }

        public void CheckFinPartida()
        {
            while (checkPartida)
            {
                JuegoTerminado.Invoke();
            }
            btnTirar.Enabled = false;
            btnPasarTurno.Enabled = false;
        }
        public void CargarImagenes()
        {
            this.Text = jugadorUno.Nombre + " vs " + jugadorDos.Nombre;
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
            picBoxDado1.ImageLocation = "dados/dado1.png";
            picBoxDado2.ImageLocation = "dados/dado1.png";
            picBoxDado3.ImageLocation = "dados/dado1.png";
            picBoxDado4.ImageLocation = "dados/dado1.png";
            picBoxDado5.ImageLocation = "dados/dado1.png";
        }

        public void RestablecerDados()
        {
            picBoxDado1.ImageLocation = "dados/dado1.png";
            picBoxDado2.ImageLocation = "dados/dado1.png";
            picBoxDado3.ImageLocation = "dados/dado1.png";
            picBoxDado4.ImageLocation = "dados/dado1.png";
            picBoxDado5.ImageLocation = "dados/dado1.png";
        }

        public void Tiradas()
        {
            if (rBtn1.Checked)
            {
                CargarDados(jugadorUno);
                numUD1.Value++;
                lblTiradas.Text = "Tirada " + numUD1.Value + "/3";
            }
            else
            {
                CargarDados(jugadorDos);
                numUD2.Value++;
                lblTiradas.Text = "Tirada " + numUD2.Value + "/3";
            }
            if (numUD1.Value == 3 && rBtn1.Checked || numUD2.Value == 3 && rBtnP2.Checked)
            {
                btnTirar.Enabled = false;
            }
            else
            {
                btnTirar.Enabled = true;
            }

        }

        public int[] TirarDados()
        {
            int[] dados = new int[5];

            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {

                dados[i] = random.Next(1, 7);

            }
            return dados;
        }

        public void CargarDados(Jugador jugador)
        {
            int[] dados = new int[5];

            dados = TirarDados();
            if (picBoxDado1.BackColor != Color.FromArgb(10, 64, 30))
            {
                picBoxDado1.ImageLocation = "dados/dado" + dados[0] + ".png";
                jugador.Dados[0] = dados[0];
            }
            if (picBoxDado2.BackColor != Color.FromArgb(10, 64, 30))
            {
                picBoxDado2.ImageLocation = "dados/dado" + dados[1] + ".png";
                jugador.Dados[1] = dados[1];
            }
            if (picBoxDado3.BackColor != Color.FromArgb(10, 64, 30))
            {
                picBoxDado3.ImageLocation = "dados/dado" + dados[2] + ".png";
                jugador.Dados[2] = dados[2];
            }
            if (picBoxDado4.BackColor != Color.FromArgb(10, 64, 30))
            {
                picBoxDado4.ImageLocation = "dados/dado" + dados[3] + ".png";
                jugador.Dados[3] = dados[3];
            }
            if (picBoxDado5.BackColor != Color.FromArgb(10, 64, 30))
            {
                picBoxDado5.ImageLocation = "dados/dado" + dados[4] + ".png";
                jugador.Dados[4] = dados[4];
            }

        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            Tiradas();
        }

        private bool CalcularPuntosJ1()
        {
            bool retorno = false;
            int vecesRepetido = 0;
            int puntos = 0;

            if (lblDado1P1.Text == "-" && panel1P1.BackColor == Color.FromArgb(10, 64, 30))
            {
                puntos = Juego.CantidadDadosIguales(1, jugadorUno.Dados);
                lblDado1P1.Text = puntos.ToString();
                retorno = true;
            }
            if (lblDado2P1.Text == "-" && panel2P1.BackColor == Color.FromArgb(10, 64, 30))
            {
                vecesRepetido = Juego.CantidadDadosIguales(2, jugadorUno.Dados);
                puntos = 2 * vecesRepetido;
                lblDado2P1.Text = puntos.ToString();
                retorno = true;
            }
            if (lblDado3P1.Text == "-" && panel3P1.BackColor == Color.FromArgb(10, 64, 30))
            {
                vecesRepetido = Juego.CantidadDadosIguales(3, jugadorUno.Dados);
                puntos = 3 * vecesRepetido;
                lblDado3P1.Text = puntos.ToString();
                retorno = true;
            }
            if (lblDado4P1.Text == "-" && panel4P1.BackColor == Color.FromArgb(10, 64, 30))
            {
                vecesRepetido = Juego.CantidadDadosIguales(4, jugadorUno.Dados);
                puntos = 4 * vecesRepetido;
                lblDado4P1.Text = puntos.ToString();
                retorno = true;
            }
            if (lblDado5P1.Text == "-" && panel5P1.BackColor == Color.FromArgb(10, 64, 30))
            {
                vecesRepetido = Juego.CantidadDadosIguales(5, jugadorUno.Dados);
                puntos = 5 * vecesRepetido;
                lblDado5P1.Text = puntos.ToString();
                retorno = true;
            }
            if (lblDado6P1.Text == "-" && panel6P1.BackColor == Color.FromArgb(10, 64, 30))
            {
                vecesRepetido = Juego.CantidadDadosIguales(6, jugadorUno.Dados);
                puntos = 6 * vecesRepetido;
                lblDado6P1.Text = puntos.ToString();
                retorno = true;
            }
            if (lblEscaleraP1.Text == "-" && panelEscaleraP1.BackColor == Color.FromArgb(10, 64, 30))
            {
                if (Juego.EsEscalera(jugadorUno.Dados))
                {
                    if (numUD1.Value == 1)
                    {
                        lblEscaleraP1.Text = "25";
                    }
                    else
                    {
                        lblEscaleraP1.Text = "20";
                    }
                }
                else
                {
                    lblEscaleraP1.Text = "0";
                }
                retorno = true;
            }
            if (lblfullP1.Text == "-" && panelFullP1.BackColor == Color.FromArgb(10, 64, 30))
            {
                if (Juego.EsFull(jugadorUno.Dados))
                {
                    if (numUD1.Value == 1)
                    {
                        lblfullP1.Text = "35";
                    }
                    else
                    {
                        lblfullP1.Text = "30";
                    }
                }
                else
                {
                    lblfullP1.Text = "0";
                }
                retorno = true;
            }
            if (lblPokerP1.Text == "-" && panelPokerP1.BackColor == Color.FromArgb(10, 64, 30))
            {
                if (Juego.EsPoker(jugadorUno.Dados))
                {
                    if (numUD1.Value == 1)
                    {
                        lblPokerP1.Text = "45";
                    }
                    else
                    {
                        lblPokerP1.Text = "40";
                    }
                }
                else
                {
                    lblPokerP1.Text = "0";
                }
                retorno = true;
            }
            if (lblGeneralaP1.Text == "-" && panelGeneralaP1.BackColor == Color.FromArgb(10, 64, 30))
            {
                if (Juego.EsGenerala(jugadorUno.Dados))
                {
                    lblGeneralaP1.Text = "50";
                }
                else
                {
                    lblGeneralaP1.Text = "0";
                }
                retorno = true;
            }

            return retorno;
        }

        private bool CalcularPuntosJ2()
        {
            bool retorno = false;
            int vecesRepetido = 0;
            int puntos = 0;

            if (lblDado1P2.Text == "-" && panel1P2.BackColor == Color.FromArgb(10, 64, 30))
            {
                puntos = Juego.CantidadDadosIguales(1, jugadorDos.Dados);
                lblDado1P2.Text = puntos.ToString();
                retorno = true;
            }
            if (lblDado2P2.Text == "-" && panel2P2.BackColor == Color.FromArgb(10, 64, 30))
            {
                vecesRepetido = Juego.CantidadDadosIguales(2, jugadorDos.Dados);
                puntos = 2 * vecesRepetido;
                lblDado2P2.Text = puntos.ToString();
                retorno = true;
            }
            if (lblDado3P2.Text == "-" && panel3P2.BackColor == Color.FromArgb(10, 64, 30))
            {
                vecesRepetido = Juego.CantidadDadosIguales(3, jugadorDos.Dados);
                puntos = 3 * vecesRepetido;
                lblDado3P2.Text = puntos.ToString();
                retorno = true;
            }
            if (lblDado4P2.Text == "-" && panel4P2.BackColor == Color.FromArgb(10, 64, 30))
            {
                vecesRepetido = Juego.CantidadDadosIguales(4, jugadorDos.Dados);
                puntos = 4 * vecesRepetido;
                lblDado4P2.Text = puntos.ToString();
                retorno = true;
            }
            if (lblDado5P2.Text == "-" && panel5P2.BackColor == Color.FromArgb(10, 64, 30))
            {
                vecesRepetido = Juego.CantidadDadosIguales(5, jugadorDos.Dados);
                puntos = 5 * vecesRepetido;
                lblDado5P2.Text = puntos.ToString();
                retorno = true;
            }
            if (lblDado6P2.Text == "-" && panel6P2.BackColor == Color.FromArgb(10, 64, 30))
            {
                vecesRepetido = Juego.CantidadDadosIguales(6, jugadorDos.Dados);
                puntos = 6 * vecesRepetido;
                lblDado6P2.Text = puntos.ToString();
                retorno = true;
            }
            if (lblEscaleraP2.Text == "-" && panelEscaleraP2.BackColor == Color.FromArgb(10, 64, 30))
            {
                if (Juego.EsEscalera(jugadorDos.Dados))
                {
                    if (numUD2.Value == 1)
                    {
                        lblEscaleraP2.Text = "25";
                    }
                    else
                    {
                        lblEscaleraP2.Text = "20";
                    }
                }
                else
                {
                    lblEscaleraP2.Text = "0";
                }
                retorno = true;
            }
            if (lblFullP2.Text == "-" && panelFullP2.BackColor == Color.FromArgb(10, 64, 30))
            {
                if (Juego.EsFull(jugadorDos.Dados))
                {
                    if (numUD2.Value == 1)
                    {
                        lblFullP2.Text = "35";
                    }
                    else
                    {
                        lblFullP2.Text = "30";
                    }
                }
                else
                {
                    lblFullP2.Text = "0";
                }
                retorno = true;
            }
            if (lblPokerP2.Text == "-" && panelPokerP2.BackColor == Color.FromArgb(10, 64, 30))
            {
                if (Juego.EsPoker(jugadorDos.Dados))
                {
                    if (numUD2.Value == 1)
                    {
                        lblPokerP2.Text = "45";
                    }
                    else
                    {
                        lblPokerP2.Text = "40";
                    }
                }
                else
                {
                    lblPokerP2.Text = "0";
                }
                retorno = true;
            }
            if (lblGeneralaP2.Text == "-" && panelGeneralaP2.BackColor == Color.FromArgb(10, 64, 30))
            {
                if (Juego.EsGenerala(jugadorDos.Dados))
                {
                    lblGeneralaP2.Text = "50";
                }
                else
                {
                    lblGeneralaP2.Text = "0";
                }
                retorno = true;
            }

            return retorno;
        }

        public void CalcularScoreP1()
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

        public void CalcularScoreP2()
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
        }


        private void btnPasarTurno_Click(object sender, EventArgs e)
        {
            if (lblTiradas.Text == "Tirada 0/3")
            {
                MessageBox.Show("Debe tirar por lo menos una vez.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (rBtn1.Checked)
            {
                if (!CalcularPuntosJ1())
                {
                    MessageBox.Show("Debe seleccionar a que le juega.", "Error", MessageBoxButtons.OK);
                    return;
                }
                CalcularScoreP1();
                rBtn1.Checked = false;
                rBtnP2.Checked = true;
                picBP2.BackColor = Color.LightCoral;
                picBP1.BackColor = Color.FromArgb(14, 89, 41);
            }
            else if (rBtnP2.Checked)
            {
                if (!CalcularPuntosJ2())
                {
                    MessageBox.Show("Debe seleccionar a que le juega.", "Error", MessageBoxButtons.OK);
                    return;
                }
                CalcularScoreP2();
                rBtnP2.Checked = false;
                rBtn1.Checked = true;
                picBP1.BackColor = Color.LightCoral;
                picBP2.BackColor = Color.FromArgb(14, 89, 41);
            }
            numUD1.Value = 0;
            numUD2.Value = 0;
            lblTiradas.Text = "Tirada 0/3";
            btnTirar.Enabled = true;
            RestablecerDados();
            RestablecerColorDados();
        }

        private void RestablecerColorDados()
        {
            picBoxDado1.BackColor = Color.FromArgb(14, 89, 41);
            picBoxDado2.BackColor = Color.FromArgb(14, 89, 41);
            picBoxDado3.BackColor = Color.FromArgb(14, 89, 41);
            picBoxDado4.BackColor = Color.FromArgb(14, 89, 41);
            picBoxDado5.BackColor = Color.FromArgb(14, 89, 41);
        }
        private void picBoxDado1_Click(object sender, EventArgs e)
        {
            if (!(lblTiradas.Text == "Tirada 0/3"))
            {
                if (picBoxDado1.BackColor == Color.FromArgb(14, 89, 41))
                {
                    picBoxDado1.BackColor = Color.FromArgb(10, 64, 30);
                }
                else
                {
                    picBoxDado1.BackColor = Color.FromArgb(14, 89, 41);
                }
            }
        }

        private void picBoxDado2_Click(object sender, EventArgs e)
        {
            if (!(lblTiradas.Text == "Tirada 0/3"))
            {
                if (picBoxDado2.BackColor == Color.FromArgb(14, 89, 41))
                {
                    picBoxDado2.BackColor = Color.FromArgb(10, 64, 30);
                }
                else
                {
                    picBoxDado2.BackColor = Color.FromArgb(14, 89, 41);
                }
            }
        }

        private void picBoxDado3_Click(object sender, EventArgs e)
        {
            if (!(lblTiradas.Text == "Tirada 0/3"))
            {
                if (picBoxDado3.BackColor == Color.FromArgb(14, 89, 41))
                {
                    picBoxDado3.BackColor = Color.FromArgb(10, 64, 30);
                }
                else
                {
                    picBoxDado3.BackColor = Color.FromArgb(14, 89, 41);
                }
            }
        }

        private void picBoxDado4_Click(object sender, EventArgs e)
        {
            if (!(lblTiradas.Text == "Tirada 0/3"))
            {
                if (picBoxDado4.BackColor == Color.FromArgb(14, 89, 41))
                {
                    picBoxDado4.BackColor = Color.FromArgb(10, 64, 30);
                }
                else
                {
                    picBoxDado4.BackColor = Color.FromArgb(14, 89, 41);
                }
            }
        }

        private void picBoxDado5_Click(object sender, EventArgs e)
        {
            if (!(lblTiradas.Text == "Tirada 0/3"))
            {
                if (picBoxDado5.BackColor == Color.FromArgb(14, 89, 41))
                {
                    picBoxDado5.BackColor = Color.FromArgb(10, 64, 30);
                }
                else
                {
                    picBoxDado5.BackColor = Color.FromArgb(14, 89, 41);
                }
            }
        }

        private void RestablacerColorPanelJuga1()
        {
            if (lblDado1P1.Text == "-")
            {
                panel1P1.BackColor = Color.FromArgb(14, 89, 41);
            }
            if (lblDado2P1.Text == "-")
            {
                panel2P1.BackColor = Color.FromArgb(14, 89, 41);
            }
            if (lblDado3P1.Text == "-")
            {
                panel3P1.BackColor = Color.FromArgb(14, 89, 41);
            }
            if (lblDado4P1.Text == "-")
            {
                panel4P1.BackColor = Color.FromArgb(14, 89, 41);
            }
            if (lblDado5P1.Text == "-")
            {
                panel5P1.BackColor = Color.FromArgb(14, 89, 41);
            }
            if (lblDado6P1.Text == "-")
            {
                panel6P1.BackColor = Color.FromArgb(14, 89, 41);
            }
            if (lblEscaleraP1.Text == "-")
            {
                panelEscaleraP1.BackColor = Color.FromArgb(14, 89, 41);
            }
            if (lblfullP1.Text == "-")
            {
                panelFullP1.BackColor = Color.FromArgb(14, 89, 41);
            }
            if (lblPokerP1.Text == "-")
            {
                panelPokerP1.BackColor = Color.FromArgb(14, 89, 41);
            }
            if (lblGeneralaP1.Text == "-")
            {
                panelGeneralaP1.BackColor = Color.FromArgb(14, 89, 41);
            }
        }

        private void RestablacerColorPanelJuga2()
        {
            if (lblDado1P2.Text == "-")
            {
                panel1P2.BackColor = Color.FromArgb(14, 89, 41);
            }
            if (lblDado2P2.Text == "-")
            {
                panel2P2.BackColor = Color.FromArgb(14, 89, 41);
            }
            if (lblDado3P2.Text == "-")
            {
                panel3P2.BackColor = Color.FromArgb(14, 89, 41);
            }
            if (lblDado4P2.Text == "-")
            {
                panel4P2.BackColor = Color.FromArgb(14, 89, 41);
            }
            if (lblDado5P2.Text == "-")
            {
                panel5P2.BackColor = Color.FromArgb(14, 89, 41);
            }
            if (lblDado6P2.Text == "-")
            {
                panel6P2.BackColor = Color.FromArgb(14, 89, 41);
            }
            if (lblEscaleraP2.Text == "-")
            {
                panelEscaleraP2.BackColor = Color.FromArgb(14, 89, 41);
            }
            if (lblFullP2.Text == "-")
            {
                panelFullP2.BackColor = Color.FromArgb(14, 89, 41);
            }
            if (lblPokerP2.Text == "-")
            {
                panelPokerP2.BackColor = Color.FromArgb(14, 89, 41);
            }
            if (lblGeneralaP2.Text == "-")
            {
                panelGeneralaP2.BackColor = Color.FromArgb(14, 89, 41);
            }
        }
        private void panel1P1_Click(object sender, EventArgs e)
        {
            if (rBtn1.Checked)
            {
                RestablacerColorPanelJuga1();
                panel1P1.BackColor = Color.FromArgb(10, 64, 30);
            }
        }

        private void panel2P1_Click(object sender, EventArgs e)
        {
            if (rBtn1.Checked)
            {
                RestablacerColorPanelJuga1();
                panel2P1.BackColor = Color.FromArgb(10, 64, 30);
            }
        }

        private void panel3P1_Click(object sender, EventArgs e)
        {
            if (rBtn1.Checked)
            {
                RestablacerColorPanelJuga1();
                panel3P1.BackColor = Color.FromArgb(10, 64, 30);
            }
        }

        private void panel4P1_Click(object sender, EventArgs e)
        {
            if (rBtn1.Checked)
            {
                RestablacerColorPanelJuga1();
                panel4P1.BackColor = Color.FromArgb(10, 64, 30);
            }
        }

        private void panel5P1_Click(object sender, EventArgs e)
        {
            if (rBtn1.Checked)
            {
                RestablacerColorPanelJuga1();
                panel5P1.BackColor = Color.FromArgb(10, 64, 30);
            }
        }

        private void panel6P1_Click(object sender, EventArgs e)
        {
            if (rBtn1.Checked)
            {
                RestablacerColorPanelJuga1();
                panel6P1.BackColor = Color.FromArgb(10, 64, 30);
            }
        }

        private void panelEscaleraP1_Click(object sender, EventArgs e)
        {
            if (rBtn1.Checked)
            {
                RestablacerColorPanelJuga1();
                panelEscaleraP1.BackColor = Color.FromArgb(10, 64, 30);
            }
        }

        private void panelFullP1_Click(object sender, EventArgs e)
        {
            if (rBtn1.Checked)
            {
                RestablacerColorPanelJuga1();
                panelFullP1.BackColor = Color.FromArgb(10, 64, 30);
            }
        }

        private void panelPokerP1_Click(object sender, EventArgs e)
        {
            if (rBtn1.Checked)
            {
                RestablacerColorPanelJuga1();
                panelPokerP1.BackColor = Color.FromArgb(10, 64, 30);
            }
        }

        private void panelGeneralaP1_Click(object sender, EventArgs e)
        {
            if (rBtn1.Checked)
            {
                RestablacerColorPanelJuga1();
                panelGeneralaP1.BackColor = Color.FromArgb(10, 64, 30);
            }
        }

        private void panel1P2_Click(object sender, EventArgs e)
        {
            if (rBtnP2.Checked)
            {
                RestablacerColorPanelJuga2();
                panel1P2.BackColor = Color.FromArgb(10, 64, 30);
            }
        }

        private void panel2P2_Click(object sender, EventArgs e)
        {
            if (rBtnP2.Checked)
            {
                RestablacerColorPanelJuga2();
                panel2P2.BackColor = Color.FromArgb(10, 64, 30);
            }
        }

        private void panel3P2_Click(object sender, EventArgs e)
        {
            if (rBtnP2.Checked)
            {
                RestablacerColorPanelJuga2();
                panel3P2.BackColor = Color.FromArgb(10, 64, 30);
            }
        }

        private void panel4P2_Click(object sender, EventArgs e)
        {
            if (rBtnP2.Checked)
            {
                RestablacerColorPanelJuga2();
                panel4P2.BackColor = Color.FromArgb(10, 64, 30);
            }
        }

        private void panel5P2_Click(object sender, EventArgs e)
        {
            if (rBtnP2.Checked)
            {
                RestablacerColorPanelJuga2();
                panel5P2.BackColor = Color.FromArgb(10, 64, 30);
            }
        }

        private void panel6P2_Click(object sender, EventArgs e)
        {
            if (rBtnP2.Checked)
            {
                RestablacerColorPanelJuga2();
                panel6P2.BackColor = Color.FromArgb(10, 64, 30);
            }
        }

        private void panelEscaleraP2_Click(object sender, EventArgs e)
        {
            if (rBtnP2.Checked)
            {
                RestablacerColorPanelJuga2();
                panelEscaleraP2.BackColor = Color.FromArgb(10, 64, 30);
            }
        }

        private void panelFullP2_Click(object sender, EventArgs e)
        {
            if (rBtnP2.Checked)
            {
                RestablacerColorPanelJuga2();
                panelFullP2.BackColor = Color.FromArgb(10, 64, 30);
            }
        }

        private void panelPokerP2_Click(object sender, EventArgs e)
        {
            if (rBtnP2.Checked)
            {
                RestablacerColorPanelJuga2();
                panelPokerP2.BackColor = Color.FromArgb(10, 64, 30);
            }
        }

        private void panelGeneralaP2_Click(object sender, EventArgs e)
        {
            if (rBtnP2.Checked)
            {
                RestablacerColorPanelJuga2();
                panelGeneralaP2.BackColor = Color.FromArgb(10, 64, 30);
            }
        }

        public void Ganador()
        {
            int contador = 0;
            int contadorLblPuntos = 0;

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
                    contadorLblPuntos ++;
                }
            }
            Panel[] panelesJuga2 = new Panel[]
            {
                panel1P2,
                panel2P2,
                panel3P2,
                panel4P2,
                panel5P2,
                panel6P2,
                panelEscaleraP2,
                panelFullP2,
                panelPokerP2,
                panelGeneralaP2
            };

            foreach (Panel item in panelesJuga2)
            {
                if (item.BackColor == Color.FromArgb(10, 64, 30))
                {
                    contador++;
                }
            }

            if(contador == 10 && contadorLblPuntos == 10)
            {
                checkPartida = false;
                terminoLaPartida = true;
                if (partida.PuntosJugadorUno > partida.PuntosJugadorDos)
                {
                    partida.Ganador = jugadorUno.Nombre;
                    partida.Perdedor = jugadorDos.Nombre;
                    jugadorUno.PartidasGanadas++;
                }
                else if (partida.PuntosJugadorUno < partida.PuntosJugadorDos)
                {
                    partida.Ganador = jugadorDos.Nombre;
                    partida.Perdedor = jugadorUno.Nombre;
                    jugadorUno.PartidasPerdidas++;
                }
                else
                {
                    partida.Ganador = "EMPATE";
                    partida.Perdedor = "EMPATE";
                }
                Juego partidaDB = new Juego(jugadorUno.Nombre, jugadorDos.Nombre, partida.PuntosJugadorUno, partida.PuntosJugadorDos, partida.Ganador, partida.Perdedor, jugadorUno.PartidasGanadas, jugadorUno.PartidasPerdidas);
                PartidaDAO.GuardarPartida(partidaDB);
                FrmGanador frmGanador = new FrmGanador(partida);
                frmGanador.ShowDialog();
            }

        }

        private void FrmJuego_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!terminoLaPartida)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de abandonar el juego? Se cancelara la partida.", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
