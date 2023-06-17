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
    public partial class FrmPcVsPc : Form
    {
        Usuario? usuarioActual;
        List<Jugador>? jugadores;
        public FrmPcVsPc()
        {
            InitializeComponent();
        }

        private void FrmPcVsPc_Load(object sender, EventArgs e)
        {
            usuarioActual = Serializador.DeserializarUsuarioActualJson();
            jugadores = Serializador.DeserializarJugadoresJson();
            RellenarComboB();
        }

        public void RellenarComboB()
        {
            foreach (Jugador item in jugadores)
            {
                comboBDos.Items.Add(item.Nombre);
            }
            comboBUno.Items.Add(usuarioActual.NombreUsuario);
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

            FrmJuegoPc frmJuegoPc = new FrmJuegoPc();
            frmJuegoPc.Show();
        }
    }
}
