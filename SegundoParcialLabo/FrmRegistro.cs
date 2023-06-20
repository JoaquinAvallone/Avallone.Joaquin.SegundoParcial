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
    public partial class FrmRegistro : Form
    {
        List<Usuario>? usuarios;
        List<Jugador>? jugadores;
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            Serializador<Jugador> serializador = new Serializador<Jugador>();
            usuarios = UsuarioDAO.ListaUsuarios();
            jugadores = serializador.DeserializarJugadoresJson();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Serializador<Usuario> serializador = new Serializador<Usuario>();
            FrmPrincipal principal = new FrmPrincipal();
            string nombreCompleto = txtBNombreCompleto.Text;
            string nombreUsuario = txtBNombreUsuario.Text;
            string email = txtBEmail.Text;
            string contraseña = txtBContraseña.Text;

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
                if (nombreUsuario == item.NombreUsuario)
                {
                    MessageBox.Show("El nombre de usuario ya existe, ingrese otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            foreach (Jugador item in jugadores)
            {
                if (nombreUsuario == item.Nombre)
                {
                    MessageBox.Show("El nombre de usuario ya existe, ingrese otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (contraseña == txtBConfirmaContra.Text)
            {
                Usuario nuevoUsuario = new Usuario(nombreCompleto, nombreUsuario, email, contraseña);
                UsuarioDAO.GuardarUsuario(nuevoUsuario);
                MessageBox.Show("Se ha registrado con éxito.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                serializador.SerializarJson("UsuarioActual.json", nuevoUsuario);
                this.Hide();
                principal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmLogIn frmLogIn = new FrmLogIn();
            this.Hide();
            frmLogIn.ShowDialog();
            this.Close();
        }

        private void txtBNombreCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Solo se acepta el ingreso de letras.");
                e.Handled = true;
            }
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

        private void txtBNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("No se permite el uso de espacios.");
                e.Handled = true;
            }
        }
    }
}
