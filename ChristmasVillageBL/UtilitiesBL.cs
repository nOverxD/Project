using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageBL
{
    public class UtilitiesBL
    {
        /// <summary>
        /// All default vaules for the game
        /// </summary>
        public static string villageName = "ChristmasVillage";
        public static int locationDefault = 4;

        private static int minimumCapital = 1075;
        private static int locationMin = 0;

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

        public static bool checkEmptyLocation(int locations)
        {
            if (locations > locationMin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static String getDate()
        {
            DateTime time = new DateTime();
            return time.ToString();
        }

        public static string getRandomInt()
        {
            // Create random number between 50-100
            Random random = new Random();
            random.Next(50, 100);
            return random.ToString();
        }

        public static void setTimer()
        {
            //bla bla bla bla
        }
    }
}
