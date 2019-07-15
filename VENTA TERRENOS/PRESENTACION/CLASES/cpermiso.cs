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
  public  class cpermiso
    {
        private string consulta = "";
        conexion cnx = new conexion();


        public void Listar(DataGridView dgv, string buscar)
        {
            try
            {
                //SELECT P.ID, R.NOMBRE, P.MENU, P.PERMISO FROM dbo.PERMISO AS P INNER JOIN dbo.ROL AS R ON P.IDROL = R.IDROL
                consulta = "SELECT P.ID, R.NOMBRE AS ROL, P.MENU, P.PERMISO FROM dbo.PERMISO AS P INNER JOIN dbo.ROL AS R ON P.IDROL = R.IDROL WHERE P.IDROL ='" + buscar + "'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "PERMISO");

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

        public DataSet ObtenerPermisoUsuarioMenu(string idrol, ref DataGridView dgv)
        {
            DataSet ds = new DataSet();
            try
            {
                //consulta = "SELECT * FROM COORDENADA WHERE CODLOTE='" + buscar +"'";
                consulta = "SELECT MENU FROM PERMISO WHERE IDROL ='" + idrol + "' and PERMISO='1'";
               
                ds = cnx.Listar(consulta, "PERMISO");

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
            return ds;
        }

        public bool GuardarCambios(string id, string permiso)
        {
            try
            {
                consulta = "UPDATE PERMISO SET PERMISO='" + permiso + "' WHERE ID='" + id + "'";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
