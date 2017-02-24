using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.IDAL;

namespace Web.DAL
{
    public static class RepositoryFactory
    {
        public static IUserInfoRepository UserInfoRepository { get; } = new UserInfoRepository();

        public static IRoleRepository ReloRepository { get; } = new RoleRepository();
    }
}
