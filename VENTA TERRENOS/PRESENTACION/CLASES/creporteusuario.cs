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
    public class creporteusuario
    {
        private string consulta = "";
        conexion cnx = new conexion();

        public void Listar(DataGridView dgv, string buscar, string fecha)
        {
            try
            {
                //consulta = "SELECT U.NOMBRES, U.APELLIDOS,U.USUARIO,COUNT(U.USUARIO) AS CANTIDAD, SUM(R.PRECIO) AS SUMA_TOTAL FROM dbo.USUARIO AS U INNER JOIN dbo.RESERVADETALLE AS R ON U.IDUSUARIO = R.IDUSUARIO WHERE cast(R.FECHARES as date) = cast(getdate() as date) AND R.ESTADORESERVA = 'VIGENTE' GROUP BY  U.USUARIO, U.NOMBRES, U.APELLIDOS";
                consulta = "SELECT U.NOMBRES, U.APELLIDOS,U.USUARIO,COUNT(U.USUARIO) AS CANTIDAD, SUM(R.PRECIO) AS SUMA_TOTAL FROM dbo.USUARIO AS U INNER JOIN dbo.RESERVADETALLE AS R ON U.IDUSUARIO = R.IDUSUARIO WHERE cast(R.FECHARES as date) = cast('" + fecha +"' as date) AND R.ESTADORESERVA = 'VIGENTE' GROUP BY  U.USUARIO, U.NOMBRES, U.APELLIDOS";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "CLIENTE");
                int cant = ds.Tables[0].Rows.Count;
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

        public void ListarReservaMes(DataGridView dgv)
        {
            try
            {
                //select DATENAME(MONTH, FECHARES) AS 'mes', DATENAME(YEAR, FECHARES) AS 'año',sum(precio) total from reservadetalle group by DATENAME(MONTH, FECHARES),DATENAME(YEAR, FECHARES) ORDER BY DATENAME(MONTH, FECHARES) DESC
                consulta = "select DATENAME(MONTH, FECHARES) AS 'MES', DATENAME(YEAR, FECHARES) AS 'AÑO',count(precio) TOTAL_RESERVA, sum(precio) TOTAL_BS  from reservadetalle group by DATENAME(MONTH, FECHARES),DATENAME(YEAR, FECHARES) ORDER BY DATENAME(MONTH, FECHARES) DESC";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "reservadetalle");
                int cant = ds.Tables[0].Rows.Count;
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

        public void ListarReservaDia(DataGridView dgv)
        {
            try
            {
                //select cast(FECHARES as date) MES, sum(precio) total from reservadetalle group by cast(FECHARES as date) ORDER BY cast(FECHARES as date) DESC
                consulta = "select cast(FECHARES as date) MES,count(precio) TOTAL_RESERVA, sum(precio) TOTAL_BS from reservadetalle group by cast(FECHARES as date) ORDER BY cast(FECHARES as date) DESC";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "reservadetalle");
                int cant = ds.Tables[0].Rows.Count;
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
    }
}
