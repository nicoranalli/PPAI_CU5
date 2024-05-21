namespace PPAI_CU5
{
    partial class PantallaNovedades
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.gridBodegas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id_bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionBodegas = new Guna.UI2.WinForms.Guna2Button();
            this.cajaTexto = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelNovedades = new System.Windows.Forms.Label();
            this.labelSeleccioneBodega = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridBodegas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(182, 203);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(180, 45);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar Bodegas";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gridBodegas
            // 
            this.gridBodegas.AllowUserToAddRows = false;
            this.gridBodegas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridBodegas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBodegas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridBodegas.ColumnHeadersHeight = 15;
            this.gridBodegas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridBodegas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_bodega,
            this.n_bodega});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBodegas.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridBodegas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridBodegas.Location = new System.Drawing.Point(12, 35);
            this.gridBodegas.Name = "gridBodegas";
            this.gridBodegas.ReadOnly = true;
            this.gridBodegas.RowHeadersVisible = false;
            this.gridBodegas.Size = new System.Drawing.Size(350, 213);
            this.gridBodegas.TabIndex = 1;
            this.gridBodegas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridBodegas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridBodegas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridBodegas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridBodegas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridBodegas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridBodegas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridBodegas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridBodegas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridBodegas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBodegas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridBodegas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridBodegas.ThemeStyle.HeaderStyle.Height = 15;
            this.gridBodegas.ThemeStyle.ReadOnly = true;
            this.gridBodegas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridBodegas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridBodegas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBodegas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridBodegas.ThemeStyle.RowsStyle.Height = 22;
            this.gridBodegas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridBodegas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridBodegas.SelectionChanged += new System.EventHandler(this.gridBodegas_SelectionChanged);
            // 
            // id_bodega
            // 
            this.id_bodega.HeaderText = "ID";
            this.id_bodega.Name = "id_bodega";
            this.id_bodega.ReadOnly = true;
            // 
            // n_bodega
            // 
            this.n_bodega.HeaderText = "Bodega";
            this.n_bodega.Name = "n_bodega";
            this.n_bodega.ReadOnly = true;
            // 
            // btnSeleccionBodegas
            // 
            this.btnSeleccionBodegas.BorderRadius = 15;
            this.btnSeleccionBodegas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionBodegas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionBodegas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeleccionBodegas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeleccionBodegas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionBodegas.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionBodegas.Location = new System.Drawing.Point(377, 203);
            this.btnSeleccionBodegas.Name = "btnSeleccionBodegas";
            this.btnSeleccionBodegas.Size = new System.Drawing.Size(127, 45);
            this.btnSeleccionBodegas.TabIndex = 2;
            this.btnSeleccionBodegas.Text = "Traer actualizaciones";
            this.btnSeleccionBodegas.Click += new System.EventHandler(this.btnSeleccionBodegas_Click);
            // 
            // cajaTexto
            // 
            this.cajaTexto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cajaTexto.DefaultText = "";
            this.cajaTexto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cajaTexto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cajaTexto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cajaTexto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cajaTexto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cajaTexto.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaTexto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cajaTexto.Location = new System.Drawing.Point(12, 276);
            this.cajaTexto.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cajaTexto.Multiline = true;
            this.cajaTexto.Name = "cajaTexto";
            this.cajaTexto.PasswordChar = '\0';
            this.cajaTexto.PlaceholderText = "";
            this.cajaTexto.ReadOnly = true;
            this.cajaTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cajaTexto.SelectedText = "";
            this.cajaTexto.Size = new System.Drawing.Size(350, 160);
            this.cajaTexto.TabIndex = 4;
            // 
            // labelNovedades
            // 
            this.labelNovedades.AutoSize = true;
            this.labelNovedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNovedades.Location = new System.Drawing.Point(12, 251);
            this.labelNovedades.Name = "labelNovedades";
            this.labelNovedades.Size = new System.Drawing.Size(89, 20);
            this.labelNovedades.TabIndex = 5;
            this.labelNovedades.Text = "Novedades";
            // 
            // labelSeleccioneBodega
            // 
            this.labelSeleccioneBodega.AutoSize = true;
            this.labelSeleccioneBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeleccioneBodega.Location = new System.Drawing.Point(12, 9);
            this.labelSeleccioneBodega.Name = "labelSeleccioneBodega";
            this.labelSeleccioneBodega.Size = new System.Drawing.Size(151, 20);
            this.labelSeleccioneBodega.TabIndex = 6;
            this.labelSeleccioneBodega.Text = "Seleccione Bodega:";
            // 
            // PantallaNovedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.labelSeleccioneBodega);
            this.Controls.Add(this.labelNovedades);
            this.Controls.Add(this.cajaTexto);
            this.Controls.Add(this.btnSeleccionBodegas);
            this.Controls.Add(this.gridBodegas);
            this.Controls.Add(this.btnActualizar);
            this.Name = "PantallaNovedades";
            this.Text = "Actualizacion de Vinos";
            this.Load += new System.EventHandler(this.ActualizacionVinos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBodegas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnActualizar;
        private Guna.UI2.WinForms.Guna2DataGridView gridBodegas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_bodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_bodega;
        private Guna.UI2.WinForms.Guna2Button btnSeleccionBodegas;
        private Guna.UI2.WinForms.Guna2TextBox cajaTexto;
        private System.Windows.Forms.Label labelNovedades;
        private System.Windows.Forms.Label labelSeleccioneBodega;
    }
}

