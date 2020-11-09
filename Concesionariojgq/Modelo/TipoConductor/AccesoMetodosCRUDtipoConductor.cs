using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoConductor
{
    public class AccesoMetodosCRUDtipoConductor
    {
        //Operacion INSERT
        public int InsertTipoConductor(int id, string tipo_persona)
        {
            SqlCommand _comando = MetodosCRUDtipoConductor.CrearComandoProcAlmacInser_TipoConducor();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@tipo_persona", tipo_persona);

            return MetodosCRUDtipoConductor.EjecutarComandoProAlmacInsert_TipoConductor(_comando);
        }

        //Operacion SELECT
        public static DataTable ListTipoConductor()
        {
            SqlCommand _comando = MetodosCRUDtipoConductor.CrearComandoSelect_tipoConductor();

            _comando.CommandText = "select* from tipo_conductor";

            return MetodosCRUDtipoConductor.EjecutarComandoSelect_tipoConductor(_comando);
        }


        // Operacion Update

        public int UpdateTipoConductor(int id, string tipo_persona)
        {
            SqlCommand _comando = MetodosCRUDtipoConductor.CrearComandoProcAlmacUpdate_tipoConductor();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@tipo_persona", tipo_persona);

            return MetodosCRUDtipoConductor.EjecutarComandoProcAlmacUpdateTipoConductor(_comando);
        }


        // Operacion Delete

        public int DeleteTipoConductor(int id)
        {
            SqlCommand _comando = MetodosCRUDtipoConductor.CrearComandoProcAlmacDelete_tipoConductor();

            _comando.Parameters.AddWithValue("@id", id);


            return MetodosCRUDtipoConductor.EjecutarComandoProcAlmacDeleteTipoConductor(_comando);
        }
    }
}
