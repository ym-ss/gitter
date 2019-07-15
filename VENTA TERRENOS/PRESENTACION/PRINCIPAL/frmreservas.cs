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
    public partial class frmreservas : Form
    {
        public frmreservas()
        {
            InitializeComponent();
        }
        public int _idusuarioactivo = 1;
        public string _usuarioactivo = "0";
        creserva obj = new creserva();
        public void Listar()
        {
            
            obj.Listar(dataGridView1, txtci.Text);
        }

        public void ListarXfecha()
        {
            obj.ListarXfecha(dataGridView1, dtinicio.Value.ToShortDateString()+" 00:00", dtfinal.Value.ToShortDateString()+ " 23:59:59.999",txtci.Text);
        }
        private void MNUEVO_Click(object sender, EventArgs e)
        {
            frmreserva frm = new frmreserva();
            frm._idusuarioactivo = _idusuarioactivo;
            frm._usuarioactivo = _usuarioactivo;
            frm._evento = "NUEVO";
            frm.ShowDialog();
            Listar();
        }

        private void MMODIFICAR_Click(object sender, EventArgs e)
        {
            creservadetalle det = new creservadetalle();
            creserva res = new creserva();

            //ANULAR
            if (DialogResult.Yes == MessageBox.Show("Esta seguro de Anular la RESERVA?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                
                det.AnularDetalle_De_Reserva(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                res.AnularReserva(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                Listar();
            }

        }

        private void MHABILITAR_Click(object sender, EventArgs e)
        {

        }

        private void MIMPRIMIR_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount>0)
            {
                creportereservas rep = new creportereservas();

                rep.GenerarReporte(dataGridView1, "habilitado", "RESERVA DE TERRENO",_usuarioactivo, "ATRIBUTO", "PARAMETRO", "ESTADO");
            }
           
        }

        private void MCERRAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            ListarXfecha();
        }

        private void txtci_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void frmreservas_Load(object sender, EventArgs e)
        {
            //ListarXfecha();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
