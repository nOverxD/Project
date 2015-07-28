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

        public static FactoryBO Search(int id_factory)
        {
            try
            {
                FactoryBO factory = new FactoryBO();
                FactoryDAL dal = new FactoryDAL(CUtil.GetConnexion());
                factory = (FactoryBO) dal.FactoryBO_FindById(id_factory);
                return factory;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public static bool CheckStatus(FactoryBO factory)
        {
            try
            {
                FactoryBO factoryResult = new FactoryBO();
                FactoryDAL dal = new FactoryDAL(CUtil.GetConnexion());
                factoryResult = (FactoryBO)dal.FactoryBO_FindById(factory.id_factory);

                if (factoryResult.status != "true" && factoryResult != null)
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

        /*
        public static int productionResult(FactoryBO factory)
        {
            try
            {
                FactoryDAL dal = new FactoryDAL(CUtil.GetConnexion());
                FactoryBO newFactory = new FactoryBO();
                newFactory = (FactoryBO)dal.FactoryBO_FindById(factory.id_factory);
                return newFactory.toy_current_production;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public static void ProductToys(FactoryBO factory)
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

        public static void SalesProduct(FactoryBO factory)
        {
            try
            {
                FactoryDAL dalFactory = new FactoryDAL(CUtil.GetConnexion());
                dalFactory.FactoryBO_Update(
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
        */
    }
}
