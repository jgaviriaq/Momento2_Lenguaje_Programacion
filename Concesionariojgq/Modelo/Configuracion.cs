using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Configuracion
    {
        static string cadenaConexion = @"Data Source = ASUS-PC\SQLEXPRESS; Initial Catalog = concesionario; User = sa; Password = 71294859 ";


        public static string CadenaConexion
        {
            get { return cadenaConexion; }
           
        }

    }
}
