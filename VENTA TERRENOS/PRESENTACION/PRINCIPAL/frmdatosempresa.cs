using DATOS;
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
    public partial class frmdatosempresa: Form
    {
        public frmdatosempresa()
        {
            InitializeComponent();
        }

        private string consulta = "";
        conexion cnx = new conexion();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool EditarEmpresa()
        {
            try
            {
                consulta = "UPDATE DATOSEMPRESA SET NOMBRE='" + txtnombre.Text + "', DIRECCION='" + txtdireccion.Text + "', TELEFONO='" + txttelefono.Text + "', CORREO='" + txtcorreo.Text + "', DIARESERVA='" + nrodias.Value.ToString() + "' WHERE ID='1'";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void ObtenerRegistro()
        {
            try
            {
                consulta = "SELECT * FROM DATOSEMPRESA WHERE ID='1'";
                DataSet ds = new DataSet();
                
                ds = cnx.Listar(consulta, "DATOSEMPRESA");
                int cant = ds.Tables[0].Rows.Count;
                DataTable dt = ds.Tables[0];
                DataRow row = dt.Rows[0];
                txtcorreo.Text = row["CORREO"].ToString();
                txtnombre.Text = row["NOMBRE"].ToString();
                txttelefono.Text = row["TELEFONO"].ToString();
                txtdireccion.Text = row["DIRECCION"].ToString();
               nrodias.Value =int.Parse( row["DIARESERVA"].ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (EditarEmpresa())
            {
                MessageBox.Show("Se Modificaron los datos de la empresa.");
                Close();
            }
        }

        private void frmdatosempresa_Load(object sender, EventArgs e)
        {
            ObtenerRegistro();
        }
    }
}
