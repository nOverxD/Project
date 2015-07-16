using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageDAL
{
    public static class CUtil
    {
        public static String GetConnexion()
        {
            String connexion;
            SqlConnectionStringBuilder builder;

            try
            {
                builder = new SqlConnectionStringBuilder();
                connexion = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
                builder = new SqlConnectionStringBuilder(connexion);
            }
            catch (Exception)
            {
                throw;
            }
            return builder.ConnectionString;
        }
    }
}
