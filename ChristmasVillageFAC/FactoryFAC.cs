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
        public FactoryBO createFactory(FactoryBO factory)
        {
            FactoryBO result = FactoryBL.InsertFactory(factory);
        }

        public void deleteFactory(int id_Factory)
        {
            FactoryBL.DeleteFactory(id_Factory);

        }

        public FactoryBO findFactory(int id_factory)
        {
            FactoryBL.SearchFactory(id_factory);
        }

        public void productToys(FactoryBO factory)
        {
            FactoryBL.UpdateFactory(factory);
        }

        public void salesProduct(FactoryBO factory)
        {
            FactoryBL.UpdateFactory(factory);
        }

        public bool checkStatus(FactoryBO factory)
        {
            FactoryBL.CheckStatusFactory(factory);
        }

        public int productionResult(FactoryBO factory)
        {
            FactoryBL.UpdateFactory(factory);
        }
    }
}
