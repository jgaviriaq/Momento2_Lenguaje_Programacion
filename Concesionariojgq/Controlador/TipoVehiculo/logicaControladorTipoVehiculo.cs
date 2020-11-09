using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.TipoVehiculo;
using System.Data;

namespace Controlador.TipoVehiculo
{
    public class logicaControladorTipoVehiculo
    {
        //Negociar INSERT
        public int NegociarInsertTipoVehiculo(int id, string name)
        {
            AccesoMetodosCRUDtipoVehiculo negociarAcceso = new AccesoMetodosCRUDtipoVehiculo();

            return negociarAcceso.InsertTipoVehiculo(id, name);
        }

        //Negociar el SELECT
        public static DataTable NegociarSelectTipoVehiculo()
        {
            return AccesoMetodosCRUDtipoVehiculo.ListTipoVehiculo();
        }

        //Negociar UPDATE
        public int NegociarUpdateTipoVehiculo(int id, string name)
        {
            AccesoMetodosCRUDtipoVehiculo negociarAcceso = new AccesoMetodosCRUDtipoVehiculo();

            return negociarAcceso.UpdateTipoVehiculo(id, name);
        }


        //Negociar DELETE
        public int NegociarDeleteTipoVehiculo(int id)
        {
            AccesoMetodosCRUDtipoVehiculo negociarAcceso = new AccesoMetodosCRUDtipoVehiculo();

            return negociarAcceso.DeleteTipoVehiculo(id);
        }

    }
}
