using System.Data.Common;
using Web.IDAL;

namespace Web.DAL
{
    /// <summary>
    /// 存储过程
    /// </summary>
    public partial class DbSession:IDbSession
    {
        //public IDAL.IRoleRepository RoleRepository { get; } = new RoleRepository();
        //public IDAL.IUserInfoRepository UserInfoRepository { get;} = new UserInfoRepository();

        public int SaveChanges() => DAL.EFContextFactory.GetCurrentDbContext().SaveChanges();
        public int ExcuteSql(string strSql, DbParameter[] parameters)
        {
            //return DAL.EFContextFactory.GetCurrentDbContext().ExecuteFunction(strSql, parameters);
            throw new System.NotImplementedException();
        }
    }
}