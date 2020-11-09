using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.TipoConductor;
using System.Data;

namespace Controlador.TipoConductor
{
    public class logicaControladorTipoConductor
    {
        //Negociar INSERT
        public int NegociarInsertTipoConductor(int id, string nombre)
        {
            AccesoMetodosCRUDtipoConductor negociarAcceso = new AccesoMetodosCRUDtipoConductor();

            return negociarAcceso.InsertTipoConductor(id, nombre);
        }

        //Negociar el SELECT
        public static DataTable NegociarSelectTipoConductor()
        {
            return AccesoMetodosCRUDtipoConductor.ListTipoConductor();
        }

        //Negociar UPDATE
        public int NegociarUpdateTipoConductor(int id, string tipo_persona)
        {
            AccesoMetodosCRUDtipoConductor negociarAcceso = new AccesoMetodosCRUDtipoConductor();

            return negociarAcceso.UpdateTipoConductor(id, tipo_persona);
        }


        //Negociar DELETE
        public int NegociarDeleteTipoConductor(int id)
        {
            AccesoMetodosCRUDtipoConductor negociarAcceso = new AccesoMetodosCRUDtipoConductor();

            return negociarAcceso.DeleteTipoConductor(id);
        }

    }
}
