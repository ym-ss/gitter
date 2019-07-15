using DATOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASES
{
    public class ccoordenada
    {
        private string _id;
        private string _codlote;
        private string _latitud;
        private string _longitud;

        private string consulta = "";
        conexion cnx = new conexion();
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string CodLote
        {
            get { return _codlote; }
            set { _codlote = value; }
        }



        public string Latitud
        {
            get { return _latitud; }
            set { _latitud = value; }
        }



        public string Longitud
        {
            get { return _longitud; }
            set { _longitud = value; }
        }

        public bool Registrar()
        {
            try
            {

                consulta = "INSERT INTO COORDENADA VALUES('" + this.CodLote + "','" + this.Latitud + "','" + this.Longitud + "')";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public void Listar(DataGridView dgv, string buscar)
        {
            try
            {
                //consulta = "SELECT * FROM COORDENADA WHERE CODLOTE='" + buscar +"'";
                consulta = "SELECT * FROM COORDENADA";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "COORDENADA");
                int cant = ds.Tables[0].Rows.Count;
                if (ds != null)
                {
                    dgv.DataSource = ds.Tables[0];
                }
                else
                {
                    for (int i = 0; i < dgv.Rows.Count - 1; i++)
                    {
                        dgv.Rows.RemoveAt(i);
                    }
                }
                dgv.ClearSelection();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet ListarTabla(string buscar)
        {
            try
            {
                consulta = "SELECT LAT,LNG FROM COORDENADA WHERE CODLOTE='" + buscar + "'";
                //consulta = "SELECT * FROM COORDENADA";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "COORDENADA");
                int cant = ds.Tables[0].Rows.Count;
                return ds;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
