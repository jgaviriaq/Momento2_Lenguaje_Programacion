using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Vehiculo
{
    public class MetodosCRUDVehiculo
    {
        //Creando tipo comando Insert

        public static SqlCommand CrearComandoProcAlmacInsertarVehiculos()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("addVehiculo", _conexion);

            _comando.CommandType = System.Data.CommandType.StoredProcedure;

            return _comando;

        }

        //Ejeutar el tipo de comando INSERT

        public static int EjecutarComandoProAlmacInsertVehiculos(SqlCommand comando)
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


        //Creando tipo comando SELECT

        public static SqlCommand CrearComandoSelectVehiculos()
        {
            // Usar la conexion
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection();

            _conexion.ConnectionString = _cadenaConexion;

            //Crear la Instruccion select
            SqlCommand _comando = new SqlCommand();

            _comando = _conexion.CreateCommand();

            _comando.CommandType = System.Data.CommandType.Text;

            return _comando;

        }

        //Ejeutar el tipo de comando Select

        public static DataTable EjecutarComandoSelectVehiculos(SqlCommand comando)
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

        public static SqlCommand CrearComandoProcAlmacUpdate_Vehiculo()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("updateVehiculo", _conexion);

            _comando.CommandType = System.Data.CommandType.StoredProcedure;

            return _comando;
        }


        //Ejecutar el tipo de comando Update

        public static int EjecutarComandoProcAlmacUpdateVehiculo(SqlCommand comando)
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

        public static SqlCommand CrearComandoProcAlmacDelete_Vehiculo()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("deleteVehiculo", _conexion);

            _comando.CommandType = System.Data.CommandType.StoredProcedure;

            return _comando;
        }


        //Ejecutar el tipo de comando Delete

        public static int EjecutarComandoProcAlmacDeleteVehiculo(SqlCommand comando)
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
