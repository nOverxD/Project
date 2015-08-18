using ChristmasVillageBO;
using ChristmasVillageDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    public class VillageBL
    {
        public static void Insert(VillageBO village)
        {
            try
            {
                VillageDAL dalVillage = new VillageDAL(CUtil.GetConnexion());
                dalVillage.VillageBO_Insert(village.name);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public static void Update(VillageBO village)
        {
            try
            {
                VillageDAL dal = new VillageDAL(CUtil.GetConnexion());
                dal.VillageBO_Update(
                    village.id_village,
                    village.name
                    );
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public static VillageBO Search(string villageName)
        {
            try
            {
                List<VillageBO> listVillage = new List<VillageBO>();
                VillageBO result = new VillageBO();
                VillageDAL dal = new VillageDAL(CUtil.GetConnexion());
                listVillage = dal.VillageBO_Search(villageName).ToList();
                result = listVillage.FirstOrDefault();
                return result;
            }
            catch (Exception)
            {               
                throw;
            }
        }
    }
}
