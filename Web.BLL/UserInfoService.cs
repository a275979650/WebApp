using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.DAL;
using Web.IBLL;
using Web.Model;
using Web.IDAL;


namespace Web.BLL
{
    public class UserInfoService:BaseService<UserInfo>,IUserInfoService
    {

 
        //private IUserInfoRepository _userInfoRepository = RepositoryFactory.UserInfoRepository;
        //public UserInfo AddUserInfo(UserInfo userInfo)

        //{

        //    return _userInfoRepository.AddEntity(userInfo);

        //}


        //public bool UpdateUserInfo(UserInfo userInfo)

        //{

        //    return _userInfoRepository.UpdateEntity(userInfo);

        //}
        public override void SetCurrentRepository()
        {
            CurrentRepository = DAL.RepositoryFactory.UserInfoRepository;
        }
    }
}
