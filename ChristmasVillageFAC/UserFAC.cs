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
        private UserBO userFAC;
        private String USER_STATUS_OK = "true";
        private String USER_STATUS_NOK = "false";

        public void createUser(UserBO user)
        {
            try
            {
                user.capital = UtilitiesBL.capitalDefault;
                user.status = USER_STATUS_NOK;
                UserBL.Insert(user);
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
        public UserBO searchUser(UserBO user)
        {
            try
            {
                userFAC = new UserBO();
                userFAC = UserBL.SearchByName(user);
                return userFAC;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public UserBO findById(int id_user)
        {
            try
            {
                userFAC = new UserBO();
                userFAC = UserBL.SearchById(id_user);
                return userFAC;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public String connexion(UserBO user)
        {
            try
            {
                userFAC = new UserBO();
                userFAC = UserBL.SearchByName(user);
                if (userFAC == null)
                {
                    return "Utilisateur inconnu.";
                }
                else if (userFAC.username == user.username && userFAC.password == user.password && userFAC.status == USER_STATUS_NOK)
                {
                    userFAC.status = USER_STATUS_OK;
                    UserBL.Update(userFAC);
                    return "Ok";
                }
                else if (userFAC.status == USER_STATUS_OK)
                {
                    return "Utilisateur déjà connecté.";
                }
                else if (userFAC.username == user.username && userFAC.password != user.password)
                {
                    return "Mot de passe erroné";
                }
                else
                {
                    return "Default";
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
                user.status = USER_STATUS_NOK;
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
    }
}
