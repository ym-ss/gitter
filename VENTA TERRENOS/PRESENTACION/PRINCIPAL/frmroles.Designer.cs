namespace PRINCIPAL
{
    partial class frmroles
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
            this.txtci = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MNUEVO = new System.Windows.Forms.ToolStripButton();
            this.MMODIFICAR = new System.Windows.Forms.ToolStripButton();
            this.MHABILITAR = new System.Windows.Forms.ToolStripButton();
            this.MIMPRIMIR = new System.Windows.Forms.ToolStripButton();
            this.MCERRAR = new System.Windows.Forms.ToolStripButton();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtci
            // 
            this.txtci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtci.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtci.Location = new System.Drawing.Point(82, 108);
            this.txtci.Name = "txtci";
            this.txtci.Size = new System.Drawing.Size(156, 22);
            this.txtci.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "BUSCAR:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::PRINCIPAL.Properties.Resources.search;
            this.btnbuscar.Location = new System.Drawing.Point(245, 103);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(33, 31);
            this.btnbuscar.TabIndex = 40;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(487, 301);
            this.dataGridView1.TabIndex = 39;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNUEVO,
            this.MMODIFICAR,
            this.MHABILITAR,
            this.MIMPRIMIR,
            this.MCERRAR});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(505, 39);
            this.toolStrip1.TabIndex = 38;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MNUEVO
            // 
            this.MNUEVO.Image = global::PRINCIPAL.Properties.Resources._new;
            this.MNUEVO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MNUEVO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MNUEVO.Name = "MNUEVO";
            this.MNUEVO.Size = new System.Drawing.Size(82, 36);
            this.MNUEVO.Text = "NUEVO";
            this.MNUEVO.Click += new System.EventHandler(this.MNUEVO_Click);
            // 
            // MMODIFICAR
            // 
            this.MMODIFICAR.Image = global::PRINCIPAL.Properties.Resources.edit;
            this.MMODIFICAR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MMODIFICAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MMODIFICAR.Name = "MMODIFICAR";
            this.MMODIFICAR.Size = new System.Drawing.Size(106, 36);
            this.MMODIFICAR.Text = "MODIFICAR";
            this.MMODIFICAR.Click += new System.EventHandler(this.MMODIFICAR_Click);
            // 
            // MHABILITAR
            // 
            this.MHABILITAR.Image = global::PRINCIPAL.Properties.Resources.refresh;
            this.MHABILITAR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MHABILITAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MHABILITAR.Name = "MHABILITAR";
            this.MHABILITAR.Size = new System.Drawing.Size(98, 36);
            this.MHABILITAR.Text = "HAB / DES";
            this.MHABILITAR.Click += new System.EventHandler(this.MHABILITAR_Click);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightCoral;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 18);
            this.label9.TabIndex = 37;
            this.label9.Text = "LISTA DE ROLES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 50);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // frmroles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 457);
            this.Controls.Add(this.txtci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmroles";
            this.Load += new System.EventHandler(this.frmroles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton MNUEVO;
        private System.Windows.Forms.ToolStripButton MMODIFICAR;
        private System.Windows.Forms.ToolStripButton MHABILITAR;
        private System.Windows.Forms.ToolStripButton MIMPRIMIR;
        private System.Windows.Forms.ToolStripButton MCERRAR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}