using ChristmasVillageBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    public class VillageFAC : VillageIFAC
    {
        public void createVillage(VillageBO village)
        {
            try
            {
                VillageBL.Insert(village);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void updateLocation(VillageBO village)
        {
            try
            {
                VillageBL.Update(village);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
