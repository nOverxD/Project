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
                VillageBL.Insert(userFAC.id_user);
            }
            catch (Exception)
            {                
                throw;
            }
            throw new NotImplementedException();
        }

        public UserBO connexion(UserBO user)
        {
            try
            {
                userFAC = UserBL.SearchByName(user);
                return userFAC;
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
                user.status = false;
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

        public Boolean checkCapital(int capital)
        {
            try
            {
                return UserBL.checkCapital(capital);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public Boolean checkConnexion()
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

        public Boolean checkUniqueUsername(UserBO user)
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
