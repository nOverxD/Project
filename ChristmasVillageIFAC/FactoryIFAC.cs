using ChristmasVillageBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    [ServiceContract(Namespace = "urn:ChristmanVillageIFAC/FactoryIFAC")]
    public interface FactoryIFAC
    {
        [OperationContract]
        void createFactory(FactoryBO factory);

        [OperationContract]
        void deleteFactory(int id_Factory);

        [OperationContract]
        FactoryBO findFactory(int id_factory);

        [OperationContract]
        void productToys(FactoryBO factory);

        [OperationContract]
        void salesProduct(FactoryBO factory);

        [OperationContract]
        Boolean checkStatus(FactoryBO factory);

        [OperationContract]
        int productionResult(FactoryBO factory);
    }
}
