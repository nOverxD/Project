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
     * Déclaration Interface des méthode pour ManageFactory
     */

    [ServiceContract(Namespace = "urn:ChristmasVillageIFAC/ManageFactoryIFAC")]
    public interface ManageFactoryIFAC
    {
        [OperationContract]
        void createManageFactory(ManageFactoryBO village);

        [OperationContract]
        List<ManageFactoryBO> findFactoryByVillage(int id_Village);

        [OperationContract]
        void deleteManageFactory(int id_factory);
    }
}
