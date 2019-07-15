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
    public partial class frmrol : Form
    {
        public frmrol()
        {
            InitializeComponent();
        }

        public string _evento = "";
        private crol obj = new crol();
        public string idusuario_ = "0";


        public void Limpiar()
        {
            TXTNOMBRE.Clear();
            TXTNOMBRE.Focus();
        }

        public void ObtenerRegistro(string id)
        {
            DataTable dt = new DataTable();

            obj = obj.ObtenerRegistro(id);
            TXTNOMBRE.Text = obj.Nombre;
            
        }

        public void Aceptar()
        {
            try
            {
                obj.Idrol = int.Parse(idusuario_);
                obj.Nombre = TXTNOMBRE.Text;
                obj.Estado = "HABILITADO";

                if (_evento == "NUEVO")
                {

                    if (obj.Registrar())
                    {
                        obj.RegistrarPermisos();
                        MessageBox.Show("Registrado correctamente");
                        Limpiar();
                    }
                }
                if (_evento == "MODIFICAR")
                {
                    if (obj.Editar())
                    {
                        MessageBox.Show("Registrado correctamente");
                        Close();
                    }
                }
                if (_evento == "HABILITAR")
                {
                    if (obj.DesHabilitar())
                    {
                        MessageBox.Show("Registrado correctamente");
                        Close();
                    }
                }
                if (_evento == "DESHABILITAR")
                {
                    if (obj.Habilitar())
                    {
                        MessageBox.Show("Registrado correctamente");
                        Close();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

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
