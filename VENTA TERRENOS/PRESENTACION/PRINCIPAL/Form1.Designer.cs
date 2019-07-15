namespace PRINCIPAL
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miniciarsesion = new System.Windows.Forms.ToolStripMenuItem();
            this.mcerrarsesion = new System.Windows.Forms.ToolStripMenuItem();
            this.msalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mclientesss = new System.Windows.Forms.ToolStripMenuItem();
            this.mcliente = new System.Windows.Forms.ToolStripMenuItem();
            this.murbanizacion = new System.Windows.Forms.ToolStripMenuItem();
            this.mtipoterreno = new System.Windows.Forms.ToolStripMenuItem();
            this.mterreno = new System.Windows.Forms.ToolStripMenuItem();
            this.meliminarterreno = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mreserva = new System.Windows.Forms.ToolStripMenuItem();
            this.mterrenolibre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.minforme = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mroles = new System.Windows.Forms.ToolStripMenuItem();
            this.mpermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.musuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mdatosempresa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.macercadesistema = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblusuarioactivo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(742, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mclientesss,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miniciarsesion,
            this.mcerrarsesion,
            this.msalir});
            this.toolStripMenuItem1.Image = global::PRINCIPAL.Properties.Resources.home;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 36);
            // 
            // miniciarsesion
            // 
            this.miniciarsesion.Image = global::PRINCIPAL.Properties.Resources.adim;
            this.miniciarsesion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miniciarsesion.Name = "miniciarsesion";
            this.miniciarsesion.Size = new System.Drawing.Size(175, 38);
            this.miniciarsesion.Text = "INICIAR SESION";
            this.miniciarsesion.Click += new System.EventHandler(this.miniciarsesion_Click);
            // 
            // mcerrarsesion
            // 
            this.mcerrarsesion.Image = global::PRINCIPAL.Properties.Resources.delete_user;
            this.mcerrarsesion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mcerrarsesion.Name = "mcerrarsesion";
            this.mcerrarsesion.Size = new System.Drawing.Size(175, 38);
            this.mcerrarsesion.Text = "CERRAR SESION";
            this.mcerrarsesion.Click += new System.EventHandler(this.mcerrarsesion_Click);
            // 
            // msalir
            // 
            this.msalir.Image = global::PRINCIPAL.Properties.Resources.ball_red;
            this.msalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msalir.Name = "msalir";
            this.msalir.Size = new System.Drawing.Size(175, 38);
            this.msalir.Text = "SALIR";
            this.msalir.Click += new System.EventHandler(this.msalir_Click);
            // 
            // mclientesss
            // 
            this.mclientesss.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mcliente,
            this.murbanizacion,
            this.mtipoterreno,
            this.mterreno,
            this.meliminarterreno});
            this.mclientesss.Image = global::PRINCIPAL.Properties.Resources.db2;
            this.mclientesss.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mclientesss.Name = "mclientesss";
            this.mclientesss.Size = new System.Drawing.Size(44, 36);
            // 
            // mcliente
            // 
            this.mcliente.Image = global::PRINCIPAL.Properties.Resources.users;
            this.mcliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mcliente.Name = "mcliente";
            this.mcliente.Size = new System.Drawing.Size(203, 38);
            this.mcliente.Text = "CLIENTES";
            this.mcliente.Click += new System.EventHandler(this.mcliente_Click);
            // 
            // murbanizacion
            // 
            this.murbanizacion.Image = global::PRINCIPAL.Properties.Resources.box;
            this.murbanizacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.murbanizacion.Name = "murbanizacion";
            this.murbanizacion.Size = new System.Drawing.Size(203, 38);
            this.murbanizacion.Text = "URBANIZACION";
            this.murbanizacion.Click += new System.EventHandler(this.murbanizacion_Click);
            // 
            // mtipoterreno
            // 
            this.mtipoterreno.Image = global::PRINCIPAL.Properties.Resources.map;
            this.mtipoterreno.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mtipoterreno.Name = "mtipoterreno";
            this.mtipoterreno.Size = new System.Drawing.Size(203, 38);
            this.mtipoterreno.Text = "TIPO TERRENO";
            this.mtipoterreno.Click += new System.EventHandler(this.mtipoterreno_Click);
            // 
            // mterreno
            // 
            this.mterreno.Image = global::PRINCIPAL.Properties.Resources.ball_green;
            this.mterreno.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mterreno.Name = "mterreno";
            this.mterreno.Size = new System.Drawing.Size(203, 38);
            this.mterreno.Text = "TERRENO";
            this.mterreno.Click += new System.EventHandler(this.mterreno_Click);
            // 
            // meliminarterreno
            // 
            this.meliminarterreno.Image = global::PRINCIPAL.Properties.Resources.delete;
            this.meliminarterreno.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.meliminarterreno.Name = "meliminarterreno";
            this.meliminarterreno.Size = new System.Drawing.Size(203, 38);
            this.meliminarterreno.Text = "ELIMINAR TERRENOS";
            this.meliminarterreno.Click += new System.EventHandler(this.meliminarterreno_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mreserva,
            this.mterrenolibre});
            this.toolStripMenuItem3.Image = global::PRINCIPAL.Properties.Resources.shopping_cart_full;
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(44, 36);
            // 
            // mreserva
            // 
            this.mreserva.Image = global::PRINCIPAL.Properties.Resources.history;
            this.mreserva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mreserva.Name = "mreserva";
            this.mreserva.Size = new System.Drawing.Size(185, 38);
            this.mreserva.Text = "RESERVA";
            this.mreserva.Click += new System.EventHandler(this.mreserva_Click);
            // 
            // mterrenolibre
            // 
            this.mterrenolibre.Image = global::PRINCIPAL.Properties.Resources.folder;
            this.mterrenolibre.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mterrenolibre.Name = "mterrenolibre";
            this.mterrenolibre.Size = new System.Drawing.Size(185, 38);
            this.mterrenolibre.Text = "TERRENOS LIBRES";
            this.mterrenolibre.Click += new System.EventHandler(this.mterrenolibre_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minforme});
            this.toolStripMenuItem4.Image = global::PRINCIPAL.Properties.Resources.statistics;
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(44, 36);
            // 
            // minforme
            // 
            this.minforme.Image = global::PRINCIPAL.Properties.Resources.chart;
            this.minforme.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.minforme.Name = "minforme";
            this.minforme.Size = new System.Drawing.Size(218, 38);
            this.minforme.Text = "REPORTES DEL SISTEMA";
            this.minforme.Click += new System.EventHandler(this.minforme_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mroles,
            this.mpermisos,
            this.musuario,
            this.mdatosempresa});
            this.toolStripMenuItem5.Image = global::PRINCIPAL.Properties.Resources.flooter_settings;
            this.toolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(44, 36);
            // 
            // mroles
            // 
            this.mroles.Image = global::PRINCIPAL.Properties.Resources.applications1;
            this.mroles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mroles.Name = "mroles";
            this.mroles.Size = new System.Drawing.Size(199, 38);
            this.mroles.Text = "ROLES DE USUARIO";
            this.mroles.Click += new System.EventHandler(this.mroles_Click);
            // 
            // mpermisos
            // 
            this.mpermisos.Image = global::PRINCIPAL.Properties.Resources.iCandy_Junior_019;
            this.mpermisos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mpermisos.Name = "mpermisos";
            this.mpermisos.Size = new System.Drawing.Size(199, 38);
            this.mpermisos.Text = "PERMISOS";
            this.mpermisos.Click += new System.EventHandler(this.mpermisos_Click);
            // 
            // musuario
            // 
            this.musuario.Image = global::PRINCIPAL.Properties.Resources.iCandy_Junior_067;
            this.musuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.musuario.Name = "musuario";
            this.musuario.Size = new System.Drawing.Size(199, 38);
            this.musuario.Text = "USUARIO";
            this.musuario.Click += new System.EventHandler(this.musuario_Click);
            // 
            // mdatosempresa
            // 
            this.mdatosempresa.Image = global::PRINCIPAL.Properties.Resources.floppydrive2;
            this.mdatosempresa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mdatosempresa.Name = "mdatosempresa";
            this.mdatosempresa.Size = new System.Drawing.Size(199, 38);
            this.mdatosempresa.Text = "DATOS DE EMPRESA";
            this.mdatosempresa.Click += new System.EventHandler(this.mdatosempresa_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.macercadesistema});
            this.toolStripMenuItem2.Image = global::PRINCIPAL.Properties.Resources.help;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(44, 36);
            // 
            // macercadesistema
            // 
            this.macercadesistema.Image = global::PRINCIPAL.Properties.Resources.about;
            this.macercadesistema.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.macercadesistema.Name = "macercadesistema";
            this.macercadesistema.Size = new System.Drawing.Size(189, 38);
            this.macercadesistema.Text = "Acerca del Sistema";
            this.macercadesistema.Click += new System.EventHandler(this.macercadesistema_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblusuarioactivo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 641);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(891, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(64, 17);
            this.toolStripStatusLabel1.Text = "USUARIO:";
            // 
            // lblusuarioactivo
            // 
            this.lblusuarioactivo.Name = "lblusuarioactivo";
            this.lblusuarioactivo.Size = new System.Drawing.Size(32, 17);
            this.lblusuarioactivo.Text = "-----";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PRINCIPAL.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(891, 663);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SISTEMA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miniciarsesion;
        private System.Windows.Forms.ToolStripMenuItem mcerrarsesion;
        private System.Windows.Forms.ToolStripMenuItem msalir;
        private System.Windows.Forms.ToolStripMenuItem mclientesss;
        private System.Windows.Forms.ToolStripMenuItem mcliente;
        private System.Windows.Forms.ToolStripMenuItem murbanizacion;
        private System.Windows.Forms.ToolStripMenuItem mterreno;
        private System.Windows.Forms.ToolStripMenuItem mtipoterreno;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mreserva;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem minforme;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem musuario;
        private System.Windows.Forms.ToolStripMenuItem mpermisos;
        private System.Windows.Forms.ToolStripMenuItem mdatosempresa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblusuarioactivo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem macercadesistema;
        private System.Windows.Forms.ToolStripMenuItem mroles;
        private System.Windows.Forms.ToolStripMenuItem mterrenolibre;
        private System.Windows.Forms.ToolStripMenuItem meliminarterreno;
    }
}

