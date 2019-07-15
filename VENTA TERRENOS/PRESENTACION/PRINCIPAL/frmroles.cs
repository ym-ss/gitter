using CLASES;
using CLASES.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRINCIPAL
{
    public partial class frmroles : Form
    {
        public frmroles()
        {
            InitializeComponent();
        }
        crol obj = new crol();
        public void Listar()
        {
            
            obj.Listar(dataGridView1, txtci.Text);
        }

       

        private void frmroles_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void MNUEVO_Click(object sender, EventArgs e)
        {
            frmrol frm = new frmrol();
            frm._evento = "NUEVO";
            
            frm.ShowDialog();
            Listar();
        }

        private void MMODIFICAR_Click(object sender, EventArgs e)
        {
            frmrol frm = new frmrol();
            frm.ObtenerRegistro(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frm._evento = "MODIFICAR";
            frm.idusuario_ = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.ShowDialog();
            Listar();
        }

        private void MHABILITAR_Click(object sender, EventArgs e)
        {
            frmrol frm = new frmrol();
            frm.idusuario_ = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.ObtenerRegistro(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "HABILITADO")
            {
                frm._evento = "HABILITAR";
            }
            else
            {
                frm._evento = "DESHABILITAR";
            }

            frm.TXTNOMBRE.ReadOnly = true;
            frm.ShowDialog();
            Listar();
        }

        private void MIMPRIMIR_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount>0)
            {
                try
                {
                    creportetodo rep = new creportetodo();
                    rep.GenerarReporte(dataGridView1, "", "LISTA DE ROLES DE USUARIO", "-", "-", "", "");
                }
                catch (Exception)
                {

                    throw;
                }
            }
           
        }

        private void MCERRAR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
