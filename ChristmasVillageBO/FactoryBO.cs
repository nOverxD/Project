using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageBO
{
    [DataContract(Namespace = "urn:ChristmasVillageBO.FactoryBO")]
    public class FactoryBO
    {
        private int _id_factory;
        private string _type;
        private int _factory_stock;
        private int _factory_price;
        private int _factory_location;
        private int _toy_production_price;
        private int _toy_current_production;
        private DateTime _toy_production_time;
        private int _toy_sales_price;
        private Boolean _status;

        public FactoryBO() {}

        public FactoryBO(string FactoryName, int FactoryStock, int FactoryPrice, int FactoryLocation, int FactoryToyProductionPrice, int FactoryToyCurrentProduction, DateTime FactoryToyProductionTime, int FactoryToySalesPrice, Boolean FactoryStatus) : this()
        {
            _type = FactoryName;
            _factory_stock = FactoryStock;
            _factory_price = FactoryPrice;
            _factory_location = FactoryLocation;
            _toy_production_price = FactoryToyProductionPrice;
            _toy_current_production = FactoryToyCurrentProduction;
            _toy_production_time = FactoryToyProductionTime;
            _toy_sales_price = FactoryToySalesPrice;
            _status = FactoryStatus;
        }

        [DataMember(Name = "id_factory")]
        public int id_factory
        {
            get { return _id_factory; }
            set { _id_factory = value; }
        }

        [DataMember(Name = "type")]
        public string type
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

        [DataMember(Name = "factory_price")]
        public int factory_price
        {
            get { return _factory_price; }
            set { _factory_price = value; }
        }

        [DataMember(Name = "factory_location")]
        public int factory_location
        {
            get { return _factory_location; }
            set { _factory_location = value; }
        }

        [DataMember(Name = "toy_production_price")]
        public int toy_production_price
        {
            get { return _toy_production_price; }
            set { _toy_production_price = value; }
        }

        [DataMember(Name = "toy_current_production")]
        public int toy_current_production
        {
            get { return _toy_current_production; }
            set { _toy_current_production = value; }
        }

        [DataMember(Name = "toy_production_time")]
        public DateTime toy_production_time
        {
            get { return _toy_production_time; }
            set { _toy_production_time = value; }
        }

        [DataMember(Name = "toy_sales_price")]
        public int toy_sales_price
        {
            get { return _toy_sales_price; }
            set { _toy_sales_price = value; }
        }

        [DataMember(Name = "status")]
        public Boolean status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
