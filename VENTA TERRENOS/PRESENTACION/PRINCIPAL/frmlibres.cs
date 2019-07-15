
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
    public partial class frmlibres : Form
    {
        public frmlibres()
        {
            InitializeComponent();
        }



        #region Atributos 
        GMarkerGoogle marker;
        GMapOverlay markeroverlay;
        DataTable dt;
        List<PointLatLng> puntoscopia = new List<PointLatLng>();
        GMapOverlay Poligono = new GMapOverlay("Poligono");
        GMapOverlay PoligonoTerreno = new GMapOverlay("PoligonoTerreno");
        List<PointLatLng> puntos;
        List<GMapPolygon> _gmapPolLista;

        int filaseleccionada = 0;
        cterreno cter = new cterreno();
        DataTable tbterreno = new DataTable();
        string ultimoreg = "";

        //double latinicial = 20.9688132813906;
        //double lnginicial = -89.6250915527344;

        double latitud = -17.8270123;
        double longitud = -63.1235875;
        int contador = 0;


        public void CargarUrbanizacion()
        {
           // cter.CargarUrbanizacion(cmburbanizacion);
        }
        public void CargarTipoTerreno()
        {
            //cter.CargarTipoTerreno(cmbtipoterreno);
        }

        #endregion

        #region Dibujar Terrenos
        public void CargarTerrenos()
        {

            cter.ListarTerrenos(ref tbterreno);
        }
        public DataTable CargarCoordenadas(string codlote)
        {
            ccoordenada obj = new ccoordenada();
            //obj.Listar(dataGridView2, codlote);
            DataSet ds = new DataSet();
            DataTable tabla = new DataTable();
            ds = obj.ListarTabla(codlote);
            tabla = ds.Tables[0];
            return tabla;
            //tabla.Rows[1]["LAT"].ToString();
            //tabla.Rows[1]["LNG"].ToString();
        }

        public Color ColorTerreno(string id)
        {
            cterrenotipo ctipo = new cterrenotipo();
            ctipo = ctipo.ObtenerRegistro(id);
            Color color = new Color();
            color = ColorTranslator.FromHtml(ctipo.Color);
            return color;
            //Color color = (Color)ConvertFromString("Red");
        }

        public void DibujarLotes()
        {
            LimpiarMapa();
            //_gmapPolLista = new List<GMapPolygon>();
            //variables par aalmacenar datos
            double lng, lat;
            //agarramos los datos de datagridview
            for (int i = 0; i < tbterreno.Rows.Count; i++)
            {
                try
                {
                    puntos = new List<PointLatLng>();

                    string lote = tbterreno.Rows[i]["IDTERRENO"].ToString();
                    string idtipo = tbterreno.Rows[i]["IDTIPO"].ToString();
                    //MessageBox.Show(ColorTerreno(idtipo).ToString());
                    DataTable tabla = new DataTable();
                    tabla = CargarCoordenadas(lote);
                    for (int filas = 0; filas < tabla.Rows.Count; filas++)
                    {

                        lat = Convert.ToDouble(tabla.Rows[filas]["LAT"].ToString());
                        lng = Convert.ToDouble(tabla.Rows[filas]["LNG"].ToString());
                        puntos.Add(new PointLatLng(lat, lng));


                    }
                    GMapPolygon poligonopuntos = new GMapPolygon(puntos, "Poligono");


                    if (tbterreno.Rows[i]["ESTADORESERVA"].ToString() == "LIBRE")
                    {
                        poligonopuntos.Fill = new SolidBrush(Color.FromArgb(200, ColorTerreno(idtipo)));
                        poligonopuntos.Stroke = new Pen(ColorTerreno(idtipo), 1);
                    }
                    else
                    {
                        poligonopuntos.Fill = new SolidBrush(Color.FromArgb(200, Color.Red));
                        poligonopuntos.Stroke = new Pen(Color.Red, 1);
                    }
                    //_gmapPolLista.Add(poligonopuntos);
                    Poligono.Polygons.Add(poligonopuntos);
                    
                }
                catch (Exception)
                {
                    return;
                }

            }
            gMapControl1.Overlays.Add(Poligono);
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;
        }

        public void LimpiarMapa()
        {

            gMapControl1.Overlays.Clear();
            Poligono.Clear();

        }

        public void Listar()
        {
            cterreno ter = new cterreno();
            if (cmbestado.Text=="TODOS")
            {
                ter.ListarLibres(dataGridView1, txtidterreno.Text);
            }
            else
            {
                ter.ListarLibresReservado(dataGridView1, txtidterreno.Text, cmbestado.Text);
               // MessageBox.Show(cmbestado.Text);
            }

            txtlibre.Text = ter.TerrenosLibres();
            txtreservado.Text = ter.TerrenosReservados();
            txttotal.Text = ter.TerrenosTotal();
            
        }
        #endregion


        private void frmlibres_Load(object sender, EventArgs e)
        {
            CargarTerrenos();
            DibujarLotes();

            CargarUrbanizacion();
            CargarTipoTerreno();
            cmbestado.SelectedIndex = 0;

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latitud, longitud);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 15;
            gMapControl1.AutoScroll = true;

            //markador
            //markeroverlay = new GMapOverlay("Marcador");
            //marker = new GMarkerGoogle(new PointLatLng(latitud, longitud), GMarkerGoogleType.green);
            //markeroverlay.Markers.Add(marker); //agregamos al mapa

           
            //ahora agregamos el mapa y el control al mapcontrol
            //gMapControl1.Overlays.Add(markeroverlay);
            //MessageBox.Show( gMapControl1.Overlays.Count.ToString());
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Listar();
        }


        public void LimpiarMapaTerreno()
        {
            gMapControl1.Overlays.RemoveAt(1);
            PoligonoTerreno.Clear();
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;
        }
        public void DibujarTerreno()
        {
            try
            {
                LimpiarMapaTerreno();
            }
            catch (Exception)
            {}
           
            double lng, lat;
            puntos = new List<PointLatLng>();
            DataTable tabla = new DataTable();
            tabla = CargarCoordenadas(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            for (int filas = 0; filas < tabla.Rows.Count; filas++)
            {

                lat = Convert.ToDouble(tabla.Rows[filas]["LAT"].ToString());
                lng = Convert.ToDouble(tabla.Rows[filas]["LNG"].ToString());
                puntos.Add(new PointLatLng(lat, lng));


            }
            GMapPolygon poligonopuntos = new GMapPolygon(puntos, "Poligono");

            //poligonopuntos.Fill = new SolidBrush(Color.FromArgb(200, Color.Black));
            poligonopuntos.Stroke = new Pen(Color.Black, 3);

            PoligonoTerreno.Polygons.Add(poligonopuntos);
            gMapControl1.Overlays.Add(PoligonoTerreno);
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DibujarTerreno();
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() =="RESERVADO")
            {
                MessageBox.Show("El terreno " + dataGridView1.CurrentRow.Cells[0].Value.ToString() +" esta Reservado.");
            }
        }

      
    }
}
