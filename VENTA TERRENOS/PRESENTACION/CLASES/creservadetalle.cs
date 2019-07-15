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
    public class creservadetalle
    {
        private int _iddetalle;
        private string _ci;
        private string _idterreno;
        private string _precio;
        private string _fechareserva;
        private string _estadoreserva;
        private string _estado;
        private int _idusuario;
        private int _idreserva;

        public int Idreserva
        {
            get { return _idreserva; }
            set { _idreserva = value; }
        }


        public int Idusuario
        {
            get { return _idusuario; }
            set { _idusuario = value; }
        }


        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }


        public string EstadoReserva
        {
            get { return _estadoreserva; }
            set { _estadoreserva = value; }
        }


        public string FechaReserva
        {
            get { return _fechareserva; }
            set { _fechareserva = value; }
        }


        public string Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }


        public string Idterreno
        {
            get { return _idterreno; }
            set { _idterreno = value; }
        }


        public string Ci
        {
            get { return _ci; }
            set { _ci = value; }
        }


        public int Iddetalle
        {
            get { return _iddetalle; }
            set { _iddetalle = value; }
        }

        #region Metodos
        private string consulta = "";
        conexion cnx = new conexion();

        public bool Registrar()
        {
            try
            {
                consulta = "INSERT INTO RESERVADETALLE VALUES('" + this.Ci+ "','" + this.Idusuario + "','" + this.Idterreno + "','" + this.Precio + "','" + this.FechaReserva + "','" + this.EstadoReserva +"','"+this.Idreserva +"')";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AnularItemDetalle(string iddetalle)
        {
            try
            {
                consulta = "UPDATE RESERVADETALLE SET ESTADORESERVA = 'ANULADO' WHERE ID='" + iddetalle + "'";
                cnx.Insertar(consulta);
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AnularDetalle_De_Reserva(string idreserva)
        {
            try
            {
                consulta = "SELECT IDTERRENO FROM RESERVADETALLE WHERE IDRESERVA='" + idreserva + "'";
                cnx.Insertar(consulta);
                DataSet ds = new DataSet();
                cterreno obj = new cterreno();
                ds = cnx.Listar(consulta, "TERRENO");
                DataTable dt = ds.Tables[0];
                //DataRow row = dt.Rows[0];
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    obj.CambiarLibre(row["IDTERRENO"].ToString());
                }
                

                consulta = "UPDATE RESERVADETALLE SET ESTADORESERVA = 'ANULADO' WHERE IDRESERVA='" + idreserva + "'";
                cnx.Insertar(consulta);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public void ListarDetalleClienteTodos(ref DataTable dgv, string cicliente)
        {
            try
            {
                //SELECT D.IDTERRENO, D.PRECIO, T.METROS, D.ESTADORESERVA, D.FECHARES, D.ESTADO, U.USUARIO, D.CI FROM dbo.RESERVADETALLE AS D INNER JOIN dbo.USUARIO AS U ON D.IDUSUARIO = U.IDUSUARIO INNER JOIN dbo.TERRENO AS T ON D.IDTERRENO = T.IDTERRENO
                //consulta = "SELECT * FROM RESERVADETALLE WHERE CI = '" + cicliente + "'";
                consulta = "SELECT D.IDTERRENO, D.PRECIO, T.METROS, D.ESTADORESERVA, D.FECHARES, U.USUARIO,D.ID FROM dbo.RESERVADETALLE AS D INNER JOIN dbo.USUARIO AS U ON D.IDUSUARIO = U.IDUSUARIO INNER JOIN dbo.TERRENO AS T ON D.IDTERRENO = T.IDTERRENO WHERE  D.CI = '" + cicliente + "'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "RESERVADETALLE");
                //int cant = ds.Tables[0].Rows.Count;
                if (ds != null)
                {
                    dgv = ds.Tables[0];
                }
                else
                {
                    for (int i = 0; i <= dgv.Rows.Count; i++)
                    {
                        dgv.Rows.RemoveAt(0);
                    }
                }
                //dgv.ClearSelection();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        public void ListarDetalleClienteVencidos(ref DataTable dgv, string cicliente)
        {
            try
            {
                //SELECT D.IDTERRENO, D.PRECIO, T.METROS, D.ESTADORESERVA, D.FECHARES, D.ESTADO, U.USUARIO, D.CI FROM dbo.RESERVADETALLE AS D INNER JOIN dbo.USUARIO AS U ON D.IDUSUARIO = U.IDUSUARIO INNER JOIN dbo.TERRENO AS T ON D.IDTERRENO = T.IDTERRENO
                //consulta = "SELECT * FROM RESERVADETALLE WHERE CI = '" + cicliente + "'";
                consulta = "SELECT D.IDTERRENO, D.PRECIO, T.METROS, D.ESTADORESERVA, D.FECHARES, U.USUARIO,D.ID FROM dbo.RESERVADETALLE AS D INNER JOIN dbo.USUARIO AS U ON D.IDUSUARIO = U.IDUSUARIO INNER JOIN dbo.TERRENO AS T ON D.IDTERRENO = T.IDTERRENO WHERE  D.CI = '" + cicliente + "' and D.ESTADORESERVA='VENCIDOS'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "RESERVADETALLE");
                //int cant = ds.Tables[0].Rows.Count;
                if (ds != null)
                {
                    dgv = ds.Tables[0];
                }
                else
                {
                    for (int i = 0; i <= dgv.Rows.Count; i++)
                    {
                        dgv.Rows.RemoveAt(0);
                    }
                }
                //dgv.ClearSelection();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        public void ListarDetalleClienteAnuladosVencido(ref DataTable dgv, string cicliente)
        {
            try
            {
                //SELECT D.IDTERRENO, D.PRECIO, T.METROS, D.ESTADORESERVA, D.FECHARES, D.ESTADO, U.USUARIO, D.CI FROM dbo.RESERVADETALLE AS D INNER JOIN dbo.USUARIO AS U ON D.IDUSUARIO = U.IDUSUARIO INNER JOIN dbo.TERRENO AS T ON D.IDTERRENO = T.IDTERRENO
                //consulta = "SELECT * FROM RESERVADETALLE WHERE CI = '" + cicliente + "'";
                consulta = "SELECT D.IDTERRENO, D.PRECIO, T.METROS, D.ESTADORESERVA, D.FECHARES, U.USUARIO,D.ID FROM dbo.RESERVADETALLE AS D INNER JOIN dbo.USUARIO AS U ON D.IDUSUARIO = U.IDUSUARIO INNER JOIN dbo.TERRENO AS T ON D.IDTERRENO = T.IDTERRENO WHERE  D.CI = '" + cicliente + "' and D.ESTADORESERVA='ANULADO' OR D.ESTADORESERVA='VIGENTE'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "RESERVADETALLE");
                //int cant = ds.Tables[0].Rows.Count;
                if (ds != null)
                {
                    dgv = ds.Tables[0];
                }
                else
                {
                    for (int i = 0; i <= dgv.Rows.Count; i++)
                    {
                        dgv.Rows.RemoveAt(0);
                    }
                }
                //dgv.ClearSelection();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        public void ListarDetalleClienteVigenteVencido(ref DataTable dgv, string cicliente)
        {
            try
            {
                //SELECT D.IDTERRENO, D.PRECIO, T.METROS, D.ESTADORESERVA, D.FECHARES, D.ESTADO, U.USUARIO, D.CI FROM dbo.RESERVADETALLE AS D INNER JOIN dbo.USUARIO AS U ON D.IDUSUARIO = U.IDUSUARIO INNER JOIN dbo.TERRENO AS T ON D.IDTERRENO = T.IDTERRENO
                //consulta = "SELECT * FROM RESERVADETALLE WHERE CI = '" + cicliente + "'";
                consulta = "SELECT D.IDTERRENO, D.PRECIO, T.METROS, D.ESTADORESERVA, D.FECHARES, U.USUARIO,D.ID FROM dbo.RESERVADETALLE AS D INNER JOIN dbo.USUARIO AS U ON D.IDUSUARIO = U.IDUSUARIO INNER JOIN dbo.TERRENO AS T ON D.IDTERRENO = T.IDTERRENO WHERE  D.CI = '" + cicliente + "' and D.ESTADORESERVA <> 'ANULADO'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "RESERVADETALLE");
                //int cant = ds.Tables[0].Rows.Count;
                if (ds != null)
                {
                    dgv = ds.Tables[0];
                }
                else
                {
                    for (int i = 0; i <= dgv.Rows.Count; i++)
                    {
                        dgv.Rows.RemoveAt(0);
                    }
                }
                //dgv.ClearSelection();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        public void ListarDetalleClienteVigenteAnulado(ref DataTable dgv, string cicliente)
        {
            try
            {
                //SELECT D.IDTERRENO, D.PRECIO, T.METROS, D.ESTADORESERVA, D.FECHARES, D.ESTADO, U.USUARIO, D.CI FROM dbo.RESERVADETALLE AS D INNER JOIN dbo.USUARIO AS U ON D.IDUSUARIO = U.IDUSUARIO INNER JOIN dbo.TERRENO AS T ON D.IDTERRENO = T.IDTERRENO
                //consulta = "SELECT * FROM RESERVADETALLE WHERE CI = '" + cicliente + "'";
                consulta = "SELECT D.IDTERRENO, D.PRECIO, T.METROS, D.ESTADORESERVA, D.FECHARES, U.USUARIO,D.ID FROM dbo.RESERVADETALLE AS D INNER JOIN dbo.USUARIO AS U ON D.IDUSUARIO = U.IDUSUARIO INNER JOIN dbo.TERRENO AS T ON D.IDTERRENO = T.IDTERRENO WHERE  D.CI = '" + cicliente + "' and D.ESTADORESERVA <> 'VENCIDO'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "RESERVADETALLE");
                //int cant = ds.Tables[0].Rows.Count;
                if (ds != null)
                {
                    dgv = ds.Tables[0];
                }
                else
                {
                    for (int i = 0; i <= dgv.Rows.Count; i++)
                    {
                        dgv.Rows.RemoveAt(0);
                    }
                }
                //dgv.ClearSelection();
            }
            catch (Exception)
            {

                //throw;
            }
        }


        public void ListarDetalleClienteAnulados(ref DataTable dgv, string cicliente)
        {
            try
            {
                //SELECT D.IDTERRENO, D.PRECIO, T.METROS, D.ESTADORESERVA, D.FECHARES, D.ESTADO, U.USUARIO, D.CI FROM dbo.RESERVADETALLE AS D INNER JOIN dbo.USUARIO AS U ON D.IDUSUARIO = U.IDUSUARIO INNER JOIN dbo.TERRENO AS T ON D.IDTERRENO = T.IDTERRENO
                //consulta = "SELECT * FROM RESERVADETALLE WHERE CI = '" + cicliente + "'";
                consulta = "SELECT D.IDTERRENO, D.PRECIO, T.METROS, D.ESTADORESERVA, D.FECHARES, U.USUARIO,D.ID FROM dbo.RESERVADETALLE AS D INNER JOIN dbo.USUARIO AS U ON D.IDUSUARIO = U.IDUSUARIO INNER JOIN dbo.TERRENO AS T ON D.IDTERRENO = T.IDTERRENO WHERE  D.CI = '" + cicliente + "' and D.ESTADORESERVA='ANULADO'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "RESERVADETALLE");
                //int cant = ds.Tables[0].Rows.Count;
                if (ds != null)
                {
                    dgv = ds.Tables[0];
                }
                else
                {
                    for (int i = 0; i <= dgv.Rows.Count; i++)
                    {
                        dgv.Rows.RemoveAt(0);
                    }
                }
                //dgv.ClearSelection();
            }
            catch (Exception)
            {

                //throw;
            }
        }
        public void ListarDetalleClienteVigente(ref DataTable dgv, string cicliente)
        {
            try
            {
                //SELECT D.IDTERRENO, D.PRECIO, T.METROS, D.ESTADORESERVA, D.FECHARES, D.ESTADO, U.USUARIO, D.CI FROM dbo.RESERVADETALLE AS D INNER JOIN dbo.USUARIO AS U ON D.IDUSUARIO = U.IDUSUARIO INNER JOIN dbo.TERRENO AS T ON D.IDTERRENO = T.IDTERRENO
                //consulta = "SELECT * FROM RESERVADETALLE WHERE CI = '" + cicliente + "'";
                consulta = "SELECT D.IDTERRENO, D.PRECIO, T.METROS, D.ESTADORESERVA, D.FECHARES, U.USUARIO,D.ID FROM dbo.RESERVADETALLE AS D INNER JOIN dbo.USUARIO AS U ON D.IDUSUARIO = U.IDUSUARIO INNER JOIN dbo.TERRENO AS T ON D.IDTERRENO = T.IDTERRENO WHERE  D.CI = '" + cicliente + "' and D.ESTADORESERVA='VIGENTE'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "RESERVADETALLE");
                //int cant = ds.Tables[0].Rows.Count;
                if (ds != null)
                {
                    dgv = ds.Tables[0];
                }
                else
                {
                    for (int i = 0; i <= dgv.Rows.Count; i++)
                    {
                        dgv.Rows.RemoveAt(0);
                    }
                }
                //dgv.ClearSelection();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        public void Listar(DataGridView dgv, string buscar)
        {
            try
            {
                //consulta = "SELECT * FROM COORDENADA WHERE CODLOTE='" + buscar +"'";
                consulta = "SELECT * FROM RESERVADETALLE WHERE CI like '" + buscar + "%' OR ESTADORESERVA LIKE '" + buscar + "%'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "USUARIO");
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

        #endregion

    }
}
