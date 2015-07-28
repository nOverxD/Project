using ChristmasVillageBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    [ServiceContract(Namespace = "urn:ChristmasVillageIFAC/ManageVillageIFAC")]
    public interface ManageVillageIFAC
    {
        [OperationContract]
        void createManageVillage(ManageVillageBO village);

        [OperationContract]
        ManageVillageBO findVillageByUser(int id_User);
    }
}
