using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Ruta
{
    public class AccesoMetodosCRUDRuta
    {
        // Operacion Insert

        public int InsertRuta(int id, string estacion, int id_vehiculo)
        {
            SqlCommand _comando = MetodosCRUDRuta.CrearComandoProcAlmacInsertarRuta();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@estacion", estacion);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            return MetodosCRUDRuta.EjecutarComandoProAlmacInsertRuta(_comando);
        }

        //Operacion SELECT
        public static DataTable ListRuta()
        {
            SqlCommand _comando = MetodosCRUDRuta.CrearComandoSelect_Ruta();

            _comando.CommandText = "select* from ruta";

            return MetodosCRUDRuta.EjecutarComandoSelect_Ruta(_comando);
        }

        // Operacion Update

        public int UpdateRuta(int id, string estacion, int id_vehiculo)
        {
            SqlCommand _comando = MetodosCRUDRuta.CrearComandoProcAlmacUpdate_Ruta();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@estacion", estacion);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            return MetodosCRUDRuta.EjecutarComandoProcAlmacUpdateRuta(_comando);
        }


        // Operacion Delete

        public int DeleteRuta(int id)
        {
            SqlCommand _comando = MetodosCRUDRuta.CrearComandoProcAlmacDelete_Ruta();

            _comando.Parameters.AddWithValue("@id", id);


            return MetodosCRUDRuta.EjecutarComandoProcAlmacDeleteRuta(_comando);
        }
    }
}
