using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conductor
{
   public  class MetodosCRUDConductor
    {
        // Crear tipo Comando INSERT

        public static SqlCommand CrearComandoProcAlmacInser_Conductor()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("add_conductor", _conexion);

            _comando.CommandType = System.Data.CommandType.StoredProcedure;

            return _comando;
        }


        // Ejecutar el tipo de Comando INSERT
        public static int EjecutarComandoProAlmacInsert_Conductor(SqlCommand comando)
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

        public static SqlCommand CrearComandoSelect_Conductor()
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

        public static DataTable EjecutarComandoSelect_Conductor(SqlCommand comando)
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

        public static SqlCommand CrearComandoProcAlmacUpdate_Conductor()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("updateConductor", _conexion);

            _comando.CommandType = System.Data.CommandType.StoredProcedure;

            return _comando;
        }



        //Ejecutar el tipo de comando Update

        public static int EjecutarComandoProcAlmacUpdateConductor(SqlCommand comando)
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

        public static SqlCommand CrearComandoProcAlmacDelete_Conductor()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("deleteConductor", _conexion);

            _comando.CommandType = System.Data.CommandType.StoredProcedure;

            return _comando;
        }


        //Ejecutar el tipo de comando Delete

        public static int EjecutarComandoProcAlmacDeleteConductor(SqlCommand comando)
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
