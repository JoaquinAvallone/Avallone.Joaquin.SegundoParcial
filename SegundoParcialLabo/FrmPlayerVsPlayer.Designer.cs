namespace SegundoParcialLabo
{
    partial class FrmPlayerVsPlayer
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
            label1 = new Label();
            btnJugar = new Button();
            comboBUno = new ComboBox();
            lblJugador1 = new Label();
            lblJugador2 = new Label();
            comboBDos = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(187, 41);
            label1.Name = "label1";
            label1.Size = new Size(189, 31);
            label1.TabIndex = 13;
            label1.Text = "Player vs Player";
            // 
            // btnJugar
            // 
            btnJugar.Anchor = AnchorStyles.None;
            btnJugar.FlatAppearance.BorderSize = 0;
            btnJugar.FlatStyle = FlatStyle.Popup;
            btnJugar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnJugar.ForeColor = Color.WhiteSmoke;
            btnJugar.Location = new Point(210, 205);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(136, 39);
            btnJugar.TabIndex = 11;
            btnJugar.Text = "JUGAR";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnJugar_Click;
            // 
            // comboBUno
            // 
            comboBUno.Anchor = AnchorStyles.None;
            comboBUno.FormattingEnabled = true;
            comboBUno.Location = new Point(93, 143);
            comboBUno.Name = "comboBUno";
            comboBUno.Size = new Size(142, 23);
            comboBUno.TabIndex = 12;
            // 
            // lblJugador1
            // 
            lblJugador1.Anchor = AnchorStyles.None;
            lblJugador1.AutoSize = true;
            lblJugador1.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblJugador1.ForeColor = Color.WhiteSmoke;
            lblJugador1.Location = new Point(109, 108);
            lblJugador1.Name = "lblJugador1";
            lblJugador1.Size = new Size(103, 22);
            lblJugador1.TabIndex = 8;
            lblJugador1.Text = "Jugador Uno";
            // 
            // lblJugador2
            // 
            lblJugador2.Anchor = AnchorStyles.None;
            lblJugador2.AutoSize = true;
            lblJugador2.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblJugador2.ForeColor = Color.WhiteSmoke;
            lblJugador2.Location = new Point(345, 108);
            lblJugador2.Name = "lblJugador2";
            lblJugador2.Size = new Size(101, 22);
            lblJugador2.TabIndex = 9;
            lblJugador2.Text = "Jugador Dos";
            // 
            // comboBDos
            // 
            comboBDos.Anchor = AnchorStyles.None;
            comboBDos.FormattingEnabled = true;
            comboBDos.Location = new Point(323, 143);
            comboBDos.Name = "comboBDos";
            comboBDos.Size = new Size(142, 23);
            comboBDos.TabIndex = 10;
            // 
            // FrmPlayerVsPlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 89, 41);
            ClientSize = new Size(567, 290);
            Controls.Add(label1);
            Controls.Add(btnJugar);
            Controls.Add(comboBUno);
            Controls.Add(lblJugador1);
            Controls.Add(lblJugador2);
            Controls.Add(comboBDos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPlayerVsPlayer";
            Text = "FrmPlayerVsPlayer";
            Load += FrmPlayerVsPlayer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnJugar;
        private ComboBox comboBUno;
        private Label lblJugador1;
        private Label lblJugador2;
        private ComboBox comboBDos;
    }
}