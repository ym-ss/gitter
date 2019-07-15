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
    public class ccliente
    {
        #region Atributos
        private string _ci;
        private string _nit;
        private string _nombres;
        private string _apellidos;
        private string _telefono;
        private string _sexo;
        private string _fechanac;
        private string _correo;
        private string _edad;
        private string _estado;
        #endregion

        #region Propiedades
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public string Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }



        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }


        public string FechaNac
        {
            get { return _fechanac; }
            set { _fechanac = value; }
        }


        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public string Nit
        {
            get { return _nit; }
            set { _nit = value; }
        }
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }


        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }


        public string Nombre
        {
            get { return _nombres; }
            set { _nombres = value; }
        }


        public string Ci
        {
            get { return _ci; }
            set { _ci = value; }
        }
        #endregion

        #region Metodos

        private string consulta = "";
        conexion cnx = new conexion();

        //proceso para registrar un nuevo cliente
        public bool Registrar()
        {
            try
            {
                consulta = "INSERT INTO CLIENTE VALUES('" + this.Ci + "','" + this.Nit + "','" + this.Nombre + "','" + this.Apellidos + "','" + this.Telefono + "','" + this.Sexo +"','"+ this.FechaNac + "','"+ this.Correo +"','"+this.Edad+ "','" + this.Estado +"')";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //proceso para editar un cliente
        public bool Editar()
        {
            try
            {
                consulta = "UPDATE CLIENTE SET NIT='" + this.Nit + "', NOMBRES='" + this.Nombre + "', APELLIDOS='" + this.Apellidos + "', TELEFONO='" + this.Telefono + "', SEXO='" + this.Sexo + "', FECHANAC='"+ this.FechaNac +"', CORREO='"+this.Correo+"', EDAD='"+this.Edad+"' WHERE CI='" + this.Ci + "'";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //proceso para habilitar un cliente
        public bool Habilitar()
        {
            try
            {
                consulta = "UPDATE CLIENTE SET ESTADO ='HABILITADO' WHERE CI='" + this.Ci + "'";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //proceso para deshabilitar un cliente
        public bool DesHabilitar()
        {
            try
            {
                consulta = "UPDATE CLIENTE SET ESTADO ='DESHABILITADO' WHERE CI='" + this.Ci + "'";
                cnx.Insertar(consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //proceso para verificar si existe un cliente
        public bool ExisteCliente(string ci)
        {
            try
            {
                consulta = "SELECT * FROM CLIENTE WHERE CI='" + ci + "'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "CLIENTE");
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

        //proceso para obtener los datos de un cliente
        public ccliente ObtenerRegistro(string ci)
        {
            try
            {
                consulta = "SELECT * FROM CLIENTE WHERE CI='" + ci + "'";
                DataSet ds = new DataSet();
                ccliente obj = new ccliente();
                ds = cnx.Listar(consulta, "RESERVA");
                int cant = ds.Tables[0].Rows.Count;
                DataTable dt = ds.Tables[0];
                DataRow row = dt.Rows[0];
                obj.Ci = row["CI"].ToString();
                obj.Nit = row["NIT"].ToString();
                obj.Nombre = row["NOMBRES"].ToString();
                obj.Apellidos = row["APELLIDOS"].ToString();
                obj.Correo= row["CORREO"].ToString();
                obj.Edad = row["EDAD"].ToString();
                obj.FechaNac = row["FECHANAC"].ToString();
                obj.Sexo = row["SEXO"].ToString();
                obj.Telefono = row["TELEFONO"].ToString();
                
                return obj;

            }
            catch (Exception)
            {
                throw;
            }
        }

        //proceso para listar los clientes
        public void Listar(DataGridView dgv, string buscar)
        {
            try
            {
                consulta = "SELECT * FROM CLIENTE WHERE CI like '" + buscar +"%' OR NOMBRES LIKE '" +buscar +"%'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "CLIENTE");
                
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

        //proceso para listar las coordenadas de un terreno
        public DataSet ListarTabla(string buscar)
        {
            try
            {
                consulta = "SELECT LAT,LNG FROM COORDENADA WHERE CODLOTE='" + buscar + "'";
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

        //proceso para verificar si existe un duplicado
        public bool Duplicado(string ci)
        {
            try
            {
                consulta = "SELECT * FROM CLIENTE WHERE CI = '" + ci + "'";
                DataSet ds = new DataSet();
                ds = cnx.Listar(consulta, "CLIENTE");

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
