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
    public partial class frmsesion : Form
    {
        public frmsesion()
        {
            InitializeComponent();
        }
        cusuario usu = new cusuario();
        public bool ingreso= false;
        public string _idusuario = "";
        public string _usuario = "";
        public string _usuarioHabilitado = "";
        public string _idrol = "0";

        public void IniciarSesion()
        {
            try
            {
                if (usu.ExisteUsuario(txtusuario.Text))
                {
                    if (usu.VerificarUsuarioPass(txtusuario.Text, txtpass.Text,ref _idusuario, ref _usuarioHabilitado, ref _idrol))
                    {
                        if (_usuarioHabilitado=="HABILITADO")
                        {
                            _usuario = txtusuario.Text;

                            ingreso = true;
                            //MessageBox.Show("Bienvenido");

                            Close();
                        }
                        else
                        {
                            MessageBox.Show("El usuario: " + txtusuario.Text + " esta Deshabilitado.");
                            txtusuario.Focus();
                        }

                        
                    }
                    else
                    {
                        MessageBox.Show("Error al iniciar sesion. \n Asegurese de colocar el usuario y contraseña correcta.");
                        txtpass.Focus();
                        txtpass.SelectAll();
                    }
                }
                else
                {

                    MessageBox.Show("Error al iniciar sesion. \n Asegurese de colocar el usuario y contraseña correcta.");
                    txtusuario.Focus();
                    txtusuario.SelectAll();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al iniciar sesion. \n Asegurese de colocar el usuario y contraseña correcta.");
            }
            
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnaceptar.Focus();
            }
        }
    }
}
