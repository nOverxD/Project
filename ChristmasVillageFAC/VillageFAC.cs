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
        public void createVillage(VillageBO village)
        {
            try
            {
                village.name = UtilitiesBL.villageName + village.id_village.ToString();
                village.location = UtilitiesBL.locationDefault;
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

        public VillageBO findVillage (int id_village)
        {
            try
            {
                return VillageBL.Search(id_village);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
