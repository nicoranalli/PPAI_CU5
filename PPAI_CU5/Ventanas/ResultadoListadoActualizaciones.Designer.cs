namespace PPAI_CU5.Ventanas
{
    partial class ResultadoListadoActualizaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textSalida = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aceptar = new Guna.UI2.WinForms.Guna2Button();
            this.datosVinoActualizado = new Guna.UI2.WinForms.Guna2DataGridView();
            this.NombreVino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datosVinoActualizado)).BeginInit();
            this.SuspendLayout();
            // 
            // textSalida
            // 
            this.textSalida.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSalida.DefaultText = "ersdfdsdsfdsf";
            this.textSalida.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textSalida.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textSalida.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textSalida.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textSalida.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textSalida.Font = new System.Drawing.Font("Georgia", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSalida.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textSalida.Location = new System.Drawing.Point(71, 94);
            this.textSalida.Margin = new System.Windows.Forms.Padding(4);
            this.textSalida.MaxLength = 3276790;
            this.textSalida.Multiline = true;
            this.textSalida.Name = "textSalida";
            this.textSalida.PasswordChar = '\0';
            this.textSalida.PlaceholderText = "";
            this.textSalida.ReadOnly = true;
            this.textSalida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textSalida.SelectedText = "";
            this.textSalida.SelectionStart = 13;
            this.textSalida.Size = new System.Drawing.Size(318, 238);
            this.textSalida.TabIndex = 0;
            this.textSalida.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vinos Creado/Actualizados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // aceptar
            // 
            this.aceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.aceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.aceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.aceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.aceptar.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.ForeColor = System.Drawing.Color.White;
            this.aceptar.Location = new System.Drawing.Point(72, 353);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(180, 45);
            this.aceptar.TabIndex = 2;
            this.aceptar.Text = "Aceptar";
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // datosVinoActualizado
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datosVinoActualizado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datosVinoActualizado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datosVinoActualizado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosVinoActualizado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreVino,
            this.Accion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datosVinoActualizado.DefaultCellStyle = dataGridViewCellStyle3;
            this.datosVinoActualizado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datosVinoActualizado.Location = new System.Drawing.Point(436, 137);
            this.datosVinoActualizado.Name = "datosVinoActualizado";
            this.datosVinoActualizado.RowHeadersVisible = false;
            this.datosVinoActualizado.Size = new System.Drawing.Size(240, 150);
            this.datosVinoActualizado.TabIndex = 3;
            this.datosVinoActualizado.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datosVinoActualizado.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datosVinoActualizado.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datosVinoActualizado.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datosVinoActualizado.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datosVinoActualizado.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datosVinoActualizado.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datosVinoActualizado.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datosVinoActualizado.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datosVinoActualizado.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.datosVinoActualizado.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datosVinoActualizado.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosVinoActualizado.ThemeStyle.HeaderStyle.Height = 15;
            this.datosVinoActualizado.ThemeStyle.ReadOnly = false;
            this.datosVinoActualizado.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datosVinoActualizado.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datosVinoActualizado.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.datosVinoActualizado.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datosVinoActualizado.ThemeStyle.RowsStyle.Height = 22;
            this.datosVinoActualizado.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datosVinoActualizado.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datosVinoActualizado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // NombreVino
            // 
            this.NombreVino.HeaderText = "Nombre Vino";
            this.NombreVino.Name = "NombreVino";
            this.NombreVino.ReadOnly = true;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            // 
            // ResultadoListadoActualizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datosVinoActualizado);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSalida);
            this.Name = "ResultadoListadoActualizaciones";
            this.Text = "resultadoListadoActualizaciones";
            ((System.ComponentModel.ISupportInitialize)(this.datosVinoActualizado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textSalida;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button aceptar;
        private Guna.UI2.WinForms.Guna2DataGridView datosVinoActualizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreVino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accion;
    }
}