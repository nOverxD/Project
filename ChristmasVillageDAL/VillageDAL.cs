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
    public class VillageDAL : DataContext
    {
        private static MappingSource mappingSource = new AttributeMappingSource();

        public VillageDAL(string connection) : base(connection, mappingSource) { }

        [Function(Name = "[dbo].[Village.Insert]")]
        public ISingleResult<VillageBO> VillageBO_Insert(
            [Parameter(Name = "@name", DbType = "varchar(10)")] string VillageName,
            [Parameter(Name = "@location", DbType = "int")] int VillageLocations
            )
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)MethodBase.GetCurrentMethod()), VillageName, VillageLocations);
            return ((ISingleResult<VillageBO>)result.ReturnValue);
        }

        [Function(Name = "[dbo].[Village.Update]")]
        public ISingleResult<VillageBO> VillageBO_Update(
            [Parameter(Name = "@id_village", DbType = "int")] int VillageId,
            [Parameter(Name = "@name", DbType = "varchar(10)")] string VillageName,
            [Parameter(Name = "@location", DbType = "int")] int VillageLocations
            )
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)MethodBase.GetCurrentMethod()), VillageId, VillageName, VillageLocations);
            return ((ISingleResult<VillageBO>)result.ReturnValue);
        }
    }
}
