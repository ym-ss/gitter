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
    public partial class frmterrenotipos : Form
    {
        public frmterrenotipos()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            cterrenotipo obj = new cterrenotipo();
            obj.Listar(dataGridView1, txtbuscar.Text);
        }

        private void MNUEVO_Click(object sender, EventArgs e)
        {
            frmterrenotipo frm = new frmterrenotipo();
            frm._evento = "NUEVO";
            frm.ShowDialog();
            Listar();
        }

        private void MMODIFICAR_Click(object sender, EventArgs e)
        {
            frmterrenotipo frm = new frmterrenotipo();
            frm.ObtenerRegistro(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frm._evento = "MODIFICAR";
            //frm.txtci.ReadOnly = true;
            frm.ShowDialog();
            Listar();
        }

        private void MHABILITAR_Click(object sender, EventArgs e)
        {
            frmterrenotipo frm = new frmterrenotipo();
            frm.ObtenerRegistro(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "HABILITADO")
            {
                frm._evento = "HABILITAR";
            }
            else
            {
                frm._evento = "DESHABILITAR";
            }

            //frm.txtci.ReadOnly = true;
            frm.ShowDialog();
            Listar();
        }

        private void MIMPRIMIR_Click(object sender, EventArgs e)
        {
            try
            {
                creportetodo rep = new creportetodo();
                rep.GenerarReporte(dataGridView1, "", "LISTA DE TIPO DE TERRENO", "-", "-", "", "");
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

        private void frmterrenotipos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
