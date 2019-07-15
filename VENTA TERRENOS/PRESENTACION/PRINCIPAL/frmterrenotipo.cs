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
    public partial class frmterrenotipo : Form
    {
        public frmterrenotipo()
        {
            InitializeComponent();
        }

        public string _evento = "";
        private cterrenotipo obj = new cterrenotipo();

        #region Aceptar
        public void Limpiar()
        {
            MostrarColores();
            txtnombre.Clear();  
            txtnombre.Focus();

        }
        
        public void ObtenerRegistro(string id_)
        {
            DataTable dt = new DataTable();

            obj = obj.ObtenerRegistro(id_);
            txtnombre.Text = obj.Nombre;
            cb.Text = obj.Color;
        }
        public void Aceptar()
        {
            try
            {

                obj.Nombre = txtnombre.Text;
                obj.Color = cb.Text;
                obj.Estado = "HABILITADO";

                if (_evento == "NUEVO")
                {
                    if (obj.Duplicado(txtnombre.Text))
                    {
                        MessageBox.Show("Ya existe un registro similar.");
                        txtnombre.Focus();
                    }
                    else
                    {
                        if (obj.Registrar())
                        {
                            MessageBox.Show("Registrado correctamente");
                            //Limpiar();
                        }
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
        #endregion

        public void MostrarColores()
        {
            cb.Items.Clear();
            string[] colores = Enum.GetNames(typeof(System.Drawing.KnownColor));
            cb.Items.AddRange(colores);
        }
        private void cb_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                string texto = cb.Items[e.Index].ToString();
                Brush borde = new SolidBrush(e.ForeColor);
                Color color = Color.FromName(texto);
                Brush pincel = new SolidBrush(color);
                Pen boli = new Pen(e.ForeColor);

                e.Graphics.DrawRectangle(boli, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 20, e.Bounds.Height - 5));
                e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 19, e.Bounds.Height - 6));
                e.Graphics.DrawString(texto, e.Font, borde, e.Bounds.Left + 23, e.Bounds.Top + 2);
                e.DrawFocusRectangle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmterrenotipo_Load(object sender, EventArgs e)
        {
            MostrarColores();
            cb.SelectedIndex = 0;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (cb.Text=="Red")
            {
                MessageBox.Show("El color se encuentra destinado para Reservas.");
            }
            else
            {
                Aceptar();
            }
           
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
