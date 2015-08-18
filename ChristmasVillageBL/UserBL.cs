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
        // Méthode Insert User
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
                    user.status
                    );
            }
            catch (Exception)
            {                
                throw;
            }
        }

        // Méthode Update User
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
                    user.status
                    );
            }
            catch (Exception)
            {                
                throw;
            }
        }

        // Méthode retourne l' User en fonction de ID User
        public static UserBO SearchById(int id_user)
        {
            try
            {
                List<UserBO> listResult = new List<UserBO>();
                UserBO result = new UserBO();
                UserDAL dal = new UserDAL(CUtil.GetConnexion());

                listResult = dal.UserBO_FindById(id_user).ToList();
                result = listResult.FirstOrDefault();
                return result;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        // Méthode retourne l' User en fonction de Username
        public static UserBO SearchByName(UserBO user)
        {
            try
            {
                List<UserBO> listResult = new List<UserBO>();
                UserBO result = new UserBO();
                UserDAL dal = new UserDAL(CUtil.GetConnexion());

                listResult = dal.UserBO_FindByName(user.username).ToList();
                result = listResult.FirstOrDefault();
                return result;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        // Methode qui retourne un bool si l'username est déjà connu dans la database
        public static bool checkUniqueUsername(UserBO user)
        {
            try
            {
                List<UserBO> listResult = new List<UserBO>();
                UserDAL dal = new UserDAL(CUtil.GetConnexion());

                listResult = dal.UserBO_FindByName(user.username).ToList();
                if (listResult.Count() < 0)
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

        // Méthode qui update le status de tous les user à False
        public static void closeAllAccount()
        {
            try
            {
                UserDAL dal = new UserDAL(CUtil.GetConnexion());
                dal.UserBO_CloseAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
