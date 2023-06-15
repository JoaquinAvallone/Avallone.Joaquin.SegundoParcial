namespace SegundoParcialLabo
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            lblGenerala = new Label();
            btnPVP = new Button();
            btnPc = new Button();
            btnHistorial = new Button();
            pictureBMinimize = new PictureBox();
            pictureBEscape = new PictureBox();
            panelPrincipal = new Panel();
            btnCancelar = new Button();
            comboBUno = new ComboBox();
            btnJugar = new Button();
            comboBDos = new ComboBox();
            lblJugador2 = new Label();
            lblJugador1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBEscape).BeginInit();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // lblGenerala
            // 
            lblGenerala.AutoSize = true;
            lblGenerala.Font = new Font("Sylfaen", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenerala.ForeColor = Color.WhiteSmoke;
            lblGenerala.Location = new Point(65, 28);
            lblGenerala.Name = "lblGenerala";
            lblGenerala.Size = new Size(207, 46);
            lblGenerala.TabIndex = 0;
            lblGenerala.Text = "La Generala";
            // 
            // btnPVP
            // 
            btnPVP.FlatAppearance.BorderSize = 0;
            btnPVP.FlatStyle = FlatStyle.Popup;
            btnPVP.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPVP.ForeColor = Color.WhiteSmoke;
            btnPVP.Location = new Point(99, 125);
            btnPVP.Name = "btnPVP";
            btnPVP.Size = new Size(136, 39);
            btnPVP.TabIndex = 1;
            btnPVP.Text = "PLAYER vs PLAYER";
            btnPVP.UseVisualStyleBackColor = true;
            btnPVP.Click += btnPVP_Click;
            // 
            // btnPc
            // 
            btnPc.FlatAppearance.BorderSize = 0;
            btnPc.FlatStyle = FlatStyle.Popup;
            btnPc.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPc.ForeColor = Color.WhiteSmoke;
            btnPc.Location = new Point(99, 170);
            btnPc.Name = "btnPc";
            btnPc.Size = new Size(136, 39);
            btnPc.TabIndex = 2;
            btnPc.Text = "PC vs PC";
            btnPc.UseVisualStyleBackColor = true;
            btnPc.Click += btnPc_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.FlatAppearance.BorderSize = 0;
            btnHistorial.FlatStyle = FlatStyle.Popup;
            btnHistorial.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistorial.ForeColor = Color.WhiteSmoke;
            btnHistorial.Location = new Point(99, 215);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(136, 39);
            btnHistorial.TabIndex = 3;
            btnHistorial.Text = "HISTORIAL";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // pictureBMinimize
            // 
            pictureBMinimize.Image = (Image)resources.GetObject("pictureBMinimize.Image");
            pictureBMinimize.Location = new Point(287, 7);
            pictureBMinimize.Name = "pictureBMinimize";
            pictureBMinimize.Size = new Size(17, 17);
            pictureBMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBMinimize.TabIndex = 17;
            pictureBMinimize.TabStop = false;
            pictureBMinimize.Click += pictureBMinimize_Click;
            // 
            // pictureBEscape
            // 
            pictureBEscape.Image = (Image)resources.GetObject("pictureBEscape.Image");
            pictureBEscape.Location = new Point(310, 7);
            pictureBEscape.Name = "pictureBEscape";
            pictureBEscape.Size = new Size(17, 17);
            pictureBEscape.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBEscape.TabIndex = 16;
            pictureBEscape.TabStop = false;
            pictureBEscape.Click += pictureBEscape_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(btnCancelar);
            panelPrincipal.Controls.Add(comboBUno);
            panelPrincipal.Controls.Add(btnJugar);
            panelPrincipal.Controls.Add(comboBDos);
            panelPrincipal.Controls.Add(lblJugador2);
            panelPrincipal.Controls.Add(lblJugador1);
            panelPrincipal.Location = new Point(1, 77);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(336, 246);
            panelPrincipal.TabIndex = 18;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.WhiteSmoke;
            btnCancelar.Location = new Point(98, 186);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(136, 39);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // comboBUno
            // 
            comboBUno.FormattingEnabled = true;
            comboBUno.Location = new Point(11, 68);
            comboBUno.Name = "comboBUno";
            comboBUno.Size = new Size(142, 23);
            comboBUno.TabIndex = 6;
            // 
            // btnJugar
            // 
            btnJugar.FlatAppearance.BorderSize = 0;
            btnJugar.FlatStyle = FlatStyle.Popup;
            btnJugar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnJugar.ForeColor = Color.WhiteSmoke;
            btnJugar.Location = new Point(98, 129);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(136, 39);
            btnJugar.TabIndex = 5;
            btnJugar.Text = "JUGAR";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnJugar_Click;
            // 
            // comboBDos
            // 
            comboBDos.FormattingEnabled = true;
            comboBDos.Location = new Point(184, 68);
            comboBDos.Name = "comboBDos";
            comboBDos.Size = new Size(142, 23);
            comboBDos.TabIndex = 3;
            // 
            // lblJugador2
            // 
            lblJugador2.AutoSize = true;
            lblJugador2.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblJugador2.ForeColor = Color.WhiteSmoke;
            lblJugador2.Location = new Point(202, 39);
            lblJugador2.Name = "lblJugador2";
            lblJugador2.Size = new Size(101, 22);
            lblJugador2.TabIndex = 2;
            lblJugador2.Text = "Jugador Dos";
            // 
            // lblJugador1
            // 
            lblJugador1.AutoSize = true;
            lblJugador1.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblJugador1.ForeColor = Color.WhiteSmoke;
            lblJugador1.Location = new Point(32, 39);
            lblJugador1.Name = "lblJugador1";
            lblJugador1.Size = new Size(103, 22);
            lblJugador1.TabIndex = 1;
            lblJugador1.Text = "Jugador Uno";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 89, 41);
            ClientSize = new Size(337, 323);
            Controls.Add(panelPrincipal);
            Controls.Add(btnPVP);
            Controls.Add(btnHistorial);
            Controls.Add(pictureBMinimize);
            Controls.Add(btnPc);
            Controls.Add(pictureBEscape);
            Controls.Add(lblGenerala);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBEscape).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGenerala;
        private Button btnPVP;
        private Button btnPc;
        private Button btnHistorial;
        private PictureBox pictureBMinimize;
        private PictureBox pictureBEscape;
        private Panel panelPrincipal;
        private Label lblJugador2;
        private Label lblJugador1;
        private Button btnCancelar;
        private ComboBox comboBUno;
        private Button btnJugar;
        private ComboBox comboBDos;
    }
}