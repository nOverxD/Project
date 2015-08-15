using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageBO
{
    /*
     * Classe ManageFactory, déclarations variables avec getter et setter et constructeurs
     */

    [DataContract(Namespace = "urn:ChristmasVillageBO.OwnBO")]
    public class ManageFactoryBO
    {
        private int _id_own;
        private int _id_village;
        private int _id_factory;

        public ManageFactoryBO() {}

        public ManageFactoryBO(int OwnId, int OwnVillageId, int OwnFactoryId)
            : this()
        {
            _id_own = OwnId;
            _id_village = OwnVillageId;
            _id_factory = OwnFactoryId;
        }

        [DataMember(Name = "id_own")]
        public int id_own
        {
            get { return _id_own; }
            set { _id_own = value; }
        }

        [DataMember(Name = "id_village")]
        public int id_village
        {
            get { return _id_village; }
            set { _id_village = value; }
        }

        [DataMember(Name = "id_factory")]
        public int id_factory
        {
            get { return _id_factory; }
            set { _id_factory = value; }
        }
    }
}
