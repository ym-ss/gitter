
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using CLASES;
using System.IO;

using GMap.NET;
using GMap.NET.MapProviders;
//using NetworkObjects;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Imaging;

namespace PRINCIPAL
{
    public partial class frmterreno : Form
    {
        public frmterreno()
        {
            InitializeComponent();
        }



        #region Atributos 
        GMarkerGoogle marker;
        GMapOverlay markeroverlay;
        DataTable dt;
        List<PointLatLng> puntoscopia = new List<PointLatLng>();
        GMapOverlay Poligono = new GMapOverlay("Poligono");
        List<PointLatLng> puntos;
        List<GMapPolygon> _gmapPolLista;

        int filaseleccionada = 0;
        cterreno cter = new cterreno();
        DataTable tbterreno = new DataTable();
        string ultimoreg = "";

        double latitud = -17.8270123;
        double longitud = -63.1235875;
        int contador = 0;
        

        public void CargarUrbanizacion()
        {
            cter.CargarUrbanizacion(cmburbanizacion);
        }
        public void CargarTipoTerreno()
        {
            cter.CargarTipoTerreno(cmbtipoterreno);
        }

        #endregion

        #region Dibujar Terrenos
        public void CargarTerrenos()
        {
            
            cter.ListarTerrenos(ref tbterreno);
        }

        //proceso que devuelve las coordenadas de un terreno
        public DataTable CargarCoordenadas(string codlote)
        {
            ccoordenada obj = new ccoordenada();
            DataSet ds = new DataSet();
            DataTable tabla = new DataTable();
            ds = obj.ListarTabla(codlote);
            tabla = ds.Tables[0];
            return tabla;
        }

        //proceso que devuelve el color del tipo de terreno
        public Color ColorTerreno(string id )
        {
            cterrenotipo ctipo = new cterrenotipo();
            ctipo= ctipo.ObtenerRegistro(id);
            Color color = new Color();
            color =ColorTranslator.FromHtml(ctipo.Color);
            return color;
        }

        //proceso para dibujar los terrenos
        public void DibujarLotes()
        {
            LimpiarMapa();
            double lng, lat;
            //recorremos todos los terrenos 
            for (int i = 0; i < tbterreno.Rows.Count; i++)
            {
                try
                {
                    puntos = new List<PointLatLng>();

                    string lote = tbterreno.Rows[i]["IDTERRENO"].ToString();
                    string idtipo = tbterreno.Rows[i]["IDTIPO"].ToString();
                    DataTable tabla = new DataTable();
                    tabla = CargarCoordenadas(lote);
                    for (int filas = 0; filas < tabla.Rows.Count; filas++)
                    {
                        //capturamos la latitud y longitud
                        lat = Convert.ToDouble(tabla.Rows[filas]["LAT"].ToString());
                        lng = Convert.ToDouble(tabla.Rows[filas]["LNG"].ToString());
                        puntos.Add(new PointLatLng(lat, lng));


                    }
                    GMapPolygon poligonopuntos = new GMapPolygon(puntos, "Poligono");


                    if (tbterreno.Rows[i]["ESTADORESERVA"].ToString() == "LIBRE")
                    {
                        // se dubija el poligono que representa a un terreno.
                        poligonopuntos.Fill = new SolidBrush(Color.FromArgb(50, ColorTerreno(idtipo)));
                        poligonopuntos.Stroke = new Pen(ColorTerreno(idtipo), 1);
                    }
                    else
                    {
                        poligonopuntos.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
                        poligonopuntos.Stroke = new Pen(Color.Red, 1);
                    }
                    //agregamos los poligonos al mapa
                    Poligono.Polygons.Add(poligonopuntos);
                    gMapControl1.Overlays.Add(Poligono);
                }
                catch (Exception)
                {
                    return;
                }

            }
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;
        }

        public void LimpiarMapa()
        {

            gMapControl1.Overlays.Clear();
            Poligono.Clear();

        }
        #endregion

        public void CargarLabel()
        {
            
        }
        private void frmterreno_Load(object sender, EventArgs e)
        {
         
            try
            {
                CargarTerrenos();
                DibujarLotes();
            }
            catch (Exception)
            {

                
            }
            


            CargarUrbanizacion();
            CargarTipoTerreno();
            cmbtipoterreno.SelectedIndex = 0;
            cmburbanizacion.SelectedIndex = 0;
           
            //creamos las cabeceras del datagridview
            dataGridView1.ColumnCount = 3;
            dataGridView1.RowCount = 0;
            dataGridView1.Columns[0].HeaderText = "DESCRIPCION COORDENADAS";
            dataGridView1.Columns[0].Width = 230;
            dataGridView1.Columns[1].HeaderText = "LAT";
            dataGridView1.Columns[1].Width = 270;
            dataGridView1.Columns[2].HeaderText = "LNG";
            dataGridView1.Columns[2].Width = 70;

            // desactivar las columnas de lat y long
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latitud, longitud);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 15;
            gMapControl1.AutoScroll = true;

            //markador
            markeroverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(latitud, longitud), GMarkerGoogleType.green);
            markeroverlay.Markers.Add(marker); //agregamos al mapa

            //agregamos un tooltip a los marcadores
            //marker.ToolTipMode = MarkerTooltipMode.Always;
            //marker.ToolTipText = string.Format("Ubicacion: \n Latitud: {0} \n Longitud:{1}", latinicial, lnginicial);

            //ahora agregamos el mapa y el control al mapcontrol
            gMapControl1.Overlays.Add(markeroverlay);
        }

        //proceso para limpiar las cajas de texto
        public void Limpiar()
        {
            txtidterreno.Clear();
            txtmetros.Clear();
            dataGridView1.Rows.Clear();
            txtidterreno.Focus();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            cterreno ter = new cterreno();
            if (!ter.Duplicado(txtidterreno.Text))
            {
                if (dataGridView1.RowCount > 3)
                {
                    //guardar terreno
                    ter.Idterreno = txtidterreno.Text;
                    ter.IdUrbanizacion = int.Parse((cmburbanizacion.SelectedValue).ToString());
                    ter.Idtipo = int.Parse((cmbtipoterreno.SelectedValue).ToString());
                    ter.MetrosCuadrados = txtmetros.Text;
                    ter.EstadoReserva = "LIBRE";
                    ter.Precio = txtprecio.Text;
                    ter.Estado = "HABILITADO";
                    ter.Registrar();

                    // guardar coordenadas
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        ccoordenada cor = new ccoordenada();
                        cor.CodLote = txtidterreno.Text;
                        cor.Latitud = dataGridView1[1, i].Value.ToString();
                        cor.Longitud = dataGridView1[2, i].Value.ToString();
                        cor.Registrar();
                    }

                    MessageBox.Show("Terreno registrado correctamente");
                    Limpiar();
                    ultimoreg = txtidterreno.Text;
                    CargarTerrenos();
                    DibujarLotes();
                }
                else
                {
                    MessageBox.Show("Error al guardar. \n Inserte las coordenadas del terreno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                MessageBox.Show("Error al intentar Guardar, ya existe el Terreno.","Atención",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
         }

        private void btncancelar_Click(object sender, EventArgs e)
        {
           
             Close();
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // se obtiene los datos que el usuario hace doble click
            contador++;
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            dataGridView1.Rows.Add("Coordenada " + contador.ToString() + " capturado correctamente.", lat, lng);

            //creamos el marcador par amover el marcador al lugar indicado
            marker.Position = new PointLatLng(lat, lng);
            
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            contador = 0;
        }


        private void btnadicionar_Click(object sender, EventArgs e)
        {

            contador++;
            dataGridView1.Rows.Add("Coordenada " + contador.ToString() + " capturado correctamente.", latitud, longitud);

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount>0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
           
        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
             latitud = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
             longitud = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
            marker.Position = new PointLatLng(latitud, longitud);
        }

        private void btndeshacer_Click(object sender, EventArgs e)
        {
            cter.Eliminar(ultimoreg);
            CargarTerrenos();
            DibujarLotes();
        }

        private void btncargarterrenos_Click(object sender, EventArgs e)
        {
            CargarTerrenos();
            DibujarLotes();
        }
    }
}
