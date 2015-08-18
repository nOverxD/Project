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
    /*
     * Village : Déclaration des statements (stored procédures Database)
     */

    public class VillageDAL : DataContext
    {
        private static MappingSource mappingSource = new AttributeMappingSource();

        public VillageDAL(string connection) : base(connection, mappingSource) { }

        [Function(Name = "[dbo].[Village.Insert]")]
        public ISingleResult<VillageBO> VillageBO_Insert(
            [Parameter(Name = "@name", DbType = "varchar(20)")] string VillageName)
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)MethodBase.GetCurrentMethod()), VillageName);
            return ((ISingleResult<VillageBO>)result.ReturnValue);
        }

        [Function(Name = "[dbo].[Village.Search]")]
        public ISingleResult<VillageBO> VillageBO_Search(
            [Parameter(Name = "@village_name", DbType = "varchar(20)")] string VillageName
            )
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)MethodBase.GetCurrentMethod()), VillageName);
            return ((ISingleResult<VillageBO>)result.ReturnValue);
        }

        [Function(Name = "[dbo].[Village.FindById]")]
        public ISingleResult<VillageBO> VillageBO_Search(
            [Parameter(Name = "@id_village", DbType = "int")] int VillageId
            )
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)MethodBase.GetCurrentMethod()), VillageId);
            return ((ISingleResult<VillageBO>)result.ReturnValue);
        }
    }
}
