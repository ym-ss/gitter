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
    public partial class frmterrenos : Form
    {
        public frmterrenos()
        {
            InitializeComponent();
        }
        cterreno ter = new cterreno();
        public void Listar()
        {
            if (cmbestado.Text=="TODOS")
            {
                ter.Listar(dataGridView1, txtci.Text);
            }
            else
            {
                //MessageBox.Show(cmbestado.Text);
                ter.ListarEstado(dataGridView1, txtci.Text, cmbestado.Text);
            }
           
        }

        private void MNUEVO_Click(object sender, EventArgs e)
        {
            frmterreno frm = new frmterreno();
            frm.ShowDialog();
            Listar();
        }

        private void MMODIFICAR_Click(object sender, EventArgs e)
        {

        }

        private void MHABILITAR_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount>0)
            {

                if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "HABILITADO")
                {
                    DialogResult res = MessageBox.Show("Realmente desea Deshabilitar?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (res == DialogResult.OK)
                    {
                        string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        ter.DesHabilitar(id);
                        Listar();
                    }

                }
                else
                {
                    DialogResult res = MessageBox.Show("Realmente desea Habilitar?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (res == DialogResult.OK)
                    {
                        string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        ter.Habilitar(id);
                        Listar();

                    }
                }
            }
           

        }

        private void MIMPRIMIR_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount>0)
            {
                try
                {
                    creportetodo rep = new creportetodo();
                    rep.GenerarReporte(dataGridView1, "", "LISTA DE TERRENOS", "-", "-", "", "");
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

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void txtci_TextChanged(object sender, EventArgs e)
        {
            //Listar();
        }

        private void frmterrenos_Load(object sender, EventArgs e)
        {
            cmbestado.SelectedIndex = 0;
            //Listar();
        }
    }
}
