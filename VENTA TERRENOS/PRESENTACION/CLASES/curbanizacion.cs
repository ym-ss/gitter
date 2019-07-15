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
    public class curbanizacion
    {
        #region Atributos
        private int _idurbanizacion;
        private string _urbanizacion;
        private string _direccion;
        private string _superficia;
        private int _cantterrenos;
        private string _estado;
        #endregion

        #region Propiedades
        public string Urbanizacion
        {
            get { return _urbanizacion; }
            set { _urbanizacion = value; }
        }
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }


        public int CantTerrenos
        {
            get { return _cantterrenos; }
            set { _cantterrenos = value; }
        }


        public string Superficie
        {
            get { return _superficia; }
            set { _superficia = value; }
        }


        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }


        public int Idurbanizacion
        {
            get { return _idurbanizacion; }
            set { _idurbanizacion = value; }
        }


        #endregion

        #region Metodos

        private string consulta = "";
        conexion cnx = new conexion();
        public bool Registrar()
        {
            try
            {
                consulta = "INSERT INTO URBANIZACION VALUES('" + this.Urbanizacion + "','" + this.Superficie + "','" + this.Direccion + "','" + this.CantTerrenos + "','" + this.Estado + "')";
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
                consulta = "UPDATE URBANIZACION SET URBANIZACION='" + this.Urbanizacion + "', SUPERFICIE='" + this.Superficie + "', DIRECCION='" + this.Direccion + "', CANTIDAD='" + this.CantTerrenos + "' WHERE ID='" + this.Idurbanizacion + "'";
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
                consulta = "UPDATE URBANIZACION SET ESTADO ='HABILITADO' WHERE ID='" + this.Idurbanizacion + "'";
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
                consulta = "UPDATE URBANIZACION SET ESTADO ='DESHABILITADO' WHERE ID='" + this.Idurbanizacion + "'";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public curbanizacion ObtenerRegistro(string ci)
        {
            try
            {
                consulta = "SELECT * FROM URBANIZACION WHERE ID='" + ci + "'";
                DataSet ds = new DataSet();
                curbanizacion obj = new curbanizacion();
                ds = cnx.Listar(consulta, "URBANIZACION");
                int cant = ds.Tables[0].Rows.Count;
                DataTable dt = ds.Tables[0];
                DataRow row = dt.Rows[0];
                obj.Idurbanizacion = int.Parse(row["ID"].ToString());
                obj.CantTerrenos =int.Parse( row["CANTIDAD"].ToString());
                obj.Direccion = row["DIRECCION"].ToString();     
                obj.Estado = row["ESTADO"].ToString();
                obj.Superficie = row["SUPERFICIE"].ToString();
                obj.Urbanizacion = row["URBANIZACION"].ToString();
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
                consulta = "SELECT * FROM URBANIZACION WHERE URBANIZACION like '" + buscar + "%' OR DIRECCION LIKE '" + buscar + "%'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "URBANIZACION");
                //int cant = ds.Tables[0].Rows.Count;
                if (ds != null)
                {
                    dgv.DataSource = ds.Tables[0];
                }
                else
                {
                    for (int i = 0; i <= dgv.Rows.Count ; i++)
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

       

        #endregion
    }
}
