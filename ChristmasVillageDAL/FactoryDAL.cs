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
    public class FactoryDAL : DataContext
    {
        private static MappingSource mappingSource = new AttributeMappingSource();

        public FactoryDAL(string connection) : base(connection, mappingSource) { }

        [Function(Name = "[dbo].[Factory.Insert]")]
        public ISingleResult<FactoryBO> FactoryBO_Insert(
            [Parameter(Name = "@type", DbType = "int")] int FactoryType,
            [Parameter(Name = "@factory_stock", DbType = "int")] int FactoryStock,
            [Parameter(Name = "@factory_location", DbType = "int")] int FactoryLocation,
            [Parameter(Name = "@toy_production_time", DbType = "datetime")] Nullable<System.DateTime> FactoryToyProductionTime,
            [Parameter(Name = "@toy_current_production", DbType = "int")] int FactoryToyCurrentProduction,
            [Parameter(Name = "@status", DbType = "varchar(5)")] string FactoryStatus
            )
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)MethodBase.GetCurrentMethod()),
                FactoryType, FactoryStock, FactoryLocation, FactoryToyProductionTime, FactoryToyCurrentProduction, FactoryStatus);
            return ((ISingleResult<FactoryBO>)result.ReturnValue);
        }

        [Function(Name = "[dbo].[Factory.Update]")]
        public ISingleResult<FactoryBO> FactoryBO_Update(
            [Parameter(Name = "@id_factory", DbType = "int")] int FactoryId,
            [Parameter(Name = "@type", DbType = "int")] int FactoryType,
            [Parameter(Name = "@factory_stock", DbType = "int")] int FactoryStock,
            [Parameter(Name = "@factory_location", DbType = "int")] int FactoryLocation,
            [Parameter(Name = "@toy_production_time", DbType = "datetime")] Nullable<System.DateTime> FactoryToyProductionTime,
            [Parameter(Name = "@toy_current_production", DbType = "int")] int FactoryToyCurrentProduction,
            [Parameter(Name = "@status", DbType = "varchar(5)")] string FactoryStatus
            )
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)MethodBase.GetCurrentMethod()),
                FactoryId, FactoryType, FactoryStock, FactoryLocation, FactoryToyProductionTime, FactoryToyCurrentProduction, FactoryStatus);
            return ((ISingleResult<FactoryBO>)result.ReturnValue);
        }

        [Function(Name = "[dbo].[Factory.Delete]")]
        public ISingleResult<FactoryBO> FactoryBO_Delete(
            [Parameter(Name = "@id_factory", DbType = "int")] int FactoryId)
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)(MethodBase.GetCurrentMethod())), FactoryId);
            return ((ISingleResult<FactoryBO>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Factory.FindById]")]
        public ISingleResult<FactoryBO> FactoryBO_FindById(
            [Parameter(Name = "@id_factory", DbType = "int")] int FactoryId)
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)(MethodBase.GetCurrentMethod())), FactoryId);
            return ((ISingleResult<FactoryBO>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Factory.FindLast]")]
        public ISingleResult<FactoryBO> FactoryBO_FindLast()
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)(MethodBase.GetCurrentMethod())));
            return ((ISingleResult<FactoryBO>)(result.ReturnValue));
        }
    }
}
