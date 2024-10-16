using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // Espacio de nombres

namespace Tienda.Utils
{
    internal class Connexion
    {
        private string Server = ".";
        private string Bd = "tienda";
        private string BdUser = "sa";
        private string PassWord = "sas";
        private string MyAppName = "TiendaC#";

        public static String Cn = $"Data Source = .; Initial Catalog = tienda; User Id=sa; Password=sas; Application Name = Tienda";
    }
}
