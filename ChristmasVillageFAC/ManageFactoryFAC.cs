using ChristmasVillageBO;
using ChristmasVillageIFAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageFAC
{
    public class ManageFactoryFAC : ManageFactoryIFAC
    {
        public void createManageFactory(ManageFactoryBO village)
        {
            try
            {
                ManageFactoryBL.Insert(village);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ManageFactoryBO> findFactoryByVillage(int id_Village)
        {
            try
            {
                return ManageFactoryBL.SearchFactories(id_Village);
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}
