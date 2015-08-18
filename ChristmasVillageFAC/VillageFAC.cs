using ChristmasVillageBL;
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
        // Implémentation méthode createVillage Interface Village
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

        // Implémentation méthode findVillage Interface Village
        public VillageBO findVillage(string villageName)
        {
            try
            {
                return VillageBL.Search(villageName);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
