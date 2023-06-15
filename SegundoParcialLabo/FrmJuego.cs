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
    public partial class FrmJuego : Form
    {
        Jugador? jugadorUno;
        Jugador? jugadorDos;
        public FrmJuego()
        {
            InitializeComponent();
        }

        private void FrmJuego_Load(object sender, EventArgs e)
        {
            jugadorUno = Serializador.DeserializarJugadorUnoJson();
            jugadorDos = Serializador.DeserializarJugadorDosJson();

            lblPlayer1.Text = jugadorUno.Nombre;
            lblPlayer2.Text = jugadorDos.Nombre;
        }

        //public void CargarDados()
        //{
        //    int[] dados = new int[5];

        //    dados = Jugador.TirarDados();

        //    picBoxDado1.ImageLocation = "dados/dado" + dados[0];
        //    picBoxDado2.ImageLocation = "dados/dado" + dados[1];
        //    picBoxDado3.ImageLocation = "dados/dado" + dados[2];
        //    picBoxDado4.ImageLocation = "dados/dado" + dados[3];
        //    picBoxDado5.ImageLocation = "dados/dado" + dados[4];
        //    picBoxDado6.ImageLocation = "dados/dado" + dados[5];
        //}

        private void btnTirar_Click(object sender, EventArgs e)
        {
            //CargarDados();
        }
    }
}
