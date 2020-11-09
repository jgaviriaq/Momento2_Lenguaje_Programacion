using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Vehiculo;
using System.Data;

namespace Controlador.Vehiculo
{
    public class logicaControladorVehiculos
    {
        //Negociar INSERT
        public int NegociarInsertVehiculo(int id, string marca, string modelo, string placa, int anio, int id_tipo_vehiculo)
        {
            AccesoMetodosCRUDVehiculos negociarAcceso = new AccesoMetodosCRUDVehiculos();

            return negociarAcceso.InsertVehiculo(id, marca, modelo, placa, anio, id_tipo_vehiculo);
        }

        //Negociar SELECT

        public static DataTable NegociarSelectVehiculo()
        {
            return AccesoMetodosCRUDVehiculos.ListVehiculo();
        }

        //Negociar UPDATE
        public int NegociarUpdateVehiculo(int id, string marca, string modelo, string placa, int anio, int id_tipo_vehiculo)
        {
            AccesoMetodosCRUDVehiculos negociarAcceso = new AccesoMetodosCRUDVehiculos();

            return negociarAcceso.UpdateVehiculo(id, marca, modelo, placa, anio, id_tipo_vehiculo);
        }


        //Negociar DELETE
        public int NegociarDeleteVehiculo(int id)
        {
            AccesoMetodosCRUDVehiculos negociarAcceso = new AccesoMetodosCRUDVehiculos();

            return negociarAcceso.DeleteVehiculo(id);
        }
    }
}
