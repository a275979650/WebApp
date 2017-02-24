using System.Data.Common;

namespace Web.IDAL
{
    public interface IDbSession
    {
        IDAL.IRoleRepository RoleRepository { get; }
        IDAL.IUserInfoRepository UserInfoRepository { get; }
        int SaveChanges();
        int ExcuteSql(string strSql, DbParameter[] parameters);
    }
}