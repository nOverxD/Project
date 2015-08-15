using ChristmasVillageBO;
using ChristmasVillageDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    public class ManageFactoryBL
    {
        // Méthode Insert ManageFactory
        public static void Insert(ManageFactoryBO manageFactory)
        {
            try
            {
                ManageFactoryDAL dal = new ManageFactoryDAL(CUtil.GetConnexion());
                dal.ManageFactoryBO_Insert(
                    manageFactory.id_village,
                    manageFactory.id_factory
                    );
            }
            catch (Exception)
            {                
                throw;
            }
        }

        // Méthode Delete ManageFactory en fonction de ID Factory
        public static void Delete(int id_factory)
        {
            try
            {
                ManageFactoryDAL dal = new ManageFactoryDAL(CUtil.GetConnexion());
                dal.ManageFactoryBO_Delete(id_factory);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        // Méthode qui retourne une liste de ManageFactory en fonction de ID Village
        public static List<ManageFactoryBO> SearchFactories(int id_village)
        {
            try
            {
                List<ManageFactoryBO> listManageFactories = new List<ManageFactoryBO>();
                ManageFactoryDAL dal = new ManageFactoryDAL(CUtil.GetConnexion());
                listManageFactories = dal.ManageFactoryBO_FindFactories(id_village).ToList();
                return listManageFactories;
            }
            catch (Exception)
            {               
                throw;
            }
        }
    }
}
