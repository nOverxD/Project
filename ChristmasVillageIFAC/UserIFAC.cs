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
     * Déclaration Interface des méthode pour User
     */

    [ServiceContract(Namespace = "urn:ChristmasVillageIFAC/UserIFAC")]
    public interface UserIFAC
    {
        [OperationContract]
        void createUser(UserBO user);

        [OperationContract]
        bool checkUniqueUsername(UserBO user);

        [OperationContract]
        UserBO searchUser(UserBO user);

        [OperationContract]
        UserBO findById(int id_user);

        [OperationContract]
        String connexion(UserBO user);

        [OperationContract]
        void disconnect(UserBO user);

        [OperationContract]
        void updateUser(UserBO user);
        
        [OperationContract]
        bool checkConnexion();
    }
}
