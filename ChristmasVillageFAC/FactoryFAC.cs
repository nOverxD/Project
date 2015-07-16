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
                FactoryBL.InsertFactory(factory);
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
                FactoryBL.DeleteFactory(id_Factory);
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
                factoryFAC = FactoryBL.SearchFactory(id_factory);
                return factoryFAC;
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
                FactoryBL.UpdateFactory(factory);
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
                FactoryBL.UpdateFactory(factory);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public Boolean checkStatus(FactoryBO factory)
        {
            try
            {
                return FactoryBL.CheckStatusFactory(factory);
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
                return FactoryBL.productionResultFactory(factory);
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}
