namespace SegundoParcialLabo
{
    partial class FrmHistorial
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGVPartidas = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            jugadorUno = new DataGridViewTextBoxColumn();
            JugadorDos = new DataGridViewTextBoxColumn();
            PuntosJugaUno = new DataGridViewTextBoxColumn();
            PuntosJugaDos = new DataGridViewTextBoxColumn();
            Ganador = new DataGridViewTextBoxColumn();
            Perdedor = new DataGridViewTextBoxColumn();
            lblGandas = new Label();
            lblPerdidas = new Label();
            lblAviso = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGVPartidas).BeginInit();
            SuspendLayout();
            // 
            // dataGVPartidas
            // 
            dataGVPartidas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGVPartidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVPartidas.BackgroundColor = Color.FromArgb(14, 89, 41);
            dataGVPartidas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGVPartidas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 89, 41);
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(14, 89, 41);
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGVPartidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGVPartidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVPartidas.Columns.AddRange(new DataGridViewColumn[] { ID, jugadorUno, JugadorDos, PuntosJugaUno, PuntosJugaDos, Ganador, Perdedor });
            dataGVPartidas.EnableHeadersVisualStyles = false;
            dataGVPartidas.GridColor = Color.FromArgb(14, 89, 41);
            dataGVPartidas.Location = new Point(0, 2);
            dataGVPartidas.MultiSelect = false;
            dataGVPartidas.Name = "dataGVPartidas";
            dataGVPartidas.ReadOnly = true;
            dataGVPartidas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(14, 89, 41);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(8, 51, 24);
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGVPartidas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGVPartidas.RowHeadersVisible = false;
            dataGVPartidas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(14, 89, 41);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(8, 51, 24);
            dataGridViewCellStyle3.SelectionForeColor = Color.WhiteSmoke;
            dataGVPartidas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGVPartidas.RowTemplate.Height = 25;
            dataGVPartidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGVPartidas.Size = new Size(444, 258);
            dataGVPartidas.TabIndex = 0;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.False;
            ID.SortMode = DataGridViewColumnSortMode.NotSortable;
            ID.Width = 22;
            // 
            // jugadorUno
            // 
            jugadorUno.HeaderText = "Jugador Uno";
            jugadorUno.Name = "jugadorUno";
            jugadorUno.ReadOnly = true;
            jugadorUno.Resizable = DataGridViewTriState.False;
            jugadorUno.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // JugadorDos
            // 
            JugadorDos.HeaderText = "Jugador Dos";
            JugadorDos.Name = "JugadorDos";
            JugadorDos.ReadOnly = true;
            JugadorDos.Resizable = DataGridViewTriState.False;
            JugadorDos.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PuntosJugaUno
            // 
            PuntosJugaUno.HeaderText = "Puntos Jugador Uno";
            PuntosJugaUno.Name = "PuntosJugaUno";
            PuntosJugaUno.ReadOnly = true;
            PuntosJugaUno.Resizable = DataGridViewTriState.False;
            PuntosJugaUno.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PuntosJugaDos
            // 
            PuntosJugaDos.HeaderText = "Puntos Jugador Dos";
            PuntosJugaDos.Name = "PuntosJugaDos";
            PuntosJugaDos.ReadOnly = true;
            PuntosJugaDos.Resizable = DataGridViewTriState.False;
            PuntosJugaDos.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Ganador
            // 
            Ganador.HeaderText = "Ganador";
            Ganador.Name = "Ganador";
            Ganador.ReadOnly = true;
            Ganador.Resizable = DataGridViewTriState.False;
            Ganador.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Perdedor
            // 
            Perdedor.HeaderText = "Perdedor";
            Perdedor.Name = "Perdedor";
            Perdedor.ReadOnly = true;
            Perdedor.Resizable = DataGridViewTriState.False;
            Perdedor.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // lblGandas
            // 
            lblGandas.AutoSize = true;
            lblGandas.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGandas.ForeColor = Color.WhiteSmoke;
            lblGandas.Location = new Point(12, 263);
            lblGandas.Name = "lblGandas";
            lblGandas.Size = new Size(140, 18);
            lblGandas.TabIndex = 1;
            lblGandas.Text = "Partidas Ganadas: ";
            // 
            // lblPerdidas
            // 
            lblPerdidas.AutoSize = true;
            lblPerdidas.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPerdidas.ForeColor = Color.WhiteSmoke;
            lblPerdidas.Location = new Point(240, 263);
            lblPerdidas.Name = "lblPerdidas";
            lblPerdidas.Size = new Size(141, 18);
            lblPerdidas.TabIndex = 2;
            lblPerdidas.Text = "Partidas Perdidas: ";
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAviso.ForeColor = Color.WhiteSmoke;
            lblAviso.Location = new Point(122, 119);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(193, 18);
            lblAviso.TabIndex = 3;
            lblAviso.Text = "Historial del jugador vacío";
            // 
            // FrmHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 89, 41);
            ClientSize = new Size(444, 290);
            Controls.Add(lblAviso);
            Controls.Add(lblPerdidas);
            Controls.Add(lblGandas);
            Controls.Add(dataGVPartidas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHistorial";
            Text = "FrmHistorial";
            Load += FrmHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGVPartidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGVPartidas;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn jugadorUno;
        private DataGridViewTextBoxColumn JugadorDos;
        private DataGridViewTextBoxColumn PuntosJugaUno;
        private DataGridViewTextBoxColumn PuntosJugaDos;
        private DataGridViewTextBoxColumn Ganador;
        private DataGridViewTextBoxColumn Perdedor;
        private Label lblGandas;
        private Label lblPerdidas;
        private Label lblAviso;
    }
}