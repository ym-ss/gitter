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
    public class cterrenotipo
    {
        #region Atributos
        private int _idtipo;
        private string _nombre;
        private string _color;
        private string _estado;

        #endregion

        #region Propiedades
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }


        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        public int Idtipo
        {
            get { return _idtipo; }
            set { _idtipo = value; }
        }

        #endregion


        #region Metodos

        private string consulta = "";
        conexion cnx = new conexion();
        public bool Registrar()
        {
            try
            {
                consulta = "INSERT INTO TERRENOTIPO VALUES('" + this.Nombre + "','" + this.Color + "','" + this.Estado + "')";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Editar()
        {
            try
            {
                consulta = "UPDATE TERRENOTIPO SET NOMBRE='" + this.Nombre + "', COLOR='" + this.Color + "' WHERE IDTIPO='" + this.Idtipo + "'";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Habilitar()
        {
            try
            {
                consulta = "UPDATE TERRENOTIPO SET ESTADO ='HABILITADO' WHERE IDTIPO='" + this.Idtipo + "'";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DesHabilitar()
        {
            try
            {
                consulta = "UPDATE TERRENOTIPO SET ESTADO ='DESHABILITADO' WHERE IDTIPO='" + this.Idtipo + "'";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public cterrenotipo ObtenerRegistro(string _id)
        {
            try
            {
                consulta = "SELECT * FROM TERRENOTIPO WHERE IDTIPO='" + _id + "'";
                DataSet ds = new DataSet();
                cterrenotipo obj = new cterrenotipo();
                ds = cnx.Listar(consulta, "TERRENOTIPO");
                int cant = ds.Tables[0].Rows.Count;
                DataTable dt = ds.Tables[0];
                DataRow row = dt.Rows[0];
                
                obj.Nombre = row["NOMBRE"].ToString();
                obj.Color = row["COLOR"].ToString();
                obj.Idtipo =int.Parse( row["IDTIPO"].ToString());
                obj.Estado= row["ESTADO"].ToString();

                return obj;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Listar(DataGridView dgv, string buscar)
        {
            try
            {
                //consulta = "SELECT * FROM COORDENADA WHERE CODLOTE='" + buscar +"'";
                consulta = "SELECT * FROM TERRENOTIPO WHERE NOMBRE like '" + buscar + "%' OR COLOR LIKE '" + buscar + "%'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "TERRENOTIPO");
                
                if (ds != null)
                {
                    dgv.DataSource = ds.Tables[0];
                }
                else
                {
                    for (int i = 0; i <= dgv.Rows.Count; i++)
                    {
                        dgv.Rows.RemoveAt(0);
                    }
                }
                dgv.ClearSelection();
            }
            catch (Exception)
            {

                //throw;
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

        public bool Duplicado(string tipoterreno)
        {
            try
            {
                consulta = "SELECT * FROM TERRENOTIPO WHERE NOMBRE = '" + tipoterreno + "'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "TERRENOTIPO");

                if (ds != null)
                {
                    return true;
                }

            }
            catch (Exception)
            {

                //throw;
            }
            return false;
        }

        #endregion
    }
}
