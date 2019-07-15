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
    public class cusuario
    {
        private int idusuario_;
        private string nombres_;
        private string apellidos_;
        private string usuario_;
        private string pass_;
        private string fechareg_;
        private string estado_;
        private string idrol_;

        public string Estado
        {
            get { return estado_; }
            set { estado_ = value; }
        }

        public string Idrol
        {
            get { return idrol_; }
            set { idrol_ = value; }
        }
        public string FechaReg
        {
            get { return fechareg_; }
            set { fechareg_ = value; }
        }


        public string Usuario
        {
            get { return usuario_; }
            set { usuario_ = value; }
        }

        public string Pass
        {
            get { return pass_; }
            set { pass_ = value; }
        }


        public string Apellidos
        {
            get { return apellidos_; }
            set { apellidos_ = value; }
        }


        public string Nombre
        {
            get { return nombres_; }
            set { nombres_ = value; }
        }


        public int Idusuario
        {
            get { return idusuario_; }
            set { idusuario_ = value; }
        }

        #region Metodos
        private string consulta = "";
        conexion cnx = new conexion();
        public bool Registrar()
        {
            try
            {
                consulta = "INSERT INTO USUARIO VALUES('" + this.Nombre + "','" + this.Apellidos + "','" + this.Usuario + "','" + this.Pass + "','" + this.Estado + "','" + this.FechaReg + "','" + this.Idrol +"')";
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
                consulta = "UPDATE USUARIO SET NOMBRES='" + this.Nombre + "', APELLIDOS='" + this.Apellidos + "', USUARIO='" + this.Usuario + "', PASS='" + this.Pass + "', IDROL='" + this.Idrol + "' WHERE IDUSUARIO='" + this.Idusuario + "'";
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
                consulta = "UPDATE USUARIO SET ESTADO ='HABILITADO' WHERE IDUSUARIO='" + this.Idusuario + "'";
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
                consulta = "UPDATE USUARIO SET ESTADO ='DESHABILITADO' WHERE IDUSUARIO='" + this.Idusuario + "'";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Duplicado(string usuario)
        {
            try
            {
                consulta = "SELECT * FROM USUARIO WHERE USUARIO = '" + usuario + "'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "USUARIO");

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
        public bool ExisteUsuario(string usuario)
        {
            try
            {
                consulta = "SELECT * FROM USUARIO WHERE USUARIO='" + usuario + "'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "USUARIO");
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
        public bool VerificarUsuarioPass(string usuario, string pass,ref string idusuario, ref string usuhabilitado, ref string idrol)
        {
            try
            {
                consulta = "SELECT * FROM USUARIO WHERE USUARIO='" + usuario + "' AND PASS='" + pass +"'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "USUARIO");
                //int cant = ds.Tables[0].Rows.Count;
                if (ds != null)
                {
                    DataTable dt = ds.Tables[0];
                    DataRow row = dt.Rows[0];
                    idusuario = row["IDUSUARIO"].ToString();
                    usuhabilitado = row["ESTADO"].ToString();
                    idrol = row["IDROL"].ToString();
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
     
        public cusuario ObtenerRegistro(string id)
        {
            try
            {
                consulta = "SELECT * FROM USUARIO WHERE IDUSUARIO='" + id + "'";
                DataSet ds = new DataSet();
                cusuario obj = new cusuario();
                ds = cnx.Listar(consulta, "USUARIO");
                int cant = ds.Tables[0].Rows.Count;
                DataTable dt = ds.Tables[0];
                DataRow row = dt.Rows[0];
                obj.Nombre = row["NOMBRES"].ToString();
                obj.Apellidos = row["APELLIDOS"].ToString();
                obj.Usuario = row["USUARIO"].ToString();
                obj.Pass = row["PASS"].ToString();
                obj.Estado = row["ESTADO"].ToString();
                obj.FechaReg = row["FECHAREG"].ToString();
                obj.Idrol= row["IDROL"].ToString();

                return obj;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public cusuario ObtenerUsuario(string usuario)
        {
            try
            {
                consulta = "SELECT * FROM USUARIO WHERE USUARIO='" + usuario + "'";
                DataSet ds = new DataSet();
                cusuario obj = new cusuario();
                ds = cnx.Listar(consulta, "USUARIO");
                int cant = ds.Tables[0].Rows.Count;
                DataTable dt = ds.Tables[0];
                DataRow row = dt.Rows[0];
                obj.Idusuario=int.Parse( row["IDUSUARIO"].ToString());
                obj.Nombre = row["NOMBRES"].ToString();
                obj.Apellidos = row["APELLIDOS"].ToString();
                obj.Usuario = row["USUARIO"].ToString();
                obj.Pass = row["PASS"].ToString();
                obj.Estado = row["ESTADO"].ToString();
                obj.FechaReg = row["FECHAREG"].ToString();

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
               // consulta = "SELECT IDUSUARIO AS ID, NOMBRES,APELLIDOS,USUARIO,ESTADO,FECHAREG FROM USUARIO WHERE NOMBRES like '" + buscar + "%' OR USUARIO LIKE '" + buscar + "%'";
                //SELECT U.IDUSUARIO, U.NOMBRES, U.APELLIDOS, U.USUARIO, U.ESTADO, U.FECHAREG, R.NOMBRE FROM dbo.ROL AS R INNER JOIN dbo.USUARIO AS U ON R.IDROL = U.IDROL
                consulta = "SELECT U.IDUSUARIO as ID, U.NOMBRES, U.APELLIDOS, U.USUARIO, U.ESTADO, U.FECHAREG, R.NOMBRE as ROL FROM dbo.ROL AS R INNER JOIN dbo.USUARIO AS U ON R.IDROL = U.IDROL WHERE NOMBRES like '" + buscar + "%' OR USUARIO LIKE '" + buscar + "%' ORDER BY ID";

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
