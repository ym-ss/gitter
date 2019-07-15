namespace PRINCIPAL
{
    partial class frmreservas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MNUEVO = new System.Windows.Forms.ToolStripButton();
            this.MANULAR = new System.Windows.Forms.ToolStripButton();
            this.MIMPRIMIR = new System.Windows.Forms.ToolStripButton();
            this.MCERRAR = new System.Windows.Forms.ToolStripButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dtinicio = new System.Windows.Forms.DateTimePicker();
            this.dtfinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
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
            this.txtci.Location = new System.Drawing.Point(76, 108);
            this.txtci.Name = "txtci";
            this.txtci.Size = new System.Drawing.Size(136, 22);
            this.txtci.TabIndex = 35;
            this.txtci.TextChanged += new System.EventHandler(this.txtci_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "BUSCAR:";
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
            this.dataGridView1.Size = new System.Drawing.Size(668, 301);
            this.dataGridView1.TabIndex = 32;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNUEVO,
            this.MANULAR,
            this.MIMPRIMIR,
            this.MCERRAR});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(681, 39);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            // MANULAR
            // 
            this.MANULAR.Image = global::PRINCIPAL.Properties.Resources.file_del;
            this.MANULAR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MANULAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MANULAR.Name = "MANULAR";
            this.MANULAR.Size = new System.Drawing.Size(89, 36);
            this.MANULAR.Text = "ANULAR";
            this.MANULAR.Click += new System.EventHandler(this.MMODIFICAR_Click);
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
            this.label9.Size = new System.Drawing.Size(173, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "LISTA DE RESERVAS";
            // 
            // dtinicio
            // 
            this.dtinicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtinicio.Location = new System.Drawing.Point(340, 110);
            this.dtinicio.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtinicio.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtinicio.Name = "dtinicio";
            this.dtinicio.Size = new System.Drawing.Size(111, 20);
            this.dtinicio.TabIndex = 36;
            // 
            // dtfinal
            // 
            this.dtfinal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfinal.Location = new System.Drawing.Point(500, 110);
            this.dtfinal.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtfinal.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtfinal.Name = "dtfinal";
            this.dtfinal.Size = new System.Drawing.Size(110, 20);
            this.dtfinal.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "INICIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "FINAL:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::PRINCIPAL.Properties.Resources.search;
            this.btnbuscar.Location = new System.Drawing.Point(617, 104);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(33, 31);
            this.btnbuscar.TabIndex = 33;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(681, 50);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // frmreservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 455);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtfinal);
            this.Controls.Add(this.dtinicio);
            this.Controls.Add(this.txtci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmreservas";
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.frmreservas_Load);
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
        private System.Windows.Forms.ToolStripButton MANULAR;
        private System.Windows.Forms.ToolStripButton MIMPRIMIR;
        private System.Windows.Forms.ToolStripButton MCERRAR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtinicio;
        private System.Windows.Forms.DateTimePicker dtfinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}