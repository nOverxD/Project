using ChristmasVillageBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    /*
     * Déclaration Interface des méthode pour Village
     */

    [ServiceContract(Namespace = "urn:ChristmasVillageIFAC/VillageIFAC")]
    public interface VillageIFAC
    {
        [OperationContract]
        void createVillage(VillageBO village);

        [OperationContract]
        void updateLocation(VillageBO village);

        [OperationContract]
        VillageBO findVillage(string villageName);
    }
}
