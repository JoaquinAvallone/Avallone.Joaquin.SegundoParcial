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
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            usuarios = new List<Usuario>();
            usuarios = UsuarioDAO.ListaUsuarios();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
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
                    Serializador.SerializarJson("UsuarioActual.json", item);
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
    }
}
