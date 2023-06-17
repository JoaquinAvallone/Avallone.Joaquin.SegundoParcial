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
            panel1 = new Panel();
            panel2 = new Panel();
            panelFormularios = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBEscape).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblGenerala
            // 
            lblGenerala.AutoSize = true;
            lblGenerala.Font = new Font("Sylfaen", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenerala.ForeColor = Color.WhiteSmoke;
            lblGenerala.Location = new Point(108, 9);
            lblGenerala.Name = "lblGenerala";
            lblGenerala.Size = new Size(207, 46);
            lblGenerala.TabIndex = 0;
            lblGenerala.Text = "La Generala";
            // 
            // btnPVP
            // 
            btnPVP.Cursor = Cursors.Hand;
            btnPVP.FlatAppearance.BorderSize = 0;
            btnPVP.FlatStyle = FlatStyle.Flat;
            btnPVP.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPVP.ForeColor = Color.WhiteSmoke;
            btnPVP.Location = new Point(3, 90);
            btnPVP.Name = "btnPVP";
            btnPVP.Size = new Size(95, 39);
            btnPVP.TabIndex = 1;
            btnPVP.Text = "PLAYER vs PLAYER";
            btnPVP.UseVisualStyleBackColor = true;
            btnPVP.Click += btnPVP_Click;
            // 
            // btnPc
            // 
            btnPc.Cursor = Cursors.Hand;
            btnPc.FlatAppearance.BorderSize = 0;
            btnPc.FlatStyle = FlatStyle.Flat;
            btnPc.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPc.ForeColor = Color.WhiteSmoke;
            btnPc.Location = new Point(3, 133);
            btnPc.Name = "btnPc";
            btnPc.Size = new Size(94, 39);
            btnPc.TabIndex = 2;
            btnPc.Text = "PC vs PC";
            btnPc.UseVisualStyleBackColor = true;
            btnPc.Click += btnPc_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.Cursor = Cursors.Hand;
            btnHistorial.FlatAppearance.BorderSize = 0;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistorial.ForeColor = Color.WhiteSmoke;
            btnHistorial.Location = new Point(0, 177);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(97, 39);
            btnHistorial.TabIndex = 3;
            btnHistorial.Text = "HISTORIAL";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // pictureBMinimize
            // 
            pictureBMinimize.Cursor = Cursors.Hand;
            pictureBMinimize.Image = (Image)resources.GetObject("pictureBMinimize.Image");
            pictureBMinimize.Location = new Point(393, 10);
            pictureBMinimize.Name = "pictureBMinimize";
            pictureBMinimize.Size = new Size(17, 17);
            pictureBMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBMinimize.TabIndex = 17;
            pictureBMinimize.TabStop = false;
            pictureBMinimize.Click += pictureBMinimize_Click;
            // 
            // pictureBEscape
            // 
            pictureBEscape.Cursor = Cursors.Hand;
            pictureBEscape.Image = (Image)resources.GetObject("pictureBEscape.Image");
            pictureBEscape.Location = new Point(416, 10);
            pictureBEscape.Name = "pictureBEscape";
            pictureBEscape.Size = new Size(17, 17);
            pictureBEscape.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBEscape.TabIndex = 16;
            pictureBEscape.TabStop = false;
            pictureBEscape.Click += pictureBEscape_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(8, 51, 24);
            panel1.Controls.Add(btnPVP);
            panel1.Controls.Add(btnPc);
            panel1.Controls.Add(btnHistorial);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 350);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(8, 51, 24);
            panel2.Controls.Add(pictureBMinimize);
            panel2.Controls.Add(pictureBEscape);
            panel2.Controls.Add(lblGenerala);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(100, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 60);
            panel2.TabIndex = 20;
            // 
            // panelFormularios
            // 
            panelFormularios.Controls.Add(pictureBox1);
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(100, 60);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(444, 290);
            panelFormularios.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(146, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 89, 41);
            ClientSize = new Size(544, 350);
            Controls.Add(panelFormularios);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBEscape).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelFormularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblGenerala;
        private Button btnPVP;
        private Button btnPc;
        private Button btnHistorial;
        private PictureBox pictureBMinimize;
        private PictureBox pictureBEscape;
        private Panel panel1;
        private Panel panel2;
        private Panel panelFormularios;
        private PictureBox pictureBox1;
    }
}