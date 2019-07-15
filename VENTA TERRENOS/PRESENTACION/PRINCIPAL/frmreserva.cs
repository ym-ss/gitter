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
    public partial class frmreserva : Form
    {
        public frmreserva()
        {
            InitializeComponent();
        }
        ccliente cli = new ccliente();
        cterreno ter = new cterreno();
        creserva res = new creserva();
        creservadetalle det = new creservadetalle();
        public int _idusuarioactivo = 1;
        public string _usuarioactivo = "0";
        public double _total = 0;
        public string _evento = "";
        public int _cantDgv = 0;

        public void _Aceptar()
        {
            try
            {
                //guardando la reserva
                res.Ci = txtci.Text;
                res.Fechareserva = DateTime.Now.ToString();
                res.EstadoReserva = "VIGENTE";
                res.Estado = "HABILITADO";
                res.IdUsuario = _idusuarioactivo; //falta enlazar
                res.Total = _total.ToString(); //falta proceso para total
                

                if (_evento == "NUEVO")
                {

                    if (res.Registrar())
                    {
                        //GUARDANDO EL DETALLE
                        for (int i = _cantDgv; i < dataGridView1.RowCount; i++)
                        {
                            det.Idterreno = dataGridView1[0, i].Value.ToString();
                            det.Precio= dataGridView1[1, i].Value.ToString();
                            det.FechaReserva = DateTime.Now.ToString();
                            det.EstadoReserva = "VIGENTE";
                            det.Estado = "FECHA VENCIDA";
                            det.Ci = txtci.Text;
                            det.Idusuario = _idusuarioactivo;
                            det.Idreserva = int.Parse(txtnroreserva.Text);
                            det.Registrar();

                            // cambiar a reservado el terreno
                            ter.CambiarReservado(dataGridView1[0, i].Value.ToString());

                        }
                        MessageBox.Show("Registrado correctamente");
                        GestionarUltimaReserva();
                        //Limpiar();
                    }
                }
                if (_evento == "MODIFICAR")
                {
                    if (res.Editar())
                    {
                        MessageBox.Show("Registrado correctamente");
                        Close();
                    }
                }
                if (_evento == "HABILITAR")
                {
                    //if (res.DesHabilitar())
                    {
                        MessageBox.Show("Registrado correctamente");
                        Close();
                    }
                }
                if (_evento == "DESHABILITAR")
                {
                    //if (obj.Habilitar())
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
        private void txtci_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                if (txtci.TextLength>2)
                {
                    if (cli.ExisteCliente(txtci.Text))
                    {

                        cli=cli.ObtenerRegistro(txtci.Text);
                        txtnombres.Text = cli.Nombre + " " + cli.Apellidos;
                        txtidterreno.Focus();

                        //verificar si tiene reserva de terrenos
                        PasarDatosTerrenosCliente();
                    }
                    else
                    {
                        MessageBox.Show("El cliente no esta registrado.");
                        dataGridView1.Rows.Clear();
                        txtnombres.Clear();
                        txtci.Focus();
                        txtci.SelectAll();
                    }
                }
                else
                {
                    dataGridView1.Rows.Clear();
                }
               
            }
        }

        public void PasarDatosTerrenosCliente()
        {
            dataGridView1.Rows.Clear();
            DataTable tb = new DataTable();
            if (chanulado.Checked)
            {
                if (chvencido.Checked)
                {
                    if (chvigente.Checked)
                    {
                        //ingresa aqui cuando esta seleccionado todos los check
                        det.ListarDetalleClienteTodos(ref tb, txtci.Text);
                    }
                    else
                        det.ListarDetalleClienteAnuladosVencido(ref tb, txtci.Text);
                }
                else
                {
                    if (chvigente.Checked)
                    {
                        det.ListarDetalleClienteVigenteAnulado(ref tb, txtci.Text);
                    }
                    else
                        det.ListarDetalleClienteAnulados(ref tb, txtci.Text);
                }
                    
            }
            else
            {
                if (chvencido.Checked)
                {
                    if (chvigente.Checked)
                    {
                        det.ListarDetalleClienteVigenteVencido(ref tb, txtci.Text);
                    }
                    else
                        det.ListarDetalleClienteVencidos(ref tb, txtci.Text);
                }
                else
                {
                    if (chvigente.Checked)
                    {
                        det.ListarDetalleClienteVigente(ref tb, txtci.Text);
                    }
                    else
                    {
                        chvigente.Checked = true;
                        det.ListarDetalleClienteVigente(ref tb, txtci.Text);
                    }
                }
                    
            }
            


            for (int i = 0; i < tb.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(tb.Rows[i]["IDTERRENO"], tb.Rows[i]["PRECIO"], tb.Rows[i]["METROS"], tb.Rows[i]["ESTADORESERVA"], tb.Rows[i]["FECHARES"], tb.Rows[i]["USUARIO"], tb.Rows[i]["ID"]);
            }
            _cantDgv = dataGridView1.RowCount;
            if (dataGridView1.RowCount>0)
            {
                btnlimpiar.Text = "Anular";
            }
            
        }

        private void txtidterreno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                if (txtidterreno.TextLength > 2)
                {
                    if (ter.ExisteTerreno(txtidterreno.Text))
                    {

                        btnadicionar.Enabled = true;
                        ter = ter.ObtenerRegistro(txtidterreno.Text);
                        if (ter.Estado=="DESHABILITADO")
                        {
                            MessageBox.Show("El terreno se encuentra Deshabilitado.");
                            txtidterreno.SelectAll();
                            txtidterreno.Focus();
                        }
                        else
                        {
                            txtmetros.Text = ter.MetrosCuadrados;
                            txtprecio.Text = ter.Precio;
                            txtestado.Text = ter.EstadoReserva;

                            btnadicionar.Focus();
                        }
                       
                    }
                    else
                    {
                        //dataGridView1.Rows.Clear();
                        MessageBox.Show("No existe el terreno.");
                        btnadicionar.Enabled = false;
                        txtidterreno.Focus();
                        txtidterreno.SelectAll();
                    }
                }
                else
                {
                    //dataGridView1.Rows.Clear();
                }
                    

            }
        }

        public bool ExisteDuplicado()
        {
            bool sw = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[0,i].Value.ToString() == txtidterreno.Text.Trim())
                {
                    sw = true;
                }
            }
            return sw;
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if (txtestado.Text!="RESERVADO")
            {
                if (!ExisteDuplicado())
                {
                    dataGridView1.Rows.Add(txtidterreno.Text, txtprecio.Text, txtmetros.Text, txtestado.Text, DateTime.Now,_usuarioactivo  );
                    txtidterreno.Focus();
                    txtidterreno.SelectAll();
                }
                else
                {
                    MessageBox.Show("El terreno ya se encuentra en la lista.");
                }
                
            }
            else
            {
                MessageBox.Show("El terreno que esta intentando agregar, se encuentra Reservado.");
                txtidterreno.Focus();
                txtidterreno.SelectAll();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnlimpiar.Text == "Anular")
                {
                    if (DialogResult.Yes == MessageBox.Show("Esta seguro de Anular el terreno?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                    {
                        det.AnularItemDetalle(dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString());
                        ter.CambiarLibre(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                        PasarDatosTerrenosCliente();
                    }

                }
                if (btnlimpiar.Text == "Limpiar")
                {
                    dataGridView1.Rows.Clear();
                }
            }
            catch (Exception)
            {

               // throw;
            }
           
            
        }

        public void GestionarUltimaReserva()
        {
            txtnroreserva.Text = res.UltimaReserva();
        }
        private void frmreserva_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[6].Visible = false;
            //dataGridView1.Columns[].Visible = false;
            GestionarUltimaReserva();
            //dataGridView1.ColumnCount = 5;
            //dataGridView1.RowCount = 0;
            //dataGridView1.Columns[0].HeaderText = "TERRENO";
            //dataGridView1.Columns[0].Width = 105;
            //dataGridView1.Columns[1].HeaderText = "PRECIO";
            //dataGridView1.Columns[1].Width = 70;
            //dataGridView1.Columns[2].HeaderText = "METROS2";
            //dataGridView1.Columns[2].Width = 60;
            //dataGridView1.Columns[3].HeaderText = "ESTADO";
            //dataGridView1.Columns[3].Width = 80;
            //dataGridView1.Columns[4].HeaderText = "FEC. RESERVA";
            //dataGridView1.Columns[4].Width = 120;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            _evento = "NUEVO";
            _Aceptar();
        }

        private void txtci_TextChanged(object sender, EventArgs e)
        {
            if (txtci.TextLength<3)
            {
                dataGridView1.Rows.Clear();
                txtnombres.Clear();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chvencido_CheckedChanged(object sender, EventArgs e)
        {
            PasarDatosTerrenosCliente();
        }

        private void chanulado_CheckedChanged(object sender, EventArgs e)
        {
            PasarDatosTerrenosCliente();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount>0)
                {
                    if (chimprimirmapa.Checked)
                    {
                        frmimprimirmapa frm = new frmimprimirmapa();
                        frm.CargarTerrenos(dataGridView1);
                        frm.DibujarLotes();
                        frm.ShowDialog();
                        //MessageBox.Show("Imagen Capturada");
                        creportemapa rep = new creportemapa();
                        rep.GenerarReporte(dataGridView1, "habilitado", "RESERVA DE TERRENO", _usuarioactivo, "ATRIBUTO", "PARAMETRO", "ESTADO");
                    }
                    else
                    {
                        creportereserva rep = new creportereserva();

                        rep.GenerarReporte(dataGridView1, "habilitado", "RESERVA DE TERRENO",_usuarioactivo, "ATRIBUTO", "PARAMETRO", "ESTADO",txtnombres.Text);
                    }
                   
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtidterreno_TextChanged(object sender, EventArgs e)
        {
            if (txtidterreno.TextLength<9)
            {
                txtmetros.Clear();
                txtprecio.Clear();
                txtestado.Clear();
                
            }
        }
    }
}
