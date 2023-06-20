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
    public partial class FrmPlayerVsPlayer : Form
    {
        Usuario? usuarioActual;
        List<Jugador>? jugadores;
        Serializador<Jugador> serializadorJuga;
        public FrmPlayerVsPlayer()
        {
            InitializeComponent();
        }

        private void FrmPlayerVsPlayer_Load(object sender, EventArgs e)
        {
            serializadorJuga = new Serializador<Jugador>();
            Serializador<Usuario> serializadorUser = new Serializador<Usuario>();
            usuarioActual = serializadorUser.DeserializarUsuarioActualJson();
            jugadores = serializadorJuga.DeserializarJugadoresJson();
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
            serializadorJuga.SerializarJson("JugadorUno.json", jugadorUno);
            serializadorJuga.SerializarJson("JugadorDos.json", jugadorDos);
            FrmJuego frmJuego = new FrmJuego();

            frmJuego.Show();
        }
    }
}
