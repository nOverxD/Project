using ChristmasVillageBO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageIFAC
{
    public class ManageFactoryDAL : DataContext
    {
        private static MappingSource mappingSource = new AttributeMappingSource();

        public ManageFactoryDAL(string connection) : base(connection, mappingSource) { }

        [Function(Name = "[dbo].[ManageFactory.Insert]")]
        public ISingleResult<ManageFactoryBO> ManageFactoryBO_Insert(
            [Parameter(Name = "@id_village", DbType = "int")] int VillageId,
            [Parameter(Name = "@id_factory", DbType = "int")] int FactoryId
            )
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)MethodBase.GetCurrentMethod()), VillageId, FactoryId);
            return ((ISingleResult<ManageFactoryBO>)result.ReturnValue);
        }

        [Function(Name = "[dbo].[ManageFactory.Delete]")]
        public ISingleResult<ManageFactoryBO> ManageFactoryBO_Delete(
            [Parameter(Name = "@id_own", DbType = "int")] int ManageFactoryId
            )
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)MethodBase.GetCurrentMethod()), ManageFactoryId);
            return ((ISingleResult<ManageFactoryBO>)result.ReturnValue);
        }

        [Function(Name = "[dbo].[ManageFactory.FindByVillageId]")]
        public ISingleResult<ManageFactoryBO> ManageFactoryBO_FindFactories(
            [Parameter(Name = "@id_village", DbType = "int")] int VillageId)
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), VillageId);
            return ((ISingleResult<ManageFactoryBO>)(result.ReturnValue));
        }
    }
}
