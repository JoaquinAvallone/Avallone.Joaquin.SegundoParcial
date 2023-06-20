namespace SegundoParcialLabo
{
    partial class FrmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogIn));
            panelLogo = new Panel();
            lblGenerala = new Label();
            pictureBox1 = new PictureBox();
            txtBContraseña = new TextBox();
            panelEmail = new Panel();
            txtBNombreUsuario = new TextBox();
            pictureBContra = new PictureBox();
            pictureBUsuario = new PictureBox();
            panel2 = new Panel();
            btnIngresar = new Button();
            btnRegistro = new Button();
            pictureBEscape = new PictureBox();
            pictureBMinimize = new PictureBox();
            picBEyeBlind = new PictureBox();
            picBEye = new PictureBox();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBContra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBEscape).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBEyeBlind).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBEye).BeginInit();
            SuspendLayout();
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(14, 89, 41);
            panelLogo.Controls.Add(lblGenerala);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Left;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(169, 217);
            panelLogo.TabIndex = 0;
            // 
            // lblGenerala
            // 
            lblGenerala.AutoSize = true;
            lblGenerala.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblGenerala.ForeColor = Color.FromArgb(20, 20, 20);
            lblGenerala.Location = new Point(37, 141);
            lblGenerala.Name = "lblGenerala";
            lblGenerala.Size = new Size(94, 21);
            lblGenerala.TabIndex = 14;
            lblGenerala.Text = "La Generala";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtBContraseña
            // 
            txtBContraseña.BackColor = Color.FromArgb(20, 20, 20);
            txtBContraseña.BorderStyle = BorderStyle.None;
            txtBContraseña.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBContraseña.ForeColor = SystemColors.Window;
            txtBContraseña.Location = new Point(254, 106);
            txtBContraseña.Name = "txtBContraseña";
            txtBContraseña.PlaceholderText = "Contraseña";
            txtBContraseña.Size = new Size(181, 15);
            txtBContraseña.TabIndex = 10;
            txtBContraseña.UseSystemPasswordChar = true;
            txtBContraseña.TextChanged += txtBContraseña_TextChanged;
            // 
            // panelEmail
            // 
            panelEmail.BackColor = Color.White;
            panelEmail.Location = new Point(215, 65);
            panelEmail.Name = "panelEmail";
            panelEmail.Size = new Size(329, 1);
            panelEmail.TabIndex = 9;
            // 
            // txtBNombreUsuario
            // 
            txtBNombreUsuario.BackColor = Color.FromArgb(20, 20, 20);
            txtBNombreUsuario.BorderStyle = BorderStyle.None;
            txtBNombreUsuario.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBNombreUsuario.ForeColor = SystemColors.Window;
            txtBNombreUsuario.Location = new Point(254, 43);
            txtBNombreUsuario.Name = "txtBNombreUsuario";
            txtBNombreUsuario.PlaceholderText = "Usuario";
            txtBNombreUsuario.Size = new Size(181, 15);
            txtBNombreUsuario.TabIndex = 8;
            // 
            // pictureBContra
            // 
            pictureBContra.Image = (Image)resources.GetObject("pictureBContra.Image");
            pictureBContra.Location = new Point(211, 97);
            pictureBContra.Name = "pictureBContra";
            pictureBContra.Size = new Size(33, 31);
            pictureBContra.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBContra.TabIndex = 7;
            pictureBContra.TabStop = false;
            // 
            // pictureBUsuario
            // 
            pictureBUsuario.Image = (Image)resources.GetObject("pictureBUsuario.Image");
            pictureBUsuario.Location = new Point(215, 35);
            pictureBUsuario.Name = "pictureBUsuario";
            pictureBUsuario.Size = new Size(33, 31);
            pictureBUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBUsuario.TabIndex = 6;
            pictureBUsuario.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(215, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(329, 1);
            panel2.TabIndex = 11;
            // 
            // btnIngresar
            // 
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.Gray;
            btnIngresar.Location = new Point(215, 155);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(160, 26);
            btnIngresar.TabIndex = 12;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.Cursor = Cursors.Hand;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistro.ForeColor = Color.Gray;
            btnRegistro.Location = new Point(384, 155);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(160, 26);
            btnRegistro.TabIndex = 13;
            btnRegistro.Text = "Registrarse";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // pictureBEscape
            // 
            pictureBEscape.Image = (Image)resources.GetObject("pictureBEscape.Image");
            pictureBEscape.Location = new Point(558, 6);
            pictureBEscape.Name = "pictureBEscape";
            pictureBEscape.Size = new Size(17, 17);
            pictureBEscape.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBEscape.TabIndex = 14;
            pictureBEscape.TabStop = false;
            pictureBEscape.Click += pictureBEscape_Click;
            // 
            // pictureBMinimize
            // 
            pictureBMinimize.Image = (Image)resources.GetObject("pictureBMinimize.Image");
            pictureBMinimize.Location = new Point(535, 6);
            pictureBMinimize.Name = "pictureBMinimize";
            pictureBMinimize.Size = new Size(17, 17);
            pictureBMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBMinimize.TabIndex = 15;
            pictureBMinimize.TabStop = false;
            pictureBMinimize.Click += pictureBMinimize_Click;
            // 
            // picBEyeBlind
            // 
            picBEyeBlind.Cursor = Cursors.Hand;
            picBEyeBlind.Image = (Image)resources.GetObject("picBEyeBlind.Image");
            picBEyeBlind.Location = new Point(525, 106);
            picBEyeBlind.Name = "picBEyeBlind";
            picBEyeBlind.Size = new Size(15, 20);
            picBEyeBlind.SizeMode = PictureBoxSizeMode.Zoom;
            picBEyeBlind.TabIndex = 16;
            picBEyeBlind.TabStop = false;
            picBEyeBlind.Visible = false;
            picBEyeBlind.Click += picBEyeBlind_Click;
            // 
            // picBEye
            // 
            picBEye.Cursor = Cursors.Hand;
            picBEye.Image = (Image)resources.GetObject("picBEye.Image");
            picBEye.Location = new Point(525, 106);
            picBEye.Name = "picBEye";
            picBEye.Size = new Size(15, 20);
            picBEye.SizeMode = PictureBoxSizeMode.Zoom;
            picBEye.TabIndex = 17;
            picBEye.TabStop = false;
            picBEye.Visible = false;
            picBEye.Click += picBEye_Click;
            // 
            // FrmLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(585, 217);
            Controls.Add(picBEye);
            Controls.Add(picBEyeBlind);
            Controls.Add(pictureBMinimize);
            Controls.Add(pictureBEscape);
            Controls.Add(btnRegistro);
            Controls.Add(btnIngresar);
            Controls.Add(panel2);
            Controls.Add(txtBContraseña);
            Controls.Add(panelEmail);
            Controls.Add(txtBNombreUsuario);
            Controls.Add(pictureBContra);
            Controls.Add(pictureBUsuario);
            Controls.Add(panelLogo);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogIn";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generala";
            Load += FrmLogIn_Load;
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBContra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBEscape).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBEyeBlind).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBEye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLogo;
        private PictureBox pictureBox1;
        private TextBox txtBContraseña;
        private Panel panelEmail;
        public TextBox txtBNombreUsuario;
        private PictureBox pictureBContra;
        private PictureBox pictureBUsuario;
        private Panel panel2;
        private Button btnIngresar;
        private Button btnRegistro;
        private Label lblGenerala;
        private PictureBox pictureBEscape;
        private PictureBox pictureBMinimize;
        private PictureBox picBEyeBlind;
        private PictureBox picBEye;
    }
}