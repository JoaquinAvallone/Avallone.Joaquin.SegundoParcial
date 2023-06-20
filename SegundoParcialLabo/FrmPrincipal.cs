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
    public delegate void DelegadoPanel(Form formulario);
    public partial class FrmPrincipal : Form
    {
        Form? formularioAbierto = null;
        Usuario? usuarioActual;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Serializador<Usuario> serializador = new Serializador<Usuario>();
            usuarioActual = serializador.DeserializarUsuarioActualJson();
            this.Text = "La Generala - " + usuarioActual.NombreUsuario;
            Jugador jugadorUno = new Jugador(usuarioActual.NombreUsuario);
            serializador.SerializarJson("JugadorUno.json", jugadorUno);
        }

        private void btnPVP_Click(object sender, EventArgs e)
        {
            Task hilo = new Task(() => { CerrarForm(formularioAbierto); AbrirFormulario<FrmPlayerVsPlayer>(); });
            hilo.Start();
        }

        private void btnPc_Click(object sender, EventArgs e)
        {
            Task hilo = new Task(() => { CerrarForm(formularioAbierto); AbrirFormulario<FrmPcVsPc>(); });
            hilo.Start();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Task hilo = new Task(() => { CerrarForm(formularioAbierto); AbrirFormulario<FrmHistorial>(); });
            hilo.Start();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form? formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                AbrirFormPanel(formulario);
                panelFormularios.Tag = formulario;
                formularioAbierto = formulario;
            }
            else
            {
                formulario.BringToFront();
                formularioAbierto = formulario;
            }

        }

        private void AbrirFormPanel(Form formulario)
        {
            if (InvokeRequired)
            {
                DelegadoPanel delegado = AbrirFormPanel;
                object[] parametros = { formulario };
                Invoke(delegado, parametros);
            }
            else
            {
                panelFormularios.Controls.Add(formulario);
                formulario.Show();
                formulario.BringToFront();
            }
        }

        private void CerrarForm(Form formulario)
        {
            if (InvokeRequired)
            {
                DelegadoPanel delegado = CerrarForm;
                object[] parametros = { formulario };
                Invoke(delegado, parametros);
            }
            else
            {
                if (formularioAbierto != null)
                {
                    formularioAbierto.Close();
                    formularioAbierto = null;
                }
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea abandonar la aplicacion?", "La Generala", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
