using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillage
{
    /*
     * Utilitaire et paramètre Jeux
     */
    public class Utilities
    {
        /*
         * Déclarations des variables
         */
        public static string villageName = "ChristmasVillage";
        public static int capitalDefault = 2000;
        public static int minimumCapital = 500;
        public static double productionTime = 1;


        /*
         * Permet de vérifier si capitalUser >= capitalMinimum
         * Si oui: retourne 'True'
         * Sinon: retourne 'False'
         */
        public static bool checkCapital(int userCapital)
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

        /*
         * Génère un nombre entre 50 et 100
         */
        public static int getRandomInt()
        {
            Random random = new Random();
            int number = random.Next(50, 100);
            return number;
        }

        /*
         * Retourne la date actuelle
         */
        public static DateTime getDate()
        {
            return DateTime.Now;
        }

        /*
         * Compare deux dates
         * Si date1 > date2: retourne 'True'
         * Si date1 <= date2: retourne 'False'
         */
        public static bool compareDate(DateTime date1, DateTime date2)
        {
            int result = DateTime.Compare(date1, date2);
            if (result > 0)
            {
                return true;
            }
            else if (result == 0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
