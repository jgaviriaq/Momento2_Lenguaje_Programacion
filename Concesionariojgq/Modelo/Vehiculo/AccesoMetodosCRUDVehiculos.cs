using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Vehiculo
{
    public class AccesoMetodosCRUDVehiculos
    {
        // Operacion Insert

        public int InsertVehiculo(int id, string marca, string modelo, string placa, int anio, int id_tipo_vehiculo)
        {
            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoProcAlmacInsertarVehiculos();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@modelo", modelo);
            _comando.Parameters.AddWithValue("@placa", placa);
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@id_tipo_vehiculo", id_tipo_vehiculo);

            return MetodosCRUDVehiculo.EjecutarComandoProAlmacInsertVehiculos(_comando);
        }


        //Operacion Select

        public static DataTable ListVehiculo()
        {
            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoSelectVehiculos();

            _comando.CommandText = "select * from Vehiculo";

            return MetodosCRUDVehiculo.EjecutarComandoSelectVehiculos(_comando);
        }


        // Operacion Update

        public int UpdateVehiculo(int id, string marca, string modelo, string placa, int anio, int id_tipo_vehiculo)
        {
            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoProcAlmacUpdate_Vehiculo();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@modelo", modelo);
            _comando.Parameters.AddWithValue("@placa", placa);
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@id_tipo_vehiculo", id_tipo_vehiculo);
          
            return MetodosCRUDVehiculo.EjecutarComandoProcAlmacUpdateVehiculo(_comando);
        }


        // Operacion Delete

        public int DeleteVehiculo(int id)
        {
            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoProcAlmacDelete_Vehiculo();

            _comando.Parameters.AddWithValue("@id", id);


            return MetodosCRUDVehiculo.EjecutarComandoProcAlmacDeleteVehiculo(_comando);
        }

    }
}
