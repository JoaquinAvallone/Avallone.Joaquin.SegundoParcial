namespace SegundoParcialLabo
{
    partial class FrmGanador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGanador));
            lblTitulo = new Label();
            lblPuntosGanador = new Label();
            lblPuntosPerdedor = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Cascadia Code", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(91, 31);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(89, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ganador";
            // 
            // lblPuntosGanador
            // 
            lblPuntosGanador.AutoSize = true;
            lblPuntosGanador.Font = new Font("Cascadia Code", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPuntosGanador.ForeColor = Color.WhiteSmoke;
            lblPuntosGanador.Location = new Point(12, 92);
            lblPuntosGanador.Name = "lblPuntosGanador";
            lblPuntosGanador.Size = new Size(78, 25);
            lblPuntosGanador.TabIndex = 1;
            lblPuntosGanador.Text = "Puntos";
            // 
            // lblPuntosPerdedor
            // 
            lblPuntosPerdedor.AutoSize = true;
            lblPuntosPerdedor.Font = new Font("Cascadia Code", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPuntosPerdedor.ForeColor = Color.WhiteSmoke;
            lblPuntosPerdedor.Location = new Point(12, 130);
            lblPuntosPerdedor.Name = "lblPuntosPerdedor";
            lblPuntosPerdedor.Size = new Size(78, 25);
            lblPuntosPerdedor.TabIndex = 2;
            lblPuntosPerdedor.Text = "Puntos";
            // 
            // FrmGanador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 51, 24);
            ClientSize = new Size(426, 170);
            Controls.Add(lblPuntosPerdedor);
            Controls.Add(lblPuntosGanador);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(442, 209);
            MinimumSize = new Size(442, 209);
            Name = "FrmGanador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ganador";
            Load += FrmGanador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblPuntosGanador;
        private Label lblPuntosPerdedor;
    }
}