using CLASES;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRINCIPAL
{
    public partial class frmimprimirmapa : Form
    {
        public frmimprimirmapa()
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
         DataTable tbterreno = new DataTable(); //aqui pasamos los terrenos del comprador
        string ultimoreg = "";

        //double latinicial = 20.9688132813906;
        //double lnginicial = -89.6250915527344;

        double latitud = -17.8270123;
        double longitud = -63.1235875;
        int contador = 0;


        #endregion


        #region Dibujar Terrenos
        public void CargarTerrenos(DataGridView dg)
        {
            DataTable dt = new DataTable();
            tbterreno.Columns.Add("IDTERRENO", typeof(string));
            tbterreno.Columns.Add("ESTADORESERVA", typeof(string));

            foreach (DataGridViewRow dgvR in dg.Rows)
            {
                string cadena1 = dgvR.Cells[0].Value.ToString();
                string cadena2 = dgvR.Cells[3].Value.ToString();
                tbterreno.Rows.Add(dgvR.Cells[0].Value, dgvR.Cells[3].Value);
            }

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
                    DataTable tabla = new DataTable();
                    tabla = CargarCoordenadas(lote);
                    for (int filas = 0; filas < tabla.Rows.Count; filas++)
                    {

                        lat = Convert.ToDouble(tabla.Rows[filas]["LAT"].ToString());
                        lng = Convert.ToDouble(tabla.Rows[filas]["LNG"].ToString());
                        puntos.Add(new PointLatLng(lat, lng));


                    }
                    GMapPolygon poligonopuntos = new GMapPolygon(puntos, "Poligono");


                    //if (tbterreno.Rows[i]["ESTADORESERVA"].ToString() == "LIBRE")
                    {
                        poligonopuntos.Fill = new SolidBrush(Color.FromArgb(50, Color.Green));
                        poligonopuntos.Stroke = new Pen(Color.Green, 1);
                    }
                    //else
                    {
                     //   poligonopuntos.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
                       // poligonopuntos.Stroke = new Pen(Color.Red, 1);
                    }
                    //_gmapPolLista.Add(poligonopuntos);
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
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(gMapControl1.Width);
            int height = Convert.ToInt32(gMapControl1.Height);
            Bitmap bmp = new Bitmap(width, height);
            gMapControl1.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
            // Application.StartupPath + @"\prueba.pdf";
            bmp.Save(Application.StartupPath + @"\imagen.jpg", ImageFormat.Bmp);
            Close();
        }

        private void frmimprimirmapa_Load(object sender, EventArgs e)
        {
            
            //DibujarLotes();
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
    }
}
