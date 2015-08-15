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
        // Méthode Insert ManageVillage
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

        // Méthode qui retourne un ManageVillage en fonction de ID User
        public static ManageVillageBO SearchVillage(int id_user)
        {
            try
            {
                List<ManageVillageBO> listResult = new List<ManageVillageBO>();
                ManageVillageBO result = new ManageVillageBO();
                ManageVillageDAL dal = new ManageVillageDAL(CUtil.GetConnexion());
                listResult = dal.ManageVillageBO_FindByUserId(id_user).ToList();
                result = listResult.FirstOrDefault();
                return result;
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}
