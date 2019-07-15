namespace PRINCIPAL
{
    partial class frmreserva
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
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidterreno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmetros = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.chanulado = new System.Windows.Forms.CheckBox();
            this.chvencido = new System.Windows.Forms.CheckBox();
            this.chvigente = new System.Windows.Forms.CheckBox();
            this.chimprimirmapa = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnroreserva = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtci
            // 
            this.txtci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtci.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtci.Location = new System.Drawing.Point(25, 85);
            this.txtci.Name = "txtci";
            this.txtci.Size = new System.Drawing.Size(105, 29);
            this.txtci.TabIndex = 4;
            this.txtci.Text = "123";
            this.txtci.TextChanged += new System.EventHandler(this.txtci_TextChanged);
            this.txtci.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtci_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightCoral;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "RESERVA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "CI";
            // 
            // txtnombres
            // 
            this.txtnombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombres.Location = new System.Drawing.Point(135, 85);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.ReadOnly = true;
            this.txtnombres.Size = new System.Drawing.Size(378, 29);
            this.txtnombres.TabIndex = 31;
            this.txtnombres.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "NOMBRE Y APELLIDOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "COD. TER,";
            // 
            // txtidterreno
            // 
            this.txtidterreno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidterreno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtidterreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidterreno.Location = new System.Drawing.Point(25, 147);
            this.txtidterreno.Name = "txtidterreno";
            this.txtidterreno.Size = new System.Drawing.Size(105, 29);
            this.txtidterreno.TabIndex = 32;
            this.txtidterreno.Text = "0";
            this.txtidterreno.TextChanged += new System.EventHandler(this.txtidterreno_TextChanged);
            this.txtidterreno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtidterreno_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "PRECIO ($)";
            // 
            // txtprecio
            // 
            this.txtprecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(134, 147);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.ReadOnly = true;
            this.txtprecio.Size = new System.Drawing.Size(88, 29);
            this.txtprecio.TabIndex = 34;
            this.txtprecio.Text = "0";
            this.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "M2";
            // 
            // txtmetros
            // 
            this.txtmetros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmetros.Location = new System.Drawing.Point(228, 147);
            this.txtmetros.Name = "txtmetros";
            this.txtmetros.ReadOnly = true;
            this.txtmetros.Size = new System.Drawing.Size(83, 29);
            this.txtmetros.TabIndex = 36;
            this.txtmetros.Text = "0";
            this.txtmetros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Location = new System.Drawing.Point(519, 147);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(67, 29);
            this.btnlimpiar.TabIndex = 40;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Location = new System.Drawing.Point(479, 147);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(37, 29);
            this.btneliminar.TabIndex = 39;
            this.btneliminar.Text = "--";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnadicionar
            // 
            this.btnadicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadicionar.Location = new System.Drawing.Point(439, 147);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(37, 29);
            this.btnadicionar.TabIndex = 38;
            this.btnadicionar.Text = "+";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(25, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(563, 229);
            this.dataGridView1.TabIndex = 41;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDTERRENO";
            this.Column1.HeaderText = "TERRENO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 85;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PRECIO";
            this.Column2.HeaderText = "PRECIO";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 65;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = " METROS";
            this.Column3.HeaderText = "M2";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 55;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ESTADORESERVA";
            this.Column4.HeaderText = "ESTADO";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "FECHARES";
            this.Column5.HeaderText = "FEC RES";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 90;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "USUARIO";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(-2, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(613, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "_________________________________________________________________________________" +
    "____________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(316, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "ESTADO";
            // 
            // txtestado
            // 
            this.txtestado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestado.Location = new System.Drawing.Point(317, 147);
            this.txtestado.Name = "txtestado";
            this.txtestado.ReadOnly = true;
            this.txtestado.Size = new System.Drawing.Size(119, 29);
            this.txtestado.TabIndex = 45;
            this.txtestado.Text = "0";
            this.txtestado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnimprimir
            // 
            this.btnimprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnimprimir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnimprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnimprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.ForeColor = System.Drawing.Color.Black;
            this.btnimprimir.Image = global::PRINCIPAL.Properties.Resources.print1;
            this.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimir.Location = new System.Drawing.Point(441, 483);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(46, 36);
            this.btnimprimir.TabIndex = 47;
            this.btnimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnimprimir.UseVisualStyleBackColor = false;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btncancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.Black;
            this.btncancelar.Image = global::PRINCIPAL.Properties.Resources.undo;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(545, 483);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(43, 36);
            this.btncancelar.TabIndex = 43;
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnaceptar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnaceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnaceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.ForeColor = System.Drawing.Color.Black;
            this.btnaceptar.Image = global::PRINCIPAL.Properties.Resources.save;
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaceptar.Location = new System.Drawing.Point(493, 483);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(46, 36);
            this.btnaceptar.TabIndex = 42;
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(611, 50);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // chanulado
            // 
            this.chanulado.AutoSize = true;
            this.chanulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chanulado.Location = new System.Drawing.Point(25, 449);
            this.chanulado.Name = "chanulado";
            this.chanulado.Size = new System.Drawing.Size(108, 20);
            this.chanulado.TabIndex = 48;
            this.chanulado.Text = "Ver Anulados";
            this.chanulado.UseVisualStyleBackColor = true;
            this.chanulado.CheckedChanged += new System.EventHandler(this.chanulado_CheckedChanged);
            // 
            // chvencido
            // 
            this.chvencido.AutoSize = true;
            this.chvencido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chvencido.Location = new System.Drawing.Point(25, 472);
            this.chvencido.Name = "chvencido";
            this.chvencido.Size = new System.Drawing.Size(108, 20);
            this.chvencido.TabIndex = 49;
            this.chvencido.Text = "Ver Vencidos";
            this.chvencido.UseVisualStyleBackColor = true;
            this.chvencido.CheckedChanged += new System.EventHandler(this.chvencido_CheckedChanged);
            // 
            // chvigente
            // 
            this.chvigente.AutoSize = true;
            this.chvigente.Checked = true;
            this.chvigente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chvigente.Enabled = false;
            this.chvigente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chvigente.Location = new System.Drawing.Point(25, 494);
            this.chvigente.Name = "chvigente";
            this.chvigente.Size = new System.Drawing.Size(97, 20);
            this.chvigente.TabIndex = 50;
            this.chvigente.Text = "Ver Vigente";
            this.chvigente.UseVisualStyleBackColor = true;
            // 
            // chimprimirmapa
            // 
            this.chimprimirmapa.AutoSize = true;
            this.chimprimirmapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chimprimirmapa.Location = new System.Drawing.Point(323, 501);
            this.chimprimirmapa.Name = "chimprimirmapa";
            this.chimprimirmapa.Size = new System.Drawing.Size(112, 20);
            this.chimprimirmapa.TabIndex = 51;
            this.chimprimirmapa.Text = "Imprimir Mapa";
            this.chimprimirmapa.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(516, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Nº Reserva";
            // 
            // txtnroreserva
            // 
            this.txtnroreserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtnroreserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnroreserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnroreserva.Location = new System.Drawing.Point(519, 85);
            this.txtnroreserva.Name = "txtnroreserva";
            this.txtnroreserva.ReadOnly = true;
            this.txtnroreserva.Size = new System.Drawing.Size(69, 29);
            this.txtnroreserva.TabIndex = 52;
            this.txtnroreserva.Text = "0";
            this.txtnroreserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(53, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 18);
            this.label8.TabIndex = 54;
            this.label8.Text = "*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(95, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 18);
            this.label11.TabIndex = 55;
            this.label11.Text = "*";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // frmreserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 538);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnroreserva);
            this.Controls.Add(this.chimprimirmapa);
            this.Controls.Add(this.chvigente);
            this.Controls.Add(this.chvencido);
            this.Controls.Add(this.chanulado);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmetros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtidterreno);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmreserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESERVA";
            this.Load += new System.EventHandler(this.frmreserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtci;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtidterreno;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtmetros;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.CheckBox chanulado;
        private System.Windows.Forms.CheckBox chvencido;
        private System.Windows.Forms.CheckBox chvigente;
        private System.Windows.Forms.CheckBox chimprimirmapa;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtnroreserva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
    }
}