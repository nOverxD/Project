using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageBO
{
    [DataContract(Namespace = "urn:ChristmasVillageBO.FactoryTypeBO")]
    public class FactoryTypeBO
    {
        private int _id_factory_type;
        private string _name;
        private int _price;
        private int _toy_production_price;
        private int _toy_sales_price;

        public FactoryTypeBO() {}

        public FactoryTypeBO(int FactoryTypeId, string FactoryName, int FactoryPrice, int FactoryToyProductionPrice, int FactoryToySalesPrice)
            : this()
        {
            _id_factory_type = FactoryTypeId;
            _name = FactoryName;
            _price = FactoryPrice;
            _toy_production_price = FactoryToyProductionPrice;
            _toy_sales_price = FactoryToySalesPrice;
        }

        [DataMember(Name = "id_factory_type")]
        public int factory_type_id
        {
            get { return _id_factory_type; }
            set { _id_factory_type = value; }
        }

        [DataMember(Name = "name")]
        public string factory_name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember(Name = "price")]
        public int factory_price
        {
            get { return _price; }
            set { _price = value; }
        }

        [DataMember(Name = "toy_production_price")]
        public int toy_production_price
        {
            get { return _toy_production_price; }
            set { _toy_production_price = value; }
        }

        [DataMember(Name = "toy_sales_prices")]
        public int toy_sales_price
        {
            get { return _toy_sales_price; }
            set { _toy_sales_price = value; }
        }
    }
}
