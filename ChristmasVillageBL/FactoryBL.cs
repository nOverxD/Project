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
        public static FactoryBO InsertFactory(FactoryBO factory)
        {
            try
            {
                FactoryDAL dal = new FactoryDAL(CUtil.GetConnexion());
                dal.FactoryBO_Insert(
                    factory.type,
                    factory.factory_stock = 0,
                    factory.factory_price,
                    factory.factory_location,
                    factory.toy_production_price,
                    factory.toy_production_time,
                    factory.toy_sales_price,
                    factory.status
                    );
                return factory;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public static void UpdateFactory(FactoryBO factory)
        {
            try
            {
                FactoryDAL dal = new FactoryDAL(CUtil.GetConnexion());
                dal.FactoryBO_Update(
                    factory.id_factory,
                    factory.type,
                    factory.factory_stock,
                    factory.factory_price,
                    factory.factory_location,
                    factory.toy_production_price,
                    factory.toy_production_time,
                    factory.toy_sales_price,
                    factory.status
                    );
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void DeleteFactory(int id_factory)
        {
            try
            {
                FactoryDAL dal = new FactoryDAL(CUtil.GetConnexion());
                if (CUtil.checkCapital)
                {
                    
                }
                dal.FactoryBO_Delete(id_factory);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public static FactoryBO SearchFactory(int id_factory)
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

        public static void ProductToysFactory(FactoryBO factory)
        {
            try
            {
                FactoryBO newFactory = factory;

                // Check Math for random number
                int randomNumber = 0;
                DateTime currentTime = DateTime.Now;
                

                newFactory.toy_current_production = randomNumber;
                newFactory.toy_production_time = currentTime;
                newFactory.status = true;

                FactoryDAL dal = new FactoryDAL(CUtil.GetConnexion());
                dal.FactoryBO_Update(
                        newFactory.id_factory,
                        newFactory.type,
                        newFactory.factory_stock,
                        newFactory.factory_price,
                        newFactory.factory_location,
                        newFactory.toy_production_price,
                        newFactory.toy_production_time,
                        newFactory.toy_sales_price,
                        newFactory.status
                        );
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        
        public static void SalesProductFactory(FactoryBO factory)
        {
            try
            {
                FactoryDAL dalFactory = new FactoryDAL(CUtil.GetConnexion());
                FactoryBO newFactory = (FactoryBO) dalFactory.FactoryBO_FindById(factory.id_factory);
                int sales = newFactory.factory_stock * newFactory.toy_production_price;
                int reset = 0;
                newFactory.factory_stock = reset;

                //Update Capital User 
                UserDAL dalUser = new UserDAL(CUtil.GetConnexion());
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public static bool CheckStatusFactory(FactoryBO factory)
        {
            try
            {
                FactoryBO factoryResult = new FactoryBO();
                FactoryDAL dal = new FactoryDAL(CUtil.GetConnexion());
                factoryResult = (FactoryBO)dal.FactoryBO_FindById(factory.id_factory);

                if (factoryResult.status != true && factoryResult != null)
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

        public static int productionResultFactory(FactoryBO factory)
        {
            try
            {
                FactoryDAL dal = new FactoryDAL(CUtil.GetConnexion());
                FactoryBO newFactory = new FactoryBO();
                newFactory = (FactoryBO)dal.FactoryBO_FindById(factory.id_factory);
                int productionResult = newFactory.toy_current_production;
                return productionResult;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
