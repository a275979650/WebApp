using Web.Model;
namespace Web.IBLL
{
    public interface IUserInfoService:IBaseService<UserInfo>
    {
        UserInfo CheckUserInfo(UserInfo userInfo);
    }
}