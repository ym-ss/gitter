using CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRINCIPAL
{
    public partial class frmcliente : Form
    {
        public frmcliente()
        {
            InitializeComponent();
        }

        public string _evento = "";
        private ccliente obj = new ccliente();

        #region Aceptar
        public void Limpiar()
        {
            txtapellidos.Clear();
            txtci.Clear();
            txtcorreo.Clear();
            txtnit.Clear();
            txtnombres.Clear();
            txttelefono.Clear();
            txtci.Focus();
        }
        public int CalcularEdad(DateTime fechaNacimiento)
        {
            //DateTime nacimiento = dtfechanac.Value; //Fecha de nacimiento
            //int edad = DateTime.Today.AddTicks(-dtfechanac.Value.Ticks).Year - 1;
            //return edad;

            // Obtiene la fecha actual:
            DateTime fechaActual = DateTime.Today;

            // Comprueba que la se haya introducido una fecha válida; si
            // la fecha de nacimiento es mayor a la fecha actual se muestra mensaje
            // de advertencia:
            if (fechaNacimiento > fechaActual)
            {
                Console.WriteLine("La fecha de nacimiento es mayor que la actual.");
                return -1;
            }
            else
            {
                int edad = fechaActual.Year - fechaNacimiento.Year;

                // Comprueba que el mes de la fecha de nacimiento es mayor
                // que el mes de la fecha actual:
                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                }

                return edad;
            }
        }
        public void ObtenerRegistro(string ci)
        {
            DataTable dt = new DataTable();

            obj = obj.ObtenerRegistro(ci);
            txtci.Text = obj.Ci;
            txtnombres.Text = obj.Nombre;
            txtapellidos.Text = obj.Apellidos;
            txtnit.Text = obj.Nit;
            txtcorreo.Text = obj.Correo;
            txttelefono.Text = obj.Telefono;
            dtfechanac.Value = Convert.ToDateTime(obj.FechaNac);
            cmbsexo.Text = obj.Sexo;


        }
        public void Aceptar()
        {
            try
            {
                obj.Ci = txtci.Text;
                obj.Nombre = txtnombres.Text;
                obj.Apellidos = txtapellidos.Text;
                obj.Nit = txtnit.Text;
                obj.Telefono = txttelefono.Text;
                obj.Sexo = cmbsexo.Text;
                obj.FechaNac = dtfechanac.Value.ToShortDateString();
                obj.Correo = txtcorreo.Text;
                obj.Edad = CalcularEdad(dtfechanac.Value).ToString();
                obj.Estado = "HABILITADO";

                if (_evento =="NUEVO")
                {
                    if (txtci.TextLength>0 & txtnombres.TextLength >0 & txtapellidos.TextLength>0 & txttelefono.TextLength>0)
                    {
                        if (obj.Duplicado(txtci.Text))
                        {
                            MessageBox.Show("Ya existe un registro similar.");
                            txtci.Focus();
                        }
                        else
                        {
                            if (obj.Registrar())
                            {
                                MessageBox.Show("Registrado correctamente");
                                Limpiar();
                            }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Rellene los datos requeridos por favor.");
                    }
                    
                    
                }
                if (_evento=="MODIFICAR")
                {
                    if (obj.Editar())
                    {
                        MessageBox.Show("Modificado correctamente");
                        Close();
                    }
                }
                if (_evento=="HABILITAR")
                {
                    if (obj.DesHabilitar())
                    {
                        MessageBox.Show("Registro Deshabilitado correctamente");
                        Close();
                    }
                }
                if (_evento == "DESHABILITAR")
                {
                    if (obj.Habilitar())
                    {
                        MessageBox.Show("Registro Habilitado correctamente");
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmcliente_Load(object sender, EventArgs e)
        {
            cmbsexo.SelectedIndex = 0;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Aceptar();
        }
    }
}
