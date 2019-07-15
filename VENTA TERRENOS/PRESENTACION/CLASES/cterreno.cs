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
    public class cterreno
    {
        #region Atributos
        private string _idterreno;
        private int _idtipo;
        private int _idurbanizacion;
        private string _metroscuadrados;
        private string _estadoreserva;

        private string _precio;

        private string _estado;

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }


        #endregion


        #region Propiedades
        public string Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public int IdUrbanizacion
        {
            get { return _idurbanizacion; }
            set { _idurbanizacion = value; }
        }

        public string MetrosCuadrados
        {
            get { return _metroscuadrados; }
            set { _metroscuadrados = value; }
        }


        public int Idtipo
        {
            get { return _idtipo; }
            set { _idtipo = value; }
        }
                public string Idterreno
        {
            get { return _idterreno; }
            set { _idterreno = value; }
        }
        public string EstadoReserva
        {
            get { return _estadoreserva; }
            set { _estadoreserva = value; }
        }
        #endregion

        #region Metodos
        private string consulta = "";
        conexion cnx = new conexion();

        public bool Registrar()
        {
            try
            {
                consulta = "INSERT INTO TERRENO VALUES('" + this.Idterreno + "','" + this.Idtipo + "','" + this.IdUrbanizacion + "','" + this.MetrosCuadrados + "','" +this.Precio +"','" + this.EstadoReserva + "','"+this.Estado+ "')";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Eliminar(string idterreno)
        {
            try
            {
                consulta = "DELETE FROM TERRENO WHERE IDTERRENO='" + idterreno + "'";
                cnx.Insertar(consulta);
                consulta = "DELETE FROM COORDENADA WHERE CODLOTE='" + idterreno + "'";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Habilitar(string idterreno)
        {
            try
            {
                consulta = "UPDATE TERRENO SET ESTADO ='HABILITADO' WHERE IDTERRENO='" + idterreno + "'";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DesHabilitar(string idterreno)
        {
            try
            {
                consulta = "UPDATE TERRENO SET ESTADO ='DESHABILITADO' WHERE IDTERRENO='" + idterreno + "'";
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
                //SELECT T.IDTERRENO, U.URBANIZACION, T.METROS, T.PRECIO, T.ESTADORESERVA FROM dbo.TERRENO AS T INNER JOIN dbo.URBANIZACION AS U ON T.IDURBANIZACION = U.ID
                consulta = "SELECT T.IDTERRENO, U.URBANIZACION, T.METROS, T.PRECIO, T.ESTADORESERVA, T.ESTADO FROM dbo.TERRENO AS T INNER JOIN dbo.URBANIZACION AS U ON T.IDURBANIZACION = U.ID WHERE T.IDTERRENO like '" + buscar + "%' OR U.URBANIZACION LIKE '" + buscar + "%'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "CLIENTE");
                //int cant = ds.Tables[0].Rows.Count;
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

        public void ListarEstado(DataGridView dgv, string buscar, string estado)
        {
            try
            {
                //consulta = "SELECT * FROM COORDENADA WHERE CODLOTE='" + buscar +"'";
                //SELECT T.IDTERRENO, U.URBANIZACION, T.METROS, T.PRECIO, T.ESTADORESERVA FROM dbo.TERRENO AS T INNER JOIN dbo.URBANIZACION AS U ON T.IDURBANIZACION = U.ID
                consulta = "SELECT T.IDTERRENO, U.URBANIZACION, T.METROS, T.PRECIO, T.ESTADORESERVA, T.ESTADO FROM dbo.TERRENO AS T INNER JOIN dbo.URBANIZACION AS U ON T.IDURBANIZACION = U.ID WHERE T.IDTERRENO like '" + buscar + "%' and T.ESTADO='" + estado + "'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "CLIENTE");
                //int cant = ds.Tables[0].Rows.Count;
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
        public bool Duplicado( string idterreno)
        {
            try
            {
                consulta = "SELECT * FROM TERRENO WHERE IDTERRENO = '" + idterreno + "'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "TERRENO");
                
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

        public void ListarLibres(DataGridView dgv, string buscar)
        {
            try
            {
                //consulta = "SELECT * FROM COORDENADA WHERE CODLOTE='" + buscar +"'";
                //SELECT T.IDTERRENO, U.URBANIZACION, T.METROS, T.PRECIO, T.ESTADORESERVA FROM dbo.TERRENO AS T INNER JOIN dbo.URBANIZACION AS U ON T.IDURBANIZACION = U.ID
                consulta = "SELECT T.IDTERRENO, T.METROS, T.PRECIO, T.ESTADORESERVA FROM dbo.TERRENO AS T INNER JOIN dbo.URBANIZACION AS U ON T.IDURBANIZACION = U.ID WHERE T.IDTERRENO like '" + buscar + "%' AND T.ESTADO <> 'DESHABILITADO'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "CLIENTE");
                //int cant = ds.Tables[0].Rows.Count;
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

        public void ListarLibresReservado(DataGridView dgv, string buscar, string estado)
        {
            try
            {
                //consulta = "SELECT * FROM COORDENADA WHERE CODLOTE='" + buscar +"'";
                //SELECT T.IDTERRENO, U.URBANIZACION, T.METROS, T.PRECIO, T.ESTADORESERVA FROM dbo.TERRENO AS T INNER JOIN dbo.URBANIZACION AS U ON T.IDURBANIZACION = U.ID
                consulta = "SELECT T.IDTERRENO, T.METROS, T.PRECIO, T.ESTADORESERVA FROM dbo.TERRENO AS T INNER JOIN dbo.URBANIZACION AS U ON T.IDURBANIZACION = U.ID WHERE T.IDTERRENO like '" + buscar + "%' and  T.ESTADORESERVA='" + estado + "' AND T.ESTADO <> 'DESHABILITADO'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "CLIENTE");
                //int cant = ds.Tables[0].Rows.Count;
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

        public bool ExisteTerreno(string idterreno)
        {
            try
            {
                consulta = "SELECT * FROM TERRENO WHERE IDTERRENO='" + idterreno + "'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "TERRENO");
                //int cant = ds.Tables[0].Rows.Count;
                if (ds != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public cterreno ObtenerRegistro(string idterr)
        {
            try
            {
                consulta = "SELECT * FROM TERRENO WHERE IDTERRENO='" + idterr + "'";
                DataSet ds = new DataSet();
                cterreno obj = new cterreno();
                ds = cnx.Listar(consulta, "TERRENO");
               // int cant = ds.Tables[0].Rows.Count;
                DataTable dt = ds.Tables[0];
                DataRow row = dt.Rows[0];
                obj.EstadoReserva = row["ESTADORESERVA"].ToString();
                obj.MetrosCuadrados = row["METROS"].ToString();
                obj.Precio = row["PRECIO"].ToString();
                obj.Estado = row["ESTADO"].ToString();
                return obj;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public string TerrenosTotal()
        {
            try
            {
                consulta = "SELECT COUNT(*) TOTAL FROM TERRENO WHERE ESTADO <> 'DESHABILITADO'";
                DataSet ds = new DataSet();
                string obj = "";
                ds = cnx.Listar(consulta, "TERRENO");
                // int cant = ds.Tables[0].Rows.Count;
                DataTable dt = ds.Tables[0];
                DataRow row = dt.Rows[0];
                obj = row["TOTAL"].ToString();
                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string TerrenosLibres()
        {
            try
            {
                consulta = "SELECT COUNT(*) LIBRES FROM TERRENO WHERE ESTADORESERVA='LIBRE' AND ESTADO ='HABILITADO'";
                DataSet ds = new DataSet();
                string obj = "";
                ds = cnx.Listar(consulta, "TERRENO");
                // int cant = ds.Tables[0].Rows.Count;
                DataTable dt = ds.Tables[0];
                DataRow row = dt.Rows[0];
                obj = row["LIBRES"].ToString();
                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string TerrenosReservados()
        {
            try
            {
                consulta = "SELECT COUNT(*) RESERVADOS FROM TERRENO WHERE ESTADORESERVA='RESERVADO' AND ESTADO ='HABILITADO'";
                DataSet ds = new DataSet();
                string obj = "";
                ds = cnx.Listar(consulta, "TERRENO");
                // int cant = ds.Tables[0].Rows.Count;
                DataTable dt = ds.Tables[0];
                DataRow row = dt.Rows[0];
                obj = row["RESERVADOS"].ToString();
                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ListarTerrenos(ref DataTable tabla)
        {
            try
            {
                consulta = "SELECT IDTERRENO,ESTADORESERVA,IDTIPO FROM TERRENO";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "TERRENO");
                int cant = ds.Tables[0].Rows.Count;
                if (ds != null)
                {
                    tabla = ds.Tables[0];
                }
                else
                {
                    for (int i = 0; i < tabla.Rows.Count - 1; i++)
                    {
                        tabla.Rows.RemoveAt(i);
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        public void CargarUrbanizacion(ComboBox cmb)
        {
            try
            {
                consulta = "SELECT * FROM URBANIZACION";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "URBANIZACION");
                int cant = ds.Tables[0].Rows.Count;
                if (ds != null)
                {
                    cmb.DataSource = ds.Tables[0];
                    cmb.DisplayMember = "URBANIZACION";
                    cmb.ValueMember = "ID";
                }
                
            }
            catch (Exception)
            {

                //throw;
            }
        }

        public void CargarTipoTerreno(ComboBox cmb)
        {
            try
            {
                consulta = "SELECT * FROM TERRENOTIPO";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "TERRENOTIPO");
                //int cant = ds.Tables[0].Rows.Count;
                if (ds != null)
                {
                    cmb.DataSource = ds.Tables[0];
                    cmb.DisplayMember = "NOMBRE";
                    cmb.ValueMember = "IDTIPO";
                }

            }
            catch (Exception)
            {

                //throw;
            }
        }

        public bool CambiarReservado(string idterreno)
        {
            try
            {
                consulta = "UPDATE TERRENO SET ESTADORESERVA='" + "RESERVADO" + "' WHERE IDTERRENO='" + idterreno + "'";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CambiarLibre(string idterreno)
        {
            try
            {
                consulta = "UPDATE TERRENO SET ESTADORESERVA='" + "LIBRE" + "' WHERE IDTERRENO='" + idterreno + "'";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        #endregion

    }
}
