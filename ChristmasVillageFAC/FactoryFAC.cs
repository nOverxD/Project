using ChristmasVillageBL;
using ChristmasVillageBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    public class FactoryFAC : FactoryIFAC
    {
        // Implémentation méthode createFactory Interface Factory
        public void createFactory(FactoryBO factory)
        {
            try
            {
                FactoryBL.Insert(factory);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        // Implémentation méthode updateFactory Interface Factory
        public void updateFactory(FactoryBO factory)
        {
            try
            {
                FactoryBL.Update(factory);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Implémentation méthode getLastFactory Interface Factory
        public FactoryBO getLastFactory()
        {
            try
            {
                return FactoryBL.FindLast();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Implémentation méthode deleteFactory Interface Factory
        public void deleteFactory(int id_Factory)
        {
            try
            {
                FactoryBL.Delete(id_Factory);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        // Implémentation méthode findFactory Interface Factory
        public FactoryBO findFactory(int id_factory)
        {
            try
            {
                return FactoryBL.SearchById(id_factory);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        // Implémentation méthode productToys Interface Factory
        public void productToys(FactoryBO factory, UserBO user)
        {
            try
            {
                // Recherche FactoryType en fonction de Factory
                FactoryTypeBO factoryType = new FactoryTypeBO();
                factoryType = FactoryTypeBL.FindById(factory.type);

                // Update du capital en fonction des info FactoryType
                int newCapital = user.capital - factoryType.toy_production_price;
                user.capital = newCapital;
                UserBL.Update(user);

                // Update du status Factory
                factory.status = "true";
                FactoryBL.Update(factory);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Implémentation méthode salesProduct Interface Factory
        public void salesProduct(FactoryBO factory, UserBO user)
        {
            try
            {
                // Recherche FactoryType en fonction de Factory
                FactoryTypeBO factoryType = new FactoryTypeBO();
                factoryType = FactoryTypeBL.FindById(factory.type);

                // Update du capital en fonction des info FactoryType et du stock
                int newCapital = user.capital + factory.factory_stock * factoryType.toy_sales_prices;
                user.capital = newCapital;
                UserBL.Update(user);

                // Remise à zéro du stock
                factory.factory_stock = 0;
                FactoryBL.Update(factory);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        // Implémentation méthode checkStatus Interface Factory
        public bool checkStatus(FactoryBO factory)
        {
            try
            {
                return FactoryBL.CheckStatus(factory);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
