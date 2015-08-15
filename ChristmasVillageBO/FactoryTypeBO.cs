using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageBO
{
    /*
     * Classe FactoryType, déclarations variables avec getter et setter et constructeurs
     */

    [DataContract(Namespace = "urn:ChristmasVillageBO.FactoryTypeBO")]
    public class FactoryTypeBO
    {
        private int _id_factory_type;
        private string _name;
        private int _price;
        private int _toy_production_price;
        private int _toy_sales_prices;

        public FactoryTypeBO() {}

        public FactoryTypeBO(int FactoryTypeId, string FactoryName, int FactoryPrice, int FactoryToyProductionPrice, int FactoryToySalesPrice)
            : this()
        {
            _id_factory_type = FactoryTypeId;
            _name = FactoryName;
            _price = FactoryPrice;
            _toy_production_price = FactoryToyProductionPrice;
            _toy_sales_prices = FactoryToySalesPrice;
        }

        [DataMember(Name = "id_factory_type")]
        public int id_factory_type
        {
            get { return _id_factory_type; }
            set { _id_factory_type = value; }
        }

        [DataMember(Name = "name")]
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember(Name = "price")]
        public int price
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
        public int toy_sales_prices
        {
            get { return _toy_sales_prices; }
            set { _toy_sales_prices = value; }
        }
    }
}
