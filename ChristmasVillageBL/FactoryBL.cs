using ChristmasVillageBO;
using ChristmasVillageDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    public class FactoryBL
    {
        // Méthode Insert Factory
        public static FactoryBO Insert(FactoryBO factory)
        {
            try
            {
                FactoryDAL dal = new FactoryDAL(CUtil.GetConnexion());
                dal.FactoryBO_Insert(
                    factory.type,
                    factory.factory_stock,
                    factory.factory_location,
                    factory.toy_production_time,
                    factory.toy_current_production,
                    factory.status
                    );
                return factory;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        // Méthode Update Factory
        public static void Update(FactoryBO factory)
        {
            try
            {
                FactoryDAL dal = new FactoryDAL(CUtil.GetConnexion());
                dal.FactoryBO_Update(
                    factory.id_factory,
                    factory.type,
                    factory.factory_stock,
                    factory.factory_location,
                    factory.toy_production_time,
                    factory.toy_current_production,
                    factory.status
                    );
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Méthode Delete Factory
        public static void Delete(int id_factory)
        {
            try
            {
                FactoryDAL dal = new FactoryDAL(CUtil.GetConnexion());
                dal.FactoryBO_Delete(id_factory);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        // Méthode retourne la Factory en fonction de ID Factory
        public static FactoryBO SearchById(int id_factory)
        {
            try
            {
                List<FactoryBO> listResult = new List<FactoryBO>();
                FactoryBO result = new FactoryBO();
                FactoryDAL dal = new FactoryDAL(CUtil.GetConnexion());
                
                listResult = dal.FactoryBO_FindById(id_factory).ToList();
                result = listResult.FirstOrDefault();
                return result;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        // Méthode qui retourne la dernière Factory créée
        public static FactoryBO FindLast()
        {
            try
            {
                FactoryBO result = new FactoryBO();
                FactoryDAL dal = new FactoryDAL(CUtil.GetConnexion());
                result = dal.FactoryBO_FindLast().FirstOrDefault();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Methode qui retourne un bool en fonctione du status Factory
        public static bool CheckStatus(FactoryBO factory)
        {
            try
            {
                List<FactoryBO> listResult = new List<FactoryBO>();
                FactoryBO result = new FactoryBO();
                FactoryDAL dal = new FactoryDAL(CUtil.GetConnexion());

                listResult = dal.FactoryBO_FindById(factory.id_factory).ToList();
                result = listResult.FirstOrDefault();

                if (result.status != "true" && result != null)
                {
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
    }
}
