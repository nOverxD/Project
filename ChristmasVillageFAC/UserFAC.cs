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
                return UserBL.SearchByName(user);
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

        public bool checkCapital(int capital)
        {
            try
            {
                U
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool checkConnexion()
        {
            throw new NotImplementedException();
        }

        public bool checkUniqueUsername(UserBO user)
        {
            throw new NotImplementedException();
        }
    }
}
