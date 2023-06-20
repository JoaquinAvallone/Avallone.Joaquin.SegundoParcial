using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace SegundoParcialLabo
{
    public partial class FrmGanador : Form
    {
        Juego partida;
        public FrmGanador(Juego juego)
        {
            InitializeComponent();
            partida = juego;
        }

        private void FrmGanador_Load(object sender, EventArgs e)
        {
            RellenarLbls();
        }

        private void RellenarLbls()
        {
            lblTitulo.Text = "GANADOR " + partida.Ganador;
            if (partida.Ganador == partida.JugadorUno.Nombre)
            {
                lblPuntosGanador.Text = "Puntos " + partida.Ganador + " " + partida.PuntosJugadorUno;
                lblPuntosPerdedor.Text = "Puntos " + partida.Perdedor + " " + partida.PuntosJugadorDos;
            }
            else
            {
                lblPuntosGanador.Text = "Puntos " + partida.Ganador + " " + partida.PuntosJugadorDos;
                lblPuntosPerdedor.Text = "Puntos " + partida.Perdedor + " " + partida.PuntosJugadorUno;
            }
        }
    }
}
