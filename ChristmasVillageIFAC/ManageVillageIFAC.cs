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
     * Déclaration Interface des méthode pour ManageVillage
     */

    [ServiceContract(Namespace = "urn:ChristmasVillageIFAC/ManageVillageIFAC")]
    public interface ManageVillageIFAC
    {
        [OperationContract]
        void createManageVillage(ManageVillageBO village);

        [OperationContract]
        ManageVillageBO findVillageByUser(int id_User);
    }
}
