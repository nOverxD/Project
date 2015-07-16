using ChristmasVillageBL;
using ChristmasVillageBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    public class UserFAC : UserIFAC
    {
        private UserBO userFAC = new UserBO();

        public void createUser(UserBO user)
        {
            try
            {
                UserBL.Insert(user);
                userFAC = UserBL.SearchByName(user);

                VillageBO village = new VillageBO();
                village.name = Utilities.villageName + userFAC.id_user.ToString();
                village.location = Utilities.locationDefault;
                VillageBL.Insert(village);
                
                List<VillageBO> listVillage = VillageBL.Search(village.name);
                foreach (VillageBO item in listVillage)
    	        {
		            village.id_village = item.id_village;
	            }

                ManageVillageBO manageVillage = new ManageVillageBO();
                manageVillage.id_user = userFAC.id_user;
                manageVillage.id_village = village.id_village;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public bool connexion(UserBO user)
        {
            try
            {
                userFAC = UserBL.SearchByName(user);
                if (user.username == userFAC.username && user.password == userFAC.password)
                {
                    userFAC.status = "true";
                    UserBL.Update(userFAC);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {               
                throw;
            }
        }

        public void disconnect(UserBO user)
        {
            try
            {
                user.status = "false";
                UserBL.Update(user);
            }
            catch (Exception)
            {               
                throw;
            }
        }

        public void updateUser(UserBO user)
        {
            try
            {
                UserBL.Update(user);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public bool checkConnexion()
        {
            try
            {
                return true;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public bool checkUniqueUsername(UserBO user)
        {
            try
            {
                return UserBL.checkUniqueUsername(user);
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}
