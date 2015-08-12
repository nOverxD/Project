using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    [ServiceContract(Namespace = "urn:ChristmasVillageIFAC/UtilitiesIFAC")]
    public interface UtilitiesIFAC
    {
        [OperationContract]
        bool checkCapital(int userCapital);

        [OperationContract]
        bool checkEmptyLocation(int locations);

        [OperationContract]
        int getRandomNumber();
    }
}
