namespace PRINCIPAL
{
    partial class frmreporteusuario
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
            this.MIMPRIMIR = new System.Windows.Forms.ToolStripButton();
            this.MCERRAR = new System.Windows.Forms.ToolStripButton();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.btnmes = new System.Windows.Forms.Button();
            this.btndia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtci
            // 
            this.txtci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtci.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtci.Location = new System.Drawing.Point(82, 109);
            this.txtci.Name = "txtci";
            this.txtci.Size = new System.Drawing.Size(116, 22);
            this.txtci.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "BUSCAR:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::PRINCIPAL.Properties.Resources.search;
            this.btnbuscar.Location = new System.Drawing.Point(330, 103);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(33, 31);
            this.btnbuscar.TabIndex = 33;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(668, 301);
            this.dataGridView1.TabIndex = 32;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIMPRIMIR,
            this.MCERRAR});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(683, 39);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MIMPRIMIR
            // 
            this.MIMPRIMIR.Image = global::PRINCIPAL.Properties.Resources.print;
            this.MIMPRIMIR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MIMPRIMIR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MIMPRIMIR.Name = "MIMPRIMIR";
            this.MIMPRIMIR.Size = new System.Drawing.Size(95, 36);
            this.MIMPRIMIR.Text = "IMPRIMIR";
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
            this.label9.Location = new System.Drawing.Point(30, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "REPORTE DE RESERVAS ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(683, 50);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // dtfecha
            // 
            this.dtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(204, 107);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(120, 22);
            this.dtfecha.TabIndex = 36;
            // 
            // btnmes
            // 
            this.btnmes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmes.Location = new System.Drawing.Point(511, 103);
            this.btnmes.Name = "btnmes";
            this.btnmes.Size = new System.Drawing.Size(77, 31);
            this.btnmes.TabIndex = 41;
            this.btnmes.Text = "Por Mes";
            this.btnmes.UseVisualStyleBackColor = true;
            this.btnmes.Click += new System.EventHandler(this.btnmes_Click);
            // 
            // btndia
            // 
            this.btndia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndia.Location = new System.Drawing.Point(594, 103);
            this.btndia.Name = "btndia";
            this.btndia.Size = new System.Drawing.Size(77, 31);
            this.btndia.TabIndex = 42;
            this.btndia.Text = "Por Dia";
            this.btndia.UseVisualStyleBackColor = true;
            this.btndia.Click += new System.EventHandler(this.btndia_Click);
            // 
            // frmreporteusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 458);
            this.Controls.Add(this.btndia);
            this.Controls.Add(this.btnmes);
            this.Controls.Add(this.dtfecha);
            this.Controls.Add(this.txtci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmreporteusuario";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.frmreporteusuario_Load);
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
        private System.Windows.Forms.ToolStripButton MIMPRIMIR;
        private System.Windows.Forms.ToolStripButton MCERRAR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Button btnmes;
        private System.Windows.Forms.Button btndia;
    }
}