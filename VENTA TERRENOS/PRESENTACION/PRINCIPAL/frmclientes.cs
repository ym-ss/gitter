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
    public partial class frmclientes : Form
    {
        public frmclientes()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            ccliente obj = new ccliente();
            obj.Listar(dataGridView1, txtci.Text);
        }
        private void MNUEVO_Click(object sender, EventArgs e)
        {
            frmcliente frm = new frmcliente();
            frm._evento = "NUEVO";
            frm.ShowDialog();
            Listar();
        }

        private void MMODIFICAR_Click(object sender, EventArgs e)
        {
            frmcliente frm = new frmcliente();
            frm.ObtenerRegistro(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frm._evento = "MODIFICAR";
            frm.txtci.ReadOnly= true;
            frm.ShowDialog();
            Listar();
        }

        private void MHABILITAR_Click(object sender, EventArgs e)
        {
            
            frmcliente frm = new frmcliente();
            frm.ObtenerRegistro(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (dataGridView1.CurrentRow.Cells[9].Value.ToString() == "HABILITADO")
            {
                frm._evento = "HABILITAR";
            }
            else
            {
                frm._evento = "DESHABILITAR";
            }
            
            frm.txtci.ReadOnly = true;
            frm.ShowDialog();
            Listar();
        }

        private void MIMPRIMIR_Click(object sender, EventArgs e)
        {
            try
            {
                creportetodo rep = new creportetodo();
                rep.GenerarReporte(dataGridView1, "", "LISTA DE CLIENTES", "-", "-", "", "");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MCERRAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmclientes_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void txtci_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
