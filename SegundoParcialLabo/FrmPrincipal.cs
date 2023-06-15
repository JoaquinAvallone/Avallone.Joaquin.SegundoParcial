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

namespace SegundoParcialLabo
{
    public partial class FrmPrincipal : Form
    {
        Usuario? usuarioActual;
        List<Jugador>? jugadores;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            usuarioActual = Serializador.DeserializarUsuarioActualJson();
            jugadores = Serializador.DeserializarJugadoresJson();
            panelPrincipal.Visible = false;
            RellenarComboB();
        }

        public void RellenarComboB()
        {
            foreach(Jugador item in jugadores)
            {
                comboBDos.Items.Add(item.Nombre);
            }
            comboBUno.Items.Add(usuarioActual.NombreUsuario);
        }

        private void btnPVP_Click(object sender, EventArgs e)
        {
            panelPrincipal.Visible = true;
        }

        private void btnPc_Click(object sender, EventArgs e)
        {
            panelPrincipal.Visible = true;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Jugador jugadorUno = new Jugador(usuarioActual.NombreUsuario);
            Jugador jugadorDos = new Jugador(comboBDos.Text);
            if (comboBUno.Text == "" || comboBDos.Text == "")
            {
                MessageBox.Show("Debe elegir ambos jugadores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Serializador.SerializarJson("JugadorUno.json", jugadorUno);
            Serializador.SerializarJson("JugadorDos.json", jugadorDos);
            FrmJuego frmJuego = new FrmJuego();

            frmJuego.ShowDialog();         
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelPrincipal.Visible = false;
        }

        private void pictureBEscape_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea abandonar la aplicacion?", "La Generala", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
