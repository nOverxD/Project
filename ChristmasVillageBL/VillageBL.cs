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
        public static void Insert(int userId)
        {
            try
            {
                VillageBO village = new VillageBO();
                village.name = CUtil.villageName;
                village.location = CUtil.locationDefault;

                VillageDAL dalVillage = new VillageDAL(CUtil.GetConnexion());
                dalVillage.VillageBO_Insert(
                    village.name,
                    village.location
                    );

                ManageVillageBO manageVillage = new ManageVillageBO();
                manageVillage.id_user = userId;
                //Get id of village
                //manageVillage.id_village = ;

                ManageVillageDAL dalManageVillage = new ManageVillageDAL(CUtil.GetConnexion());
                dalManageVillage.ManageVillageBO_Insert(
                    manageVillage.id_user,
                    manageVillage.id_village
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
