//引进TT模板的命名空间

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.IDAL;

namespace Web.DAL
{
    //一次跟数据库交互的会话
    public partial class DbSession : IDbSession //代表应用程序跟数据库之间的一次会话，也是数据库访问层的统一入口
    {
        //在这里需要一个for循环来遍历数据库中所有的表放置在下面即可，这样就实现了所有的表对应的仓储显示出来了。
        public IDAL.IRoleRepository RoleRepository
        {
            get { return new RoleRepository(); }
        }

        public IDAL.IUserInfoRepository UserInfoRepository
        {
            get { return new UserInfoRepository(); }
        }
    }
}