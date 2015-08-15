using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageBO
{
    /*
     * Classe ManageVillage, déclarations variables avec getter et setter et constructeurs
     */

    [DataContract(Namespace = "urn:ChristmasVillageBO.ManageBO")]
    public class ManageVillageBO
    {
        private int _id_user;
        private int _id_village;

        public ManageVillageBO() {}

        public ManageVillageBO(int ManageUserId, int ManageVillageId) : this()
        {
            _id_user = ManageUserId;
            _id_village = ManageVillageId;
        }

        [DataMember(Name = "id_user")]
        public int id_user
        {
            get { return _id_user; }
            set { _id_user = value; }
        }

        [DataMember(Name = "id_village")]
        public int id_village
        {
            get { return _id_village; }
            set { _id_village = value; }
        }
    }
}
