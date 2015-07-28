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

        public void createUser(UserBO user)
        {
            try
            {
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

        public bool connexion(UserBO user)
        {
            try
            {
                userFAC = new UserBO();
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
    }
}
