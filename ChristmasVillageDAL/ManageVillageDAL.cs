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
    public class ManageVillageDAL : DataContext
    {
        private static MappingSource mappingSource = new AttributeMappingSource();

        public ManageVillageDAL(string connection) : base(connection, mappingSource) { }

        [Function(Name = "[dbo].[ManageFactory.Insert]")]
        public ISingleResult<ManageVillageBO> ManageVillageBO_Insert(
            [Parameter(Name = "@id_user", DbType = "int")] int UserId,
            [Parameter(Name = "@id_village", DbType = "int")] int VillageId
            )
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)MethodBase.GetCurrentMethod()), UserId, VillageId);
            return ((ISingleResult<ManageVillageBO>)result.ReturnValue);
        }

        [Function(Name = "[dbo].[ManageFactory.FindByUserId]")]
        public ISingleResult<ManageVillageBO> ManageVillageBO_FindByUserId(
            [Parameter(Name = "@id_user", DbType = "int")] int UserId)
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)(MethodBase.GetCurrentMethod())), UserId);
            return ((ISingleResult<ManageVillageBO>)(result.ReturnValue));
        }
    }
}
