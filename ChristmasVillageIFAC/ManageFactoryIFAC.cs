using ChristmasVillageBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    [ServiceContract(Namespace = "urn:ChristmanVillageIFAC/ManageFactoryIFAC")]
    public interface ManageFactoryIFAC
    {
        [OperationContract]
        void createManageFactory(ManageFactoryBO village);

        [OperationContract]
        List<ManageFactoryBO> findFacotyByVillage(int id_Village);
    }
}
