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
        /*
         * Déclaration des variables privées locales
         */
        private UserBO userFAC;
        private String USER_STATUS_OK = "true";
        private String USER_STATUS_NOK = "false";

        // Implémentation méthode createUser Interface User
        public void createUser(UserBO user)
        {
            try
            {
                user.status = USER_STATUS_NOK;
                UserBL.Insert(user);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        // Implémentation méthode checkUniqueUsername Interface User
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

        // Implémentation méthode searchUser Interface User
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

        // Implémentation méthode findById Interface User
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

        // Implémentation méthode connexion Interface User
        public String connexion(UserBO user)
        {
            try
            {
                /*
                 * Retourne un String en fonction de recherche de l'User
                 * Si null: Retourne "Utilisateur inconnu."
                 * Si Username et password correspondent: Retourne "Ok"
                 * Si status user == "true": Retourne "Utilisateur déjà connecté."
                 * Si username OK, mais pas password: Retourne "Mot de passe erroné"
                 */
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

        // Implémentation méthode disconnect Interface User
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

        // Implémentation méthode updateUser Interface User
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

        // Implémentation méthode checkConnexion Interface User
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
