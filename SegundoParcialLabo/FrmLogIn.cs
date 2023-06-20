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
    public partial class FrmLogIn : Form
    {
        List<Usuario>? usuarios;
        List<Jugador> jugadores;
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            usuarios = UsuarioDAO.ListaUsuarios();
            jugadores = new List<Jugador>();
            Serializador<Jugador> serializador = new Serializador<Jugador>();

            if (!File.Exists("Jugadores.json"))
            {
                jugadores = Hardcode.HardcodeJugadores();
                serializador.SerializarJson("Jugadores.json", jugadores);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Serializador<Usuario> serializador = new Serializador<Usuario>();
            FrmPrincipal principal = new FrmPrincipal();
            bool flagIngreso = false;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox && control.Text == "")
                {
                    MessageBox.Show("Debe ingresar todos los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            foreach (Usuario item in usuarios)
            {
                if (item.Contraseña == txtBContraseña.Text && item.NombreUsuario == txtBNombreUsuario.Text)
                {
                    serializador.SerializarJson("UsuarioActual.json", item);
                    this.Hide();
                    principal.ShowDialog();
                    this.Close();
                    flagIngreso = true;
                }
            }
            if (!flagIngreso)
            {
                MessageBox.Show("Email o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FrmRegistro frmRegistro = new FrmRegistro();
            this.Hide();
            frmRegistro.ShowDialog();
            this.Close();
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

        private void picBEye_Click(object sender, EventArgs e)
        {
            txtBContraseña.UseSystemPasswordChar = false;
            picBEye.Visible = false;
            picBEyeBlind.Visible = true;
        }

        private void picBEyeBlind_Click(object sender, EventArgs e)
        {
            txtBContraseña.UseSystemPasswordChar = true;
            picBEye.Visible = true;
            picBEyeBlind.Visible = false;
        }

        private void txtBContraseña_TextChanged(object sender, EventArgs e)
        {
            if (Text != null)
            {
                picBEye.Visible = true;
            }
        }
    }
}
