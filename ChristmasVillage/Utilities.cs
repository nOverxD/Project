using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillage
{
    public class Utilities
    {
        public static string villageName = "ChristmasVillage";
        public static int capitalDefault = 2000;
        public static int minimumCapital = 1075;

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

        public static int getRandomInt()
        {
            Random random = new Random();
            int number = random.Next(50, 100);
            return number;
        }

        public static DateTime getDate()
        {
            return DateTime.Now;
        }

        public static bool compareDate(DateTime date1, DateTime date2)
        {
            int result = DateTime.Compare(date1, date2);
            if (result == 0)
            {
                return true;
            }
            else if (result > 0)
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
