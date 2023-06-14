namespace SegundoParcialLabo
{
    partial class FrmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            panelLogo = new Panel();
            lblGenerala = new Label();
            picBoxLogo = new PictureBox();
            btnCancelar = new Button();
            panel4 = new Panel();
            txtBConfirmaContra = new TextBox();
            btnRegistro = new Button();
            panel3 = new Panel();
            txtBContraseña = new TextBox();
            panel1 = new Panel();
            txtBEmail = new TextBox();
            panel2 = new Panel();
            txtBNombreUsuario = new TextBox();
            panelEmail = new Panel();
            txtBNombreCompleto = new TextBox();
            pictureBMinimize = new PictureBox();
            pictureBEscape = new PictureBox();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBEscape).BeginInit();
            SuspendLayout();
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(14, 89, 41);
            panelLogo.Controls.Add(lblGenerala);
            panelLogo.Controls.Add(picBoxLogo);
            panelLogo.Dock = DockStyle.Left;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(169, 260);
            panelLogo.TabIndex = 2;
            // 
            // lblGenerala
            // 
            lblGenerala.AutoSize = true;
            lblGenerala.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblGenerala.ForeColor = Color.FromArgb(20, 20, 20);
            lblGenerala.Location = new Point(37, 155);
            lblGenerala.Name = "lblGenerala";
            lblGenerala.Size = new Size(94, 21);
            lblGenerala.TabIndex = 14;
            lblGenerala.Text = "La Generala";
            // 
            // picBoxLogo
            // 
            picBoxLogo.Image = (Image)resources.GetObject("picBoxLogo.Image");
            picBoxLogo.Location = new Point(39, 68);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(90, 91);
            picBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxLogo.TabIndex = 1;
            picBoxLogo.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Gray;
            btnCancelar.Location = new Point(384, 217);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 26);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(215, 197);
            panel4.Name = "panel4";
            panel4.Size = new Size(329, 1);
            panel4.TabIndex = 36;
            // 
            // txtBConfirmaContra
            // 
            txtBConfirmaContra.BackColor = Color.FromArgb(20, 20, 20);
            txtBConfirmaContra.BorderStyle = BorderStyle.None;
            txtBConfirmaContra.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBConfirmaContra.ForeColor = SystemColors.Window;
            txtBConfirmaContra.Location = new Point(218, 175);
            txtBConfirmaContra.Name = "txtBConfirmaContra";
            txtBConfirmaContra.PlaceholderText = "Confirmar Contraseña";
            txtBConfirmaContra.Size = new Size(181, 15);
            txtBConfirmaContra.TabIndex = 35;
            // 
            // btnRegistro
            // 
            btnRegistro.Cursor = Cursors.Hand;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistro.ForeColor = Color.Gray;
            btnRegistro.Location = new Point(215, 217);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(160, 26);
            btnRegistro.TabIndex = 34;
            btnRegistro.Text = "Registrarse";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(215, 157);
            panel3.Name = "panel3";
            panel3.Size = new Size(329, 1);
            panel3.TabIndex = 33;
            // 
            // txtBContraseña
            // 
            txtBContraseña.BackColor = Color.FromArgb(20, 20, 20);
            txtBContraseña.BorderStyle = BorderStyle.None;
            txtBContraseña.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBContraseña.ForeColor = SystemColors.Window;
            txtBContraseña.Location = new Point(218, 135);
            txtBContraseña.Name = "txtBContraseña";
            txtBContraseña.PlaceholderText = "Contraseña";
            txtBContraseña.Size = new Size(181, 15);
            txtBContraseña.TabIndex = 32;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(215, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 1);
            panel1.TabIndex = 31;
            // 
            // txtBEmail
            // 
            txtBEmail.BackColor = Color.FromArgb(20, 20, 20);
            txtBEmail.BorderStyle = BorderStyle.None;
            txtBEmail.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBEmail.ForeColor = SystemColors.Window;
            txtBEmail.Location = new Point(218, 97);
            txtBEmail.Name = "txtBEmail";
            txtBEmail.PlaceholderText = "Email";
            txtBEmail.Size = new Size(181, 15);
            txtBEmail.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(215, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(329, 1);
            panel2.TabIndex = 29;
            // 
            // txtBNombreUsuario
            // 
            txtBNombreUsuario.BackColor = Color.FromArgb(20, 20, 20);
            txtBNombreUsuario.BorderStyle = BorderStyle.None;
            txtBNombreUsuario.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBNombreUsuario.ForeColor = SystemColors.Window;
            txtBNombreUsuario.Location = new Point(218, 57);
            txtBNombreUsuario.Name = "txtBNombreUsuario";
            txtBNombreUsuario.PlaceholderText = "Nombre Usuario";
            txtBNombreUsuario.Size = new Size(181, 15);
            txtBNombreUsuario.TabIndex = 28;
            // 
            // panelEmail
            // 
            panelEmail.BackColor = Color.White;
            panelEmail.Location = new Point(215, 41);
            panelEmail.Name = "panelEmail";
            panelEmail.Size = new Size(329, 1);
            panelEmail.TabIndex = 27;
            // 
            // txtBNombreCompleto
            // 
            txtBNombreCompleto.BackColor = Color.FromArgb(20, 20, 20);
            txtBNombreCompleto.BorderStyle = BorderStyle.None;
            txtBNombreCompleto.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBNombreCompleto.ForeColor = SystemColors.Window;
            txtBNombreCompleto.Location = new Point(218, 19);
            txtBNombreCompleto.Name = "txtBNombreCompleto";
            txtBNombreCompleto.PlaceholderText = "Nombre Completo";
            txtBNombreCompleto.Size = new Size(181, 15);
            txtBNombreCompleto.TabIndex = 26;
            txtBNombreCompleto.KeyPress += txtBNombreCompleto_KeyPress;
            // 
            // pictureBMinimize
            // 
            pictureBMinimize.Image = (Image)resources.GetObject("pictureBMinimize.Image");
            pictureBMinimize.Location = new Point(536, 6);
            pictureBMinimize.Name = "pictureBMinimize";
            pictureBMinimize.Size = new Size(17, 17);
            pictureBMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBMinimize.TabIndex = 39;
            pictureBMinimize.TabStop = false;
            pictureBMinimize.Click += pictureBMinimize_Click;
            // 
            // pictureBEscape
            // 
            pictureBEscape.Image = (Image)resources.GetObject("pictureBEscape.Image");
            pictureBEscape.Location = new Point(559, 6);
            pictureBEscape.Name = "pictureBEscape";
            pictureBEscape.Size = new Size(17, 17);
            pictureBEscape.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBEscape.TabIndex = 38;
            pictureBEscape.TabStop = false;
            pictureBEscape.Click += pictureBEscape_Click;
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(585, 260);
            Controls.Add(pictureBMinimize);
            Controls.Add(pictureBEscape);
            Controls.Add(btnCancelar);
            Controls.Add(panel4);
            Controls.Add(txtBConfirmaContra);
            Controls.Add(btnRegistro);
            Controls.Add(panel3);
            Controls.Add(txtBContraseña);
            Controls.Add(panel1);
            Controls.Add(txtBEmail);
            Controls.Add(panel2);
            Controls.Add(txtBNombreUsuario);
            Controls.Add(panelEmail);
            Controls.Add(txtBNombreCompleto);
            Controls.Add(panelLogo);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmRegistro";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegistro";
            Load += FrmRegistro_Load;
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBEscape).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLogo;
        private Label lblGenerala;
        private PictureBox picBoxLogo;
        private Button btnCancelar;
        private Panel panel4;
        public TextBox txtBConfirmaContra;
        private Button btnRegistro;
        private Panel panel3;
        public TextBox txtBContraseña;
        private Panel panel1;
        public TextBox txtBEmail;
        private Panel panel2;
        private TextBox txtBNombreUsuario;
        private Panel panelEmail;
        public TextBox txtBNombreCompleto;
        private PictureBox pictureBMinimize;
        private PictureBox pictureBEscape;
    }
}