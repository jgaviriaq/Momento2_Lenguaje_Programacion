using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Ruta
{
    public class MetodosCRUDRuta
    {
        //Creando comando tipo INSERT

        public static SqlCommand CrearComandoProcAlmacInsertarRuta()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("add_ruta", _conexion);

            _comando.CommandType = System.Data.CommandType.StoredProcedure;

            return _comando;

        }

        //Ejeutar el tipo de comando INSERT

        public static int EjecutarComandoProAlmacInsertRuta(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }

            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }


        //Crear tipo comando Select

        public static SqlCommand CrearComandoSelect_Ruta()
        {
            //Usar la Conexion
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;

            //Crear la Instruccion select
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();

            _comando.CommandType = System.Data.CommandType.Text;

            return _comando;
        }


        //Ejecutar el tipo de comando Select

        public static DataTable EjecutarComandoSelect_Ruta(SqlCommand comando)
        {
            DataTable _table = new DataTable();

            try
            {
                comando.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                adapter.Fill(_table);

            }
            catch (Exception Ex) { throw Ex; }
            finally
            {
                comando.Connection.Close();
            }

            return _table;
        }

        //Crear tipo comando Update

        public static SqlCommand CrearComandoProcAlmacUpdate_Ruta()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("updateRuta", _conexion);

            _comando.CommandType = System.Data.CommandType.StoredProcedure;

            return _comando;
        }


        //Ejecutar el tipo de comando Update

        public static int EjecutarComandoProcAlmacUpdateRuta(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

        //Crear tipo comando Delete

        public static SqlCommand CrearComandoProcAlmacDelete_Ruta()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("deleteRuta", _conexion);

            _comando.CommandType = System.Data.CommandType.StoredProcedure;

            return _comando;
        }

        //Ejecutar el tipo de comando Delete

        public static int EjecutarComandoProcAlmacDeleteRuta(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

    }
}
