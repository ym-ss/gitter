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
    public partial class frmreporteusuario : Form
    {
        public frmreporteusuario()
        {
            InitializeComponent();
        }
        creporteusuario usu = new creporteusuario();
        public void Listar()
        {
            
            usu.Listar(dataGridView1, "", dtfecha.Value.ToShortDateString());
        }
        private void frmreporteusuario_Load(object sender, EventArgs e)
        {
            
        }

        private void MCERRAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnmes_Click(object sender, EventArgs e)
        {
            usu.ListarReservaMes(dataGridView1);
        }

        private void btndia_Click(object sender, EventArgs e)
        {
            usu.ListarReservaDia(dataGridView1);
        }
    }
}
