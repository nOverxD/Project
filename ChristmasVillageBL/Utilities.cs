using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageBL
{
    public class Utilities
    {
        public static string villageName = "ChristmasVillage";
        public static int locationDefault = 4;
        private static int minimumCapital = 1075;
        private static int locationMin = 0;

        public bool checkCapital(int userCapital)
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

        public bool checkEmptyLocation(int locations)
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
    }
}
