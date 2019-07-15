using CLASES;
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
    public partial class frmterrenoeliminar : Form
    {
        public frmterrenoeliminar()
        {
            InitializeComponent();
        }
        cterreno ter = new cterreno();
        public void Listar()
        {
            if (cmbestado.Text == "TODOS")
            {
                ter.Listar(dataGridView1, txtci.Text);
            }
            else
            {
                //MessageBox.Show(cmbestado.Text);
                ter.ListarEstado(dataGridView1, txtci.Text, cmbestado.Text);
            }

        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void MCERRAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MELIMINAR_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "RESERVADO")
                {
                    MessageBox.Show("El terreno no se puede eliminar por que se encuentra reservado.");
                }
                else
                {
                    DialogResult res = MessageBox.Show("Realmente desea Eliminar?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (res == DialogResult.OK)
                    {
                        string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        ter.Eliminar(id);
                        Listar();
                    }
                }
                
            }
        }

        private void frmterrenoeliminar_Load(object sender, EventArgs e)
        {
            cmbestado.SelectedIndex = 0;
        }
    }
}
