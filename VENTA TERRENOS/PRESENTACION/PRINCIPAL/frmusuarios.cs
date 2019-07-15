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
    public partial class frmusuarios : Form
    {
        public frmusuarios()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            cusuario obj = new cusuario();
            obj.Listar(dataGridView1, txtci.Text);
        }

        private void MNUEVO_Click(object sender, EventArgs e)
        {
            frmusuario frm = new frmusuario();
            frm._evento = "NUEVO";
            frm.CargarRoles();
            frm.ShowDialog();
            Listar();
        }

        private void MMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount>0)
            {
                frmusuario frm = new frmusuario();
                frm.ObtenerRegistro(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                frm._evento = "MODIFICAR";
                frm.idusuario_ = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                frm.CargarRoles();
                frm.ObtenerRegistro(frm.idusuario_);
                frm.BuscarItemsCombobox();

                frm.txtusuario.ReadOnly = true;
                frm.ShowDialog();
                Listar();
            }
           
        }

        private void MHABILITAR_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount>0)
            {
                frmusuario frm = new frmusuario();
                frm.idusuario_ = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.ObtenerRegistro(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "HABILITADO")
                {
                    frm._evento = "HABILITAR";
                }
                else
                {
                    frm._evento = "DESHABILITAR";
                }

                frm.txtusuario.ReadOnly = true;
                frm.ShowDialog();
                Listar();
            }
            
        }

        private void MIMPRIMIR_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                try
                {
                    creportetodo rep = new creportetodo();
                    rep.GenerarReporte(dataGridView1, "", "LISTA DE USUARIOS", "-", "-", "", "");
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

        private void txtci_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void frmusuarios_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
