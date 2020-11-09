using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Contrato
{
    public class AccesoMetodosCRUDContrato
    {
        // Operacion Insert

        public int InsertContrato(int id, int id_conductor, int id_vehiculo)
        {
            SqlCommand _comando = MetodosCRUDContrato.CrearComandoProcAlmacInsertarContrato();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@id_conductor", id_conductor);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            return MetodosCRUDContrato.EjecutarComandoProAlmacInsertContrato(_comando);
        }

        //Operacion SELECT
        public static DataTable ListContrato()
        {
            SqlCommand _comando = MetodosCRUDContrato.CrearComandoSelect_Contrato();

            _comando.CommandText = "select* from contrato";

            return MetodosCRUDContrato.EjecutarComandoSelect_Contrato(_comando);
        }

        // Operacion Update

        public int UpdateContrato(int id, int id_conductor, int id_vehiculo)
        {
            SqlCommand _comando = MetodosCRUDContrato.CrearComandoProcAlmacUpdate_Contrato();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@id_conductor", id_conductor);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            return MetodosCRUDContrato.EjecutarComandoProcAlmacUpdateContrato(_comando);
        }


        // Operacion Delete

        public int DeleteContrato(int id)
        {
            SqlCommand _comando = MetodosCRUDContrato.CrearComandoProcAlmacDelete_Contrato();

            _comando.Parameters.AddWithValue("@id", id);


            return MetodosCRUDContrato.EjecutarComandoProcAlmacDeleteContrato(_comando);
        }


    }
}
