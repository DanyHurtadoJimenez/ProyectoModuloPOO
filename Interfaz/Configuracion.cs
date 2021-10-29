using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaz
{
    public static class Configuracion
    {

        #region Propiedad 
        //recupera la variable connectionString
        public static string getConnectionString
        {
            get {
                return Properties.Settings.Default.ConnectionString;
            }
        }
        #endregion

    }
}
