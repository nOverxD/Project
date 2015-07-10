using ChristmasVillageBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    [ServiceContract(Namespace = "urn:ChristmanVillageIFAC/UserIFAC")]
    public interface UserIFAC
    {
        [OperationContract]
        void createUser(UserBO user);

        [OperationContract]
        void connexion(UserBO user);

        [OperationContract]
        void disconnect(UserBO user);

        [OperationContract]
        void updateUser(UserBO user);
        
        [OperationContract]
        Boolean checkCapital(int capital);

        [OperationContract]
        Boolean checkConnexion();
    }
}
