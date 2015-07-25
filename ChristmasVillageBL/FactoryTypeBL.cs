using ChristmasVillageBO;
using ChristmasVillageDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageBL
{
    public class FactoryTypeBL
    {
        public static List<FactoryTypeBO> selectAll ()
        {
            try
            {
                List<FactoryTypeBO> listFactories = new List<FactoryTypeBO>();
                FactoryTypeDAL dal = new FactoryTypeDAL(CUtil.GetConnexion());
                listFactories = dal.FactoryTypeBO_SelectAll().ToList();
                return listFactories;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
