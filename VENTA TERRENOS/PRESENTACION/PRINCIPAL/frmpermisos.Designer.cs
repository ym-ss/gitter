namespace PRINCIPAL
{
    partial class frmpermisos
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
            this.label9 = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CMBESTADO = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.BTNBUSCAR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MNUEVO = new System.Windows.Forms.ToolStripButton();
            this.MIMPRIMIR = new System.Windows.Forms.ToolStripButton();
            this.MCERRAR = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightCoral;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "PERMISOS DE ROL";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5});
            this.DGV.Location = new System.Drawing.Point(7, 133);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(466, 342);
            this.DGV.TabIndex = 53;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 43;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ROL";
            this.Column2.HeaderText = "ROL";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MENU";
            this.Column3.HeaderText = "MENU";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PERMISO";
            this.Column5.HeaderText = "PERMISO";
            this.Column5.Name = "Column5";
            this.Column5.Width = 62;
            // 
            // CMBESTADO
            // 
            this.CMBESTADO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBESTADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBESTADO.FormattingEnabled = true;
            this.CMBESTADO.Location = new System.Drawing.Point(68, 98);
            this.CMBESTADO.Name = "CMBESTADO";
            this.CMBESTADO.Size = new System.Drawing.Size(229, 24);
            this.CMBESTADO.TabIndex = 5;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(12, 106);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(50, 13);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "CARGO";
            // 
            // BTNBUSCAR
            // 
            this.BTNBUSCAR.Image = global::PRINCIPAL.Properties.Resources.find_at_disc;
            this.BTNBUSCAR.Location = new System.Drawing.Point(303, 92);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(42, 33);
            this.BTNBUSCAR.TabIndex = 3;
            this.BTNBUSCAR.UseVisualStyleBackColor = true;
            this.BTNBUSCAR.Click += new System.EventHandler(this.BTNBUSCAR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 50);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNUEVO,
            this.MIMPRIMIR,
            this.MCERRAR});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(484, 39);
            this.toolStrip1.TabIndex = 54;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MNUEVO
            // 
            this.MNUEVO.Image = global::PRINCIPAL.Properties.Resources.save;
            this.MNUEVO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MNUEVO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MNUEVO.Name = "MNUEVO";
            this.MNUEVO.Size = new System.Drawing.Size(152, 36);
            this.MNUEVO.Text = "GUARDAR CAMBIOS";
            this.MNUEVO.Click += new System.EventHandler(this.MNUEVO_Click);
            // 
            // MIMPRIMIR
            // 
            this.MIMPRIMIR.Image = global::PRINCIPAL.Properties.Resources.print;
            this.MIMPRIMIR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MIMPRIMIR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MIMPRIMIR.Name = "MIMPRIMIR";
            this.MIMPRIMIR.Size = new System.Drawing.Size(95, 36);
            this.MIMPRIMIR.Text = "IMPRIMIR";
            this.MIMPRIMIR.Click += new System.EventHandler(this.MIMPRIMIR_Click);
            // 
            // MCERRAR
            // 
            this.MCERRAR.Image = global::PRINCIPAL.Properties.Resources.undo;
            this.MCERRAR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MCERRAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MCERRAR.Name = "MCERRAR";
            this.MCERRAR.Size = new System.Drawing.Size(86, 36);
            this.MCERRAR.Text = "CERRAR";
            this.MCERRAR.Click += new System.EventHandler(this.MCERRAR_Click);
            // 
            // frmpermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 480);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.CMBESTADO);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.BTNBUSCAR);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmpermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmpermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.DataGridView DGV;
        internal System.Windows.Forms.ComboBox CMBESTADO;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button BTNBUSCAR;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton MNUEVO;
        private System.Windows.Forms.ToolStripButton MIMPRIMIR;
        private System.Windows.Forms.ToolStripButton MCERRAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
    }
}