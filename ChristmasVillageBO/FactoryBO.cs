using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageBO
{
    /*
     * Classe Factory, déclarations variables avec getter et setter et constructeurs
     */

    [DataContract(Namespace = "urn:ChristmasVillageBO.FactoryBO")]
    public class FactoryBO
    {
        private int _id_factory;
        private int _type;
        private int _factory_stock;
        private int _factory_location;
        private Nullable<System.DateTime> _toy_production_time;
        private int _toy_current_production;
        private string _status;

        public FactoryBO() {}

        public FactoryBO(int FactoryType, int FactoryStock, int FactoryLocation, Nullable<System.DateTime> FactoryToyProductionTime, int FactoryToyCurrentProduction, string FactoryStatus)
            : this()
        {
            _type = FactoryType;
            _factory_stock = FactoryStock;
            _factory_location = FactoryLocation;
            _toy_production_time = FactoryToyProductionTime;
            _toy_current_production = FactoryToyCurrentProduction;
            _status = FactoryStatus;
        }

        [DataMember(Name = "id_factory")]
        public int id_factory
        {
            get { return _id_factory; }
            set { _id_factory = value; }
        }

        [DataMember(Name = "type")]
        public int type
        {
            get { return _type; }
            set { _type = value; }
        }

        [DataMember(Name = "factory_stock")]
        public int factory_stock
        {
            get { return _factory_stock; }
            set { _factory_stock = value; }
        }

        [DataMember(Name = "factory_location")]
        public int factory_location
        {
            get { return _factory_location; }
            set { _factory_location = value; }
        }

        [DataMember(Name = "toy_production_time")]
        public Nullable<System.DateTime> toy_production_time
        {
            get { return _toy_production_time; }
            set { _toy_production_time = value; }
        }

        [DataMember(Name = "toy_current_production")]
        public int toy_current_production
        {
            get { return _toy_current_production; }
            set { _toy_current_production = value; }
        }

        [DataMember(Name = "status")]
        public string status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
