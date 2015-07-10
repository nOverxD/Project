using ChristmasVillageBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    [ServiceContract(Namespace = "urn:ChristmanVillageIFAC/ManageIFAC")]
    public interface ManageVillageIFAC
    {
        [OperationContract]
        List<FactoryBO> findVillageByUser(int id_User);
    }
}
