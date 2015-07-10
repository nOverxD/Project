using ChristmasVillageBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    [ServiceContract(Namespace = "urn:ChristmanVillageIFAC/OwnIFAC")]
    public interface ManageFactoryIFAC
    {
        [OperationContract]
        List<FactoryBO> listFactories(int id_Village);
    }
}
