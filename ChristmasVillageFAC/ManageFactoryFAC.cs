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
        // Implémentation méthode createManageFactory Interface ManageFactory
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

        // Implémentation méthode findFactoryByVillage Interface ManageFactory
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

        // Implémentation méthode deleteManageFactory Interface ManageFactory
        public void deleteManageFactory(int id_factory)
        {
            try
            {
                ManageFactoryBL.Delete(id_factory);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
