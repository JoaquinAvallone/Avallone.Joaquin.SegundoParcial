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
            panel1 = new Panel();
            btnRegistro = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 365);
            panel1.TabIndex = 0;
            // 
            // btnRegistro
            // 
            btnRegistro.Cursor = Cursors.Hand;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistro.ForeColor = Color.Gray;
            btnRegistro.Location = new Point(215, 369);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(160, 26);
            btnRegistro.TabIndex = 35;
            btnRegistro.Text = "Historial Partidas";
            btnRegistro.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Gray;
            button1.Location = new Point(407, 369);
            button1.Name = "button1";
            button1.Size = new Size(160, 26);
            button1.TabIndex = 36;
            button1.Text = "Crear Partida";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 89, 41);
            ClientSize = new Size(761, 402);
            Controls.Add(btnRegistro);
            Controls.Add(button1);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(2, 115, 74);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRegistro;
        private Button button1;
    }
}