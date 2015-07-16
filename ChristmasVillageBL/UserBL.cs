using ChristmasVillageBO;
using ChristmasVillageDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    public class UserBL
    {
        public static void Insert(UserBO user)
        {
            try
            {
                UserDAL dal = new UserDAL(CUtil.GetConnexion());
                dal.UserBO_Insert(
                    user.username,
                    user.password,
                    user.email,
                    user.capital,
                    user.connexion,
                    user.status
                    );
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public static void Update(UserBO user)
        {
            try
            {
                UserDAL dal = new UserDAL(CUtil.GetConnexion());
                dal.UserBO_Update(
                    user.id_user,
                    user.username,
                    user.password,
                    user.email,
                    user.capital,
                    user.connexion,
                    user.status
                    );
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public static UserBO SearchById(int id_user)
        {
            try
            {
                UserBO user = new UserBO();
                UserDAL dal = new UserDAL(CUtil.GetConnexion());
                user = (UserBO) dal.UserBO_FindById(id_user);
                return user;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public static UserBO SearchByName(UserBO user)
        {
            try
            {
                UserBO result = new UserBO();
                UserDAL dal = new UserDAL(CUtil.GetConnexion());
                result = (UserBO)dal.UserBO_FindByName(user.username);
                return result;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public static Boolean checkUniqueUsername(UserBO user)
        {
            try
            {
                UserBO result = new UserBO();
                UserDAL dal = new UserDAL(CUtil.GetConnexion());
                result = (UserBO)dal.UserBO_FindByName(user.username);
                if (result != null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}
