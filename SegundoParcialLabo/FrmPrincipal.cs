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
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            usuarioActual = Serializador.DeserializarUsuarioActualJson();
            this.Text = "La Generala - " + usuarioActual.NombreUsuario;
        }
    }
}
