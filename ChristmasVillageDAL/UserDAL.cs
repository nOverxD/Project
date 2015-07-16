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
    public class UserDAL : DataContext
    {
        private static MappingSource mappingSource = new AttributeMappingSource();

        public UserDAL(string connection) : base(connection, mappingSource) { }

        [Function(Name = "[dbo].[User.Insert]")]
        public ISingleResult<UserBO> UserBO_Insert(
            [Parameter(Name = "@username", DbType = "varchar(10)")] string Username,
            [Parameter(Name = "@password", DbType = "varchar(10)")] string UserPassword,
            [Parameter(Name = "@email", DbType = "varchar(10)")] string UserMail,
            [Parameter(Name = "@capital", DbType = "int")] int UserCapital,
            [Parameter(Name = "@connexion", DbType = "int")] int UserConnexion,
            [Parameter(Name = "@status", DbType = "varchar(5)")] string UserStatus
             )
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)MethodBase.GetCurrentMethod()),
                Username, UserPassword, UserMail, UserCapital, UserConnexion, UserStatus);
            return ((ISingleResult<UserBO>)result.ReturnValue);
        }

        [Function(Name = "[dbo].[User.Update]")]
        public ISingleResult<FactoryBO> UserBO_Update(
            [Parameter(Name = "@id_user", DbType = "int")] int UserId,
            [Parameter(Name = "@username", DbType = "varchar(10)")] string Username,
            [Parameter(Name = "@password", DbType = "varchar(10)")] string UserPassword,
            [Parameter(Name = "@email", DbType = "varchar(10)")] string UserMail,
            [Parameter(Name = "@capital", DbType = "int")] int UserCapital,
            [Parameter(Name = "@connexion", DbType = "int")] int UserConnexion,
            [Parameter(Name = "@status", DbType = "varchar(5)")] string UserStatus
            )
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)MethodBase.GetCurrentMethod()),
                UserId, Username, UserPassword, UserMail, UserCapital, UserConnexion, UserStatus);
            return ((ISingleResult<FactoryBO>)result.ReturnValue);
        }

        [Function(Name = "[dbo].[User.FindById]")]
        public ISingleResult<FactoryBO> UserBO_FindById(
            [Parameter(Name = "@id_user", DbType = "int")] int UserId)
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)(MethodBase.GetCurrentMethod())), UserId);
            return ((ISingleResult<FactoryBO>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[User.FindByName]")]
        public ISingleResult<FactoryBO> UserBO_FindByName(
            [Parameter(Name = "@name", DbType = "varchar(10)")] string Username)
        {
            var result = ExecuteMethodCall(this, ((MethodInfo)(MethodBase.GetCurrentMethod())), Username);
            return ((ISingleResult<FactoryBO>)(result.ReturnValue));
        }
    }
}
