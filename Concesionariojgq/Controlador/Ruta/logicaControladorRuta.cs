﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Ruta;
using System.Data;

namespace Controlador.Ruta
{
    public class logicaControladorRuta
    {
        //Negociar INSERT
        public int NegociarInsertRuta(int id, string estacion, int id_vehiculo)
        {
            AccesoMetodosCRUDRuta negociarAcceso = new AccesoMetodosCRUDRuta();

            return negociarAcceso.InsertRuta(id, estacion, id_vehiculo);
        }

        //Negociar el SELECT
        public static DataTable NegociarSelectRuta()
        {
            return AccesoMetodosCRUDRuta.ListRuta();
        }


        //Negociar UPDATE
        public int NegociarUpdateRuta(int id, string estacion, int id_vehiculo)
        {
            AccesoMetodosCRUDRuta negociarAcceso = new AccesoMetodosCRUDRuta();

            return negociarAcceso.UpdateRuta(id, estacion, id_vehiculo);
        }


        //Negociar DELETE
        public int NegociarDeleteRuta(int id)
        {
            AccesoMetodosCRUDRuta negociarAcceso = new AccesoMetodosCRUDRuta();

            return negociarAcceso.DeleteRuta(id);
        }
    }
}
