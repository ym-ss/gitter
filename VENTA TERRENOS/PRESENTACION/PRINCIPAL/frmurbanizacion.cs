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
    public partial class frmurbanizacion : Form
    {
        public frmurbanizacion()
        {
            InitializeComponent();
        }

        public string _evento = "";
        private curbanizacion obj = new curbanizacion();

        #region Aceptar
        public void Limpiar()
        {
            txtcantidad.Clear();
            txtdireccion.Clear();
            txtsuperficie.Clear();
            txturbanizacion.Clear();
            txturbanizacion.Focus();
        }
       
        public void ObtenerRegistro(string id)
        {
            DataTable dt = new DataTable();

            obj = obj.ObtenerRegistro(id);
            txturbanizacion.Text = obj.Urbanizacion;
            txtsuperficie.Text = obj.Superficie;
            txtdireccion.Text = obj.Direccion;
            txtcantidad.Text = obj.CantTerrenos.ToString();
            


        }
        public void Aceptar()
        {
            try
            {
                obj.CantTerrenos =int.Parse( txtcantidad.Text);
                obj.Direccion = txtdireccion.Text;
                obj.Superficie = txtsuperficie.Text;
                obj.Urbanizacion = txturbanizacion.Text;
                obj.Estado = "HABILITADO";

                if (_evento == "NUEVO")
                {
                    if (txturbanizacion.TextLength > 0)
                    {
                        if (obj.Registrar())
                        {
                            MessageBox.Show("Registrado correctamente");
                            Limpiar();
                        }
                    }
                    else
                        MessageBox.Show("Rellene los datos requeridos.");
                    
                }
                if (_evento == "MODIFICAR")
                {
                    if (obj.Editar())
                    {
                        MessageBox.Show("Modificado correctamente");
                        Close();
                    }
                }
                if (_evento == "HABILITAR")
                {
                    if (obj.DesHabilitar())
                    {
                        MessageBox.Show("Habilitado correctamente");
                        Close();
                    }
                }
                if (_evento == "DESHABILITAR")
                {
                    if (obj.Habilitar())
                    {
                        MessageBox.Show("Habilitado correctamente");
                        Close();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Aceptar();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
