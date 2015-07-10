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
        private static int minimumCapital = 1075;
        private static int location = 0;

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

        public static Boolean checkCapital(int userCapital)
        {
            if (userCapital >= minimumCapital)
            {
                return true;
            }
            else
            {
                return false;
            };
        }

        public static Boolean checkEmptyLocation (int locations)
        {
            if (locations > location)
            {
                return true;
            }
            else
	        {
                return false;
	        }
        }
    }
}
