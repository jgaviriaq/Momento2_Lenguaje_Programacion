using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conductor
{
    public class AccesoMetodosCRUDConductor
    {
        //Operacion INSERT
        public int InsertConductor(int id, string nombre, string tipo_licencia, int id_vehiculo, int id_tipo_conductor)
        {
            SqlCommand _comando = MetodosCRUDConductor.CrearComandoProcAlmacInser_Conductor();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@tipo_licencia", tipo_licencia);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
            _comando.Parameters.AddWithValue("@id_tipo_conductor", id_tipo_conductor);

            return MetodosCRUDConductor.EjecutarComandoProAlmacInsert_Conductor(_comando);

        }

        //Operacion SELECT
        public static DataTable ListConductor()
        {
            SqlCommand _comando = MetodosCRUDConductor.CrearComandoSelect_Conductor();

            _comando.CommandText = "select* from conductor";

            return MetodosCRUDConductor.EjecutarComandoSelect_Conductor(_comando);
        }

        // Operacion Update

        public int UpdateConductor(int id, string nombre, string tipo_licencia, int id_vehiculo,int id_tipo_conductor)
        {
            SqlCommand _comando = MetodosCRUDConductor.CrearComandoProcAlmacUpdate_Conductor();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@tipo_licencia", tipo_licencia);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
            _comando.Parameters.AddWithValue("@id_tipo_conductor", id_tipo_conductor);

            return MetodosCRUDConductor.EjecutarComandoProcAlmacUpdateConductor(_comando);
        }


        // Operacion Delete

        public int DeleteConductor(int id)
        {
            SqlCommand _comando = MetodosCRUDConductor.CrearComandoProcAlmacDelete_Conductor();

            _comando.Parameters.AddWithValue("@id", id);


            return MetodosCRUDConductor.EjecutarComandoProcAlmacDeleteConductor(_comando);
        }
    }
}
