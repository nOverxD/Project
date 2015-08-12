using ChristmasVillageBL;
using ChristmasVillageIFAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageFAC
{
    public class UtilitiesFAC : UtilitiesIFAC
    {
        public bool checkCapital(int userCapital)
        {
            try
            {
                return UtilitiesBL.checkCapital(userCapital);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public bool checkEmptyLocation(int locations)
        {
            try
            {
                return UtilitiesBL.checkEmptyLocation(locations);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public int getRandomNumber()
        {
            try
            {
                return UtilitiesBL.getRandomInt();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
