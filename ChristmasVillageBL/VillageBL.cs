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
                VillageDAL dal = new VillageDAL(CUtil.GetConnexion());
                dal.VillageBO_Insert(
                    village.name,
                    village.location
                    );
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
                    village.name,
                    village.location
                    );
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
