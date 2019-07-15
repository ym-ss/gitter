using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATOS
{
    public class conexion
    {
        //mi conexion:
        SqlConnection conexion_ = new SqlConnection("server=PC00\\SQL;database=BDLOTES;integrated security = true");
       
        //procedimiento que abre la conexion sqlsever
        public void conectar()
        {
            try
            {
                conexion_.Open();
                comm.Connection = conexion_;
                comm.CommandType = System.Data.CommandType.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //procedimiento que cierra la conexion sqlserver
        public void desconectar()
        {
            conexion_.Close();
        }

        //funcion que devuelve la conexion sqlserver
        public SqlConnection conex()
        {
            return conexion_;
        }

        SqlCommand comm = new SqlCommand();
        SqlDataAdapter adaptador = new SqlDataAdapter();
        DataSet registros = new DataSet();
        //       Dim adaptador As New SqlDataAdapter
        //Dim registros As New DataSet
        //   Dim comandos As New SqlCommand
        //   Dim cmd As New SqlCommand
        public void Insertar(string sqlconsulta)
        {
            conectar();
            comm.CommandText = sqlconsulta;
            try
            {
                comm.ExecuteNonQuery();
                //'MsgBox("Se guardo correctamente.", MsgBoxStyle.Information, "Guardado")
            }
            catch (Exception ex)
            {
                //MsgBox(Err.Number & " - " & Err.Description, MsgBoxStyle.Exclamation, "Error al guardar")
                MessageBox.Show("Error al guardar");
            }
            desconectar();
        }


        public DataSet Listar(string sqlconsulta, string tabla)
        {
            try
            {
                int lista = 0;
                conectar();
                adaptador = new SqlDataAdapter(sqlconsulta, conexion_);
                registros = new DataSet();
                adaptador.Fill(registros, tabla);
                lista = registros.Tables[tabla].Rows.Count;
                desconectar();
                if (lista != 0)
                {
                    return registros;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return null;
        }

    }
}
