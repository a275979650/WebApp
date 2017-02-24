using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.IBLL;
using Web.Model;

namespace Web.BLL
{
    public class RoleService:BaseService<Role>,IRoleService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DAL.RepositoryFactory.ReloRepository;
        }
    }
}
