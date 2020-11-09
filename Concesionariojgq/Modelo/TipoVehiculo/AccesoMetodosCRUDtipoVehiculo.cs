using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoVehiculo
{
    public class AccesoMetodosCRUDtipoVehiculo
    {
        // Operacion Insert

        public int InsertTipoVehiculo(int id, string nombre)
        {
            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoProcAlmacInsert_tiposVehiculo();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDtipoVehiculo.EjecutarComandoProcAlmacInsertarTiposVehiculo(_comando);
        }

        //Operacion SELECT
        public static DataTable ListTipoVehiculo()
        {
            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoSelect_tipoVehiculo();

            _comando.CommandText = "select * from tipo_vehiculo";

            return MetodosCRUDtipoVehiculo.EjecutarComandoSelect_tipoVehiculo(_comando);
        }

        // Operacion Update

        public int UpdateTipoVehiculo(int id, string nombre)
        {
            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoProcAlmacUpdate_tiposVehiculo();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDtipoVehiculo.EjecutarComandoProcAlmacUpdateTiposVehiculo(_comando);
        }

        // Operacion Delete

        public int DeleteTipoVehiculo(int id)
        {
            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoProcAlmacDelete_tiposVehiculo();

            _comando.Parameters.AddWithValue("@id", id);
            

            return MetodosCRUDtipoVehiculo.EjecutarComandoProcAlmacDeleteTiposVehiculo(_comando);
        }

    }
}
