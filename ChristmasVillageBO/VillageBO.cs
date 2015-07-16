using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageBO
{
    [DataContract(Namespace = "urn:ChristmasVillageBO.VillageBO")]
    public class VillageBO
    {
        private int _id_village;
        private string _name;
        private int _location;

        public VillageBO() {}

        public VillageBO(int VillageId, string VillageName, int VillageLocation)
            : this()
        {
            _id_village = VillageId;
            _name = VillageName;
            _location = VillageLocation;
        }

        [DataMember(Name = "id_village")]
        public int id_village
        {
            get { return _id_village; }
            set { _id_village = value; }
        }

        [DataMember(Name = "name")]
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember(Name = "location")]
        public int location
        {
            get { return _location; }
            set { _location = value; }
        }
    }
}
