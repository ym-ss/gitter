using CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRINCIPAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string IDUSUARIOACTIVO = "0";
        public string USUARIOACTIVO = "0";
        public string IDROL = "0";
        public string idcargoactivo = "0";

        private cpermiso cper = new cpermiso();
       
        private void button1_Click(object sender, EventArgs e)
        {
            frmreporteusuario frm = new frmreporteusuario();
            frm.Show();
        }

        public void CargarPermisosMenuPadre()
        {
            DataSet ds = new DataSet();
            DataGridView dgv = new DataGridView();
            ToolStripItem[] item = new ToolStripItem[50];

            ds = cper.ObtenerPermisoUsuarioMenu(IDROL, ref dgv);
           // MessageBox.Show(IDROL);
            if (ds!=null)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    try
                    {
                        string dato = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                        item = menuStrip1.Items.Find(dato, true);
                        item[0].Enabled = true;
                    }
                    catch (Exception)
                    {
                    }
                }
            }
           

        }

        private void miniciarsesion_Click(object sender, EventArgs e)
        {
            CerrarSesion();
            frmsesion frm = new frmsesion();
            //frm.MdiParent = this;
            frm.ShowDialog();
            if (frm.ingreso)
            {
                lblusuarioactivo.Text = frm._usuario;
                USUARIOACTIVO = frm._usuario;
                IDUSUARIOACTIVO = frm._idusuario;
                IDROL = frm._idrol;

                CargarPermisosMenuPadre();
            }
            //frm.Location = new System.Drawing.Point(10, 10);
        }

        public void CerrarSesion()
        {
            lblusuarioactivo.Text = "---";
            IDUSUARIOACTIVO = "0";
            mcliente.Enabled = false;
            murbanizacion.Enabled = false;
            mterreno.Enabled = false;
            mtipoterreno.Enabled = false;
            mreserva.Enabled = false;
            minforme.Enabled = false;
            musuario.Enabled = false;
            mroles.Enabled = false;
            mpermisos.Enabled = false;
            mdatosempresa.Enabled = false;
            mterrenolibre.Enabled = false;
            meliminarterreno.Enabled = false;
        }

        private void mcerrarsesion_Click(object sender, EventArgs e)
        {
            CerrarSesion();
        }

        private void msalir_Click(object sender, EventArgs e)
        {
            //Close();
            CargarPermisosMenuPadre();
        }

        private void mcliente_Click(object sender, EventArgs e)
        {
            frmclientes frm = new frmclientes();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new System.Drawing.Point(1, 1);
        }

        private void murbanizacion_Click(object sender, EventArgs e)
        {
            frmurbanizaciones frm = new frmurbanizaciones();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new System.Drawing.Point(1, 1);
        }

        private void mterreno_Click(object sender, EventArgs e)
        {
            frmterrenos frm = new frmterrenos();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new System.Drawing.Point(1, 1);
        }

        private void mtipoterreno_Click(object sender, EventArgs e)
        {
            frmterrenotipos frm = new frmterrenotipos();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new System.Drawing.Point(1, 1);
        }

        private void mreserva_Click(object sender, EventArgs e)
        {
            frmreservas frm = new frmreservas();
            frm._idusuarioactivo =int.Parse( IDUSUARIOACTIVO);
            frm._usuarioactivo = USUARIOACTIVO;
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new System.Drawing.Point(1, 1);
        }

        private void minforme_Click(object sender, EventArgs e)
        {
            frmreporteusuario frm = new frmreporteusuario();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new System.Drawing.Point(1, 1);
        }

        private void musuario_Click(object sender, EventArgs e)
        {
            frmusuarios frm = new frmusuarios();
            frm.MdiParent = this;
            
            frm.Show();
            frm.Location = new System.Drawing.Point(1, 1);
        }

        private void mpermisos_Click(object sender, EventArgs e)
        {
            frmpermisos frm = new frmpermisos();
            frm.MdiParent = this;

            frm.Show();
            frm.Location = new System.Drawing.Point(1, 1);
        }

        private void mdatosempresa_Click(object sender, EventArgs e)
        {
            frmdatosempresa frm = new frmdatosempresa();
            frm.ShowDialog();
        }

        private void macercadesistema_Click(object sender, EventArgs e)
        {
            frmacerca frm = new frmacerca();
            frm.ShowDialog();
        }

        private void mroles_Click(object sender, EventArgs e)
        {
            frmroles frm = new frmroles();
            frm.MdiParent = this;
         
            frm.Show();
            frm.Location = new System.Drawing.Point(1, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CerrarSesion();
        }

        private void mterrenolibre_Click(object sender, EventArgs e)
        {
            frmlibres frm = new frmlibres();
            frm.MdiParent = this;

            frm.Show();
            frm.Location = new System.Drawing.Point(1, 1);
        }

        private void meliminarterreno_Click(object sender, EventArgs e)
        {
            frmterrenoeliminar frm = new frmterrenoeliminar();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new System.Drawing.Point(1, 1);
        }
    }
}
