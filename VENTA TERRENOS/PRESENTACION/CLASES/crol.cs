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
    public class crol
    {
        private int idrol_;
        private string nombres_;
        private string estado_;

        public string Estado
        {
            get { return estado_; }
            set { estado_ = value; }
        }

        public string Nombre
        {
            get { return nombres_; }
            set { nombres_ = value; }
        }

        public int Idrol
        {
            get { return idrol_; }
            set { idrol_ = value; }
        }

        #region Metodos
        private string consulta = "";
        conexion cnx = new conexion();
        public bool Registrar()
        {
            try
            {
                consulta = "INSERT INTO ROL VALUES('" + this.Nombre + "','" + "HABILITADO" + "')";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string UltimaCargo()
        {
            int ultimo = 1;
            try
            {
                consulta = "SELECT MAX(IDROL) AS ID FROM ROL";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "ROL");
                if (ds != null)
                {
                    DataTable dt = ds.Tables[0];
                    DataRow row = dt.Rows[0];
                    ultimo = int.Parse(row["ID"].ToString()) ;

                }

                return ultimo.ToString();
            }
            catch (Exception)
            {

                return ultimo.ToString();
            }
        }

        public bool RegistrarPermisos()
        {
            try
            {
                string idrol__ = UltimaCargo();

                consulta = "INSERT INTO PERMISO VALUES('" + idrol__ + "', 'mcliente', '0')";
                cnx.Insertar(consulta);
                consulta = "INSERT INTO PERMISO VALUES('" + idrol__ + "', 'murbanizacion', '0')";
                cnx.Insertar(consulta);
                consulta = "INSERT INTO PERMISO VALUES('" + idrol__ + "', 'mterreno', '0')";
                cnx.Insertar(consulta);
                consulta = "INSERT INTO PERMISO VALUES('" + idrol__ + "', 'mtipoterreno', '0')";
                cnx.Insertar(consulta);
                consulta = "INSERT INTO PERMISO VALUES('" + idrol__ + "', 'mreserva', '0')";
                cnx.Insertar(consulta);
                consulta = "INSERT INTO PERMISO VALUES('" + idrol__ + "', 'minforme', '0')";
                cnx.Insertar(consulta);
                consulta = "INSERT INTO PERMISO VALUES('" + idrol__ + "', 'musuario', '0')";
                cnx.Insertar(consulta);
                consulta = "INSERT INTO PERMISO VALUES('" + idrol__ + "', 'mroles', '0')";
                cnx.Insertar(consulta);
                consulta = "INSERT INTO PERMISO VALUES('" + idrol__ + "', 'mpermisos', '0')";
                cnx.Insertar(consulta);
                consulta = "INSERT INTO PERMISO VALUES('" + idrol__ + "', 'mdatosempresa', '0')";
                cnx.Insertar(consulta);
                consulta = "INSERT INTO PERMISO VALUES('" + idrol__ + "', 'mterrenolibre', '0')";
                cnx.Insertar(consulta);
                consulta = "INSERT INTO PERMISO VALUES('" + idrol__ + "', 'meliminarterreno', '0')";
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
                consulta = "UPDATE ROL SET NOMBRE='" + this.Nombre + "' WHERE Idrol='" + this.Idrol + "'";
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
                consulta = "UPDATE ROL SET ESTADO ='HABILITADO' WHERE Idrol='" + this.Idrol + "'";
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
                consulta = "UPDATE ROL SET ESTADO ='DESHABILITADO' WHERE Idrol='" + this.Idrol + "'";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool ExisteRol(string rol)
        {
            try
            {
                consulta = "SELECT * FROM ROL WHERE NOMBRE='" + rol + "'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "ROL");
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
       
        public crol ObtenerRegistro(string id)
        {
            try
            {
                consulta = "SELECT * FROM ROL WHERE Idrol='" + id + "'";
                DataSet ds = new DataSet();
                crol obj = new crol();
                ds = cnx.Listar(consulta, "ROL");
                int cant = ds.Tables[0].Rows.Count;
                DataTable dt = ds.Tables[0];
                DataRow row = dt.Rows[0];
                obj.Nombre = row["NOMBRE"].ToString();
                obj.Estado = row["ESTADO"].ToString();
                
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
                consulta = "SELECT * FROM ROL WHERE NOMBRE like '" + buscar + "%'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "ROL");
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

        public void CargarRol(ComboBox cmb)
        {
            try
            {
                consulta = "SELECT * FROM ROL";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "ROL");
                int cant = ds.Tables[0].Rows.Count;
                if (ds != null)
                {
                    cmb.DataSource = ds.Tables[0];
                    cmb.DisplayMember = "NOMBRE";
                    cmb.ValueMember = "IDROL";
                }

            }
            catch (Exception)
            {

                //throw;
            }
        }

        #endregion

    }
}

