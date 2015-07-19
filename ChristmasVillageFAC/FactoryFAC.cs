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
        private FactoryBO factoryFAC = new FactoryBO();

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

        public FactoryBO findFactory(int id_factory)
        {
            try
            {
                return FactoryBL.Search(id_factory);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public void productToys(FactoryBO factory)
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

        public void salesProduct(FactoryBO factory)
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

        public int productionResult(FactoryBO factory)
        {
            try
            {
                return FactoryBL.productionResult(factory);
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}
