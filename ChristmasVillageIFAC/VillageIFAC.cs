using ChristmasVillageBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    [ServiceContract(Namespace = "urn:ChristmanVillageIFAC/VillageIFAC")]
    public interface VillageIFAC
    {
        [OperationContract]
        void createVillage(VillageBO village);

        [OperationContract]
        Boolean checkEmptyLocation(VillageBO village);

        [OperationContract]
        void addLocation(VillageBO village);

        [OperationContract]
        void deleteLocation(VillageBO village);
    }
}
