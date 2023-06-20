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
using Biblioteca;

namespace SegundoParcialLabo
{
    public partial class FrmHistorial : Form
    {
        Jugador? jugador;
        List<Juego> listaPartidas;
        public FrmHistorial()
        {
            InitializeComponent();
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            jugador = Serializador.DeserializarJugadorUnoJson();
            listaPartidas = new List<Juego>();
            lblAviso.Visible = false;
            RellenarGrid();
        }

        private void RellenarGrid()
        {
            dataGVPartidas.Rows.Clear();
            listaPartidas = PartidaDAO.ListaPartidas(jugador.Nombre);
            int partidasGanadas = 0;
            int partidasPerdidas = 0;

            if (listaPartidas.Count > 0)
            {
                dataGVPartidas.Visible = true;
                lblGandas.Visible = true;
                lblPerdidas.Visible = true;
                foreach (Juego item in listaPartidas)
                {
                    int rowIndex = dataGVPartidas.Rows.Add();
                    DataGridViewRow row = dataGVPartidas.Rows[rowIndex];
                    row.Cells[0].Value = item.Id;
                    row.Cells[1].Value = item.JugadorUno.Nombre;
                    row.Cells[2].Value = item.JugadorDos.Nombre;
                    row.Cells[3].Value = item.PuntosJugadorUno;
                    row.Cells[4].Value = item.PuntosJugadorDos;
                    row.Cells[5].Value = item.Ganador;
                    row.Cells[6].Value = item.Perdedor;
                    partidasGanadas += item.JugadorUno.PartidasGanadas;
                    partidasPerdidas += item.JugadorUno.PartidasPerdidas;
                }
                lblGandas.Text = "Partidas ganadas: " + partidasGanadas;
                lblPerdidas.Text = "Partidas perdidas: " + partidasPerdidas;
            }
            else
            {
                dataGVPartidas.Visible = false;
                lblGandas.Visible = false;
                lblPerdidas.Visible = false;
                lblAviso.Visible = true;
            }

            ;
        }
    }
}
