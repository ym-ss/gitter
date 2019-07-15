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
    public partial class frmusuario: Form
    {
        public frmusuario()
        {
            InitializeComponent();
        }

        public string _evento = "";
        private cusuario    obj = new cusuario();
        private crol crol = new crol();
        public string idusuario_ = "0";
        public string idrol_ = "0";

      
        public void Limpiar()
        {
            txtapellidos.Clear();
            txtnombre.Clear();
            txtpass.Clear();
            txtusuario.Clear();
            
            txtnombre.Focus();
        }

        public void CargarRoles()
        {

            crol.CargarRol(cmrol);
        }
        public void BuscarItemsCombobox()
        {
            // MessageBox.Show(idrol_);
            cmrol.SelectedIndex = buscaElementoCmb(idrol_, ref cmrol);
        }

        public int buscaElementoCmb(string elemento, ref ComboBox CMB)
        {
            int indice=0;
            int total = CMB.Items.Count;
            int j = CMB.Items.Count - 1;

            for (int i = 0; i <= j; i++)
            {
                CMB.SelectedIndex = i;
                string VALOR = CMB.SelectedValue.ToString();
                if (VALOR == elemento)
                    indice = i;
            }
            return indice;
        }

        public void ObtenerRegistro(string id)
        {
            DataTable dt = new DataTable();
            
            obj = obj.ObtenerRegistro(id);
            txtnombre.Text = obj.Nombre;
            txtapellidos.Text = obj.Apellidos;
            idrol_ = obj.Idrol;

            txtusuario.Text = obj.Usuario;
            txtpass.Text = obj.Pass;
        }
        public void Aceptar()
        {
            try
            {
                obj.Idusuario = int.Parse(idusuario_);
                obj.Nombre = txtnombre.Text;
                obj.Apellidos = txtapellidos.Text;
                obj.Usuario = txtusuario.Text;
                obj.Pass = txtpass.Text;
                obj.FechaReg = DateTime.Now.ToShortDateString();
                obj.Idrol = cmrol.SelectedValue.ToString();
                obj.Estado = "HABILITADO";

                if (_evento == "NUEVO")
                {
                    if (txtnombre.TextLength>0 && txtusuario.TextLength>0)
                    {
                        if (!obj.Duplicado(txtusuario.Text))
                        {
                            if (obj.Registrar())
                            {
                                MessageBox.Show("Registrado correctamente");
                                Limpiar();
                            }
                        }
                        else
                        {
                            MessageBox.Show("El usuario ya existe.");
                            txtusuario.Focus();
                            txtusuario.SelectAll();
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Rellene los datos por favor.");
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
            //_evento = "NUEVO";
            Aceptar();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmusuario_Load(object sender, EventArgs e)
        {
            //CargarRoles();
        }
    }
}