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
    public class creserva
    {

        #region Atributos
        private int _idreserva;
        private string _ci;
        private string _fechareserva;
        private string _estado;
        private string _estadoreserva;
        private string _total;
        private int _idusuario;

        #endregion

        #region Propiedades
        public string Total
        {
            get { return _total; }
            set { _total = value; }
        }
        public string EstadoReserva
        {
            get { return _estadoreserva; }
            set { _estadoreserva = value; }
        }
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        
        public string Fechareserva
        {
            get { return _fechareserva; }
            set { _fechareserva = value; }
        }
        public string Ci
        {
            get { return _ci; }
            set { _ci = value; }
        }
        public int Idreserva
        {
            get { return _idreserva; }
            set { _idreserva = value; }
        }
        public int IdUsuario
        {
            get { return _idusuario; }
            set { _idusuario = value; }
        }

        #endregion

        #region Metodos

        private string consulta = "";
        conexion cnx = new conexion();
        public bool Registrar()
        {
            try
            {
                consulta = "INSERT INTO RESERVA VALUES('" + this.Ci + "','" + this.Fechareserva  + "','" + this.IdUsuario + "','" + this.EstadoReserva + "','" + this.Estado +"','" +this.Total+ "')";
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
                consulta = "UPDATE RESERVA SET CI='" + this.Ci +"', FECHARESERVA='" + this.Fechareserva + "', ESTADO='" + this.Estado + "', ESTADORESERVA='" + this.EstadoReserva + "', TOTAL='" + this.Total + "' WHERE IDRESERVA=" + this.Idreserva + "";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Eliminar()
        {
            try
            {
                consulta = "UPDATE RESERVA SET ESTADO ='"+ this.Estado + "' WHERE IDRESERVA='" + this.Idreserva + "'";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataSet ObtenerRegistro(string idreserva)
        {
            try
            {
                consulta = "SELECT * FROM RESERVA WHERE IDRESERVA='" + idreserva + "'";
                //consulta = "SELECT * FROM COORDENADA";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "RESERVA");
                int cant = ds.Tables[0].Rows.Count;
                return ds;

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
                //SELECT R.IDRESERVA AS ID, R.CI, C.NOMBRES, C.APELLIDOS, R.FECHARESERVA, R.ESTADORESERVA AS ESTADO, R.TOTAL, U.USUARIO FROM dbo.RESERVA AS R INNER JOIN dbo.USUARIO AS U ON R.IDUSUARIO = U.IDUSUARIO INNER JOIN dbo.CLIENTE AS C ON R.CI = C.CI
                consulta = "SELECT R.IDRESERVA AS ID, R.CI, C.NOMBRES, C.APELLIDOS, R.FECHARESERVA, R.ESTADORESERVA AS ESTADO, U.USUARIO FROM dbo.RESERVA AS R INNER JOIN dbo.USUARIO AS U ON R.IDUSUARIO = U.IDUSUARIO INNER JOIN dbo.CLIENTE AS C ON R.CI = C.CI WHERE R.CI LIKE '" + buscar + "%' OR C.NOMBRES LIKE '"+buscar+"%' OR C.APELLIDOS LIKE '" + buscar + "%' OR R.FECHARESERVA LIKE '" + buscar + "%' ORDER BY R.IDRESERVA DESC";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "COORDENADA");
                
                if (ds != null)
                {
                    dgv.DataSource = ds.Tables[0];
                }
                else
                {
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        dgv.Rows.RemoveAt(0);
                    }
                }
                dgv.ClearSelection();
            }
            catch (Exception)
            {

                
            }
        }

        public void ListarXfecha(DataGridView dgv, string desde,string hasta, string buscar)
        {
            try
            {
                //consulta = "SELECT * FROM COORDENADA WHERE CODLOTE='" + buscar +"'";
                //SELECT R.IDRESERVA AS ID, R.CI, C.NOMBRES, C.APELLIDOS, R.FECHARESERVA, R.ESTADORESERVA AS ESTADO, R.TOTAL, U.USUARIO FROM dbo.RESERVA AS R INNER JOIN dbo.USUARIO AS U ON R.IDUSUARIO = U.IDUSUARIO INNER JOIN dbo.CLIENTE AS C ON R.CI = C.CI -- fecha BETWEEN '20121201 00:00' AND '20121202 23:59:59.999'
                consulta = "SELECT R.IDRESERVA AS ID, R.CI, C.NOMBRES, C.APELLIDOS, R.FECHARESERVA, R.ESTADORESERVA AS ESTADO, U.USUARIO FROM dbo.RESERVA AS R INNER JOIN dbo.USUARIO AS U ON R.IDUSUARIO = U.IDUSUARIO INNER JOIN dbo.CLIENTE AS C ON R.CI = C.CI WHERE R.FECHARESERVA BETWEEN '" + desde +"' and '" + hasta + "' ORDER BY R.IDRESERVA DESC";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "COORDENADA");

                if (ds != null)
                {
                    dgv.DataSource = ds.Tables[0];
                }
                else
                {
                    int cant = dgv.Rows.Count ;
                    for (int i = 0; i < cant; i++)
                    {
                        dgv.Rows.RemoveAt(0);
                    }
                }
                dgv.ClearSelection();
            }
            catch (Exception)
            {


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

        public string UltimaReserva()
        {
            int ultimo = 1;
            try
            {
                consulta = "SELECT MAX(IDRESERVA) AS ID FROM RESERVA";
                //consulta = "SELECT * FROM COORDENADA";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "RESERVA");
                
                //int cant = ds.Tables[0].Rows.Count;
                if (ds != null)
                {
                    

                    DataTable dt = ds.Tables[0];
                    DataRow row = dt.Rows[0];
                    ultimo =int.Parse( row["ID"].ToString())+1;
                    
                }
               

                return ultimo.ToString();
            }
            catch (Exception)
            {

                return ultimo.ToString();
            }
        }


        public bool AnularReserva(string idreserva)
        {
            try
            {
                consulta = "UPDATE RESERVA SET ESTADORESERVA = 'ANULADO' WHERE IDRESERVA='" + idreserva + "'";
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
