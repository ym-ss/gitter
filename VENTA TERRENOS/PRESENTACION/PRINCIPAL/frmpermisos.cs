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
    public partial class frmpermisos : Form
    {
        public frmpermisos()
        {
            InitializeComponent();
        }
        private crol crol = new crol();
        private cpermiso cper = new cpermiso();

        public void ListarPermisos()
        {
            try
            {
                cper.Listar(DGV, CMBESTADO.SelectedValue.ToString());
            }
            catch (Exception)
            {

                
            }
           
        }
        public void CargarRoles()
        {

            crol.CargarRol(CMBESTADO);
        }

        private void frmpermisos_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            ListarPermisos();
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bool.Parse( DGV.Rows[DGV.CurrentRow.Index].Cells[3].Value.ToString()) == false)
            {
                DGV.Rows[DGV.CurrentRow.Index].Cells[3].Value = true;
            }
            else
            {
                DGV.Rows[DGV.CurrentRow.Index].Cells[3].Value = false;
            }
        }

        private void MNUEVO_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < DGV.RowCount; i++)
                {
                    cper.GuardarCambios(DGV.Rows[i].Cells[0].Value.ToString(), DGV.Rows[i].Cells[3].Value.ToString());
                }
                MessageBox.Show("Cambios guardados correctamente.");
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void MCERRAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MIMPRIMIR_Click(object sender, EventArgs e)
        {
            if (DGV.RowCount > 0)
            {
                try
                {
                    creportetodo rep = new creportetodo();
                    rep.GenerarReporte(DGV, "", "LISTA DE PERMISOS A " + CMBESTADO.Text, "-", "-", "", "");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
