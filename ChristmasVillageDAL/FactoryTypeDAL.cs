using ChristmasVillageBO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageDAL
{
    /*
     * FactoryType : Déclaration des statements (stored procédures Database)
     */

    public class FactoryTypeDAL : DataContext
    {
        private static MappingSource mappingSource = new AttributeMappingSource();

        public FactoryTypeDAL(string connection) : base(connection, mappingSource) { }

        [Function(Name = "[dbo].[FactoryType.SelectAll]")]
        public ISingleResult<FactoryTypeBO> FactoryTypeBO_SelectAll()
        {
            IExecuteResult result = ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
            return ((ISingleResult<FactoryTypeBO>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[FactoryType.FindById]")]
        public ISingleResult<FactoryTypeBO> FactoryTypeBO_FindById(
            [Parameter(Name = "@id_factory_type", DbType = "int")] int FactoryTypeId)
        {
            IExecuteResult result = ExecuteMethodCall(this, ((MethodInfo)(MethodBase.GetCurrentMethod())), FactoryTypeId);
            return ((ISingleResult<FactoryTypeBO>)(result.ReturnValue));
        }
    }
}
