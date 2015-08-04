using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageBL
{
    public class UtilitiesBL
    {
        public static string villageName = "ChristmasVillage";
        public static int locationDefault = 4;
        public static int capitalDefault = 2000;
        public static int minimumCapital = 1075;
        public static int locationMin = 0;

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

        public static string getDate()
        {
            DateTime time = new DateTime();
            return time.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public static int getRandomInt()
        {
            Random random = new Random();
            int number = random.Next(50, 100);
            return number;
        }

        public static void setTimer()
        {
            //bla bla bla bla
        }
    }
}
