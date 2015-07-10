using ChristmasVillageBO;
using ChristmasVillageDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    public class ManageVillageBL
    {
        public static void Insert(ManageVillageBO manageVillage)
        {
            try
            {
                ManageVillageDAL dal = new ManageVillageDAL(CUtil.GetConnexion());
                dal.ManageVillageBO_Insert(
                    manageVillage.id_user,
                    manageVillage.id_village
                    );
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public static ManageVillageBO SearchVillage(int id_user)
        {
            try
            {
                ManageVillageBO manageVillage = new ManageVillageBO();
                ManageVillageDAL dal = new ManageVillageDAL(CUtil.GetConnexion());
                manageVillage = (ManageVillageBO)dal.ManageVillageBO_FindByUserId(id_user);
                return manageVillage;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
