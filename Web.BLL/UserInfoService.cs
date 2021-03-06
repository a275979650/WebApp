﻿using System;
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
        public override void SetCurrentRepository()
        {
            CurrentRepository = DAL.RepositoryFactory.UserInfoRepository;
        }

        public UserInfo CheckUserInfo(UserInfo userInfo)
        {
            return _DbSession.UserInfoRepository.LoadEntities(u => u.UName == userInfo.UName && u.Pwd == userInfo.Pwd).FirstOrDefault();
        }
    }
}
