using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.BLL;
using Web.Common;
using Web.IBLL;
using Web.Model;

namespace WebApp.UI.Controllers
{
    public class LoginController : Controller
    {
        private IUserInfoService _userInfoService = new UserInfoService();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>

        /// 验证码的实现

        /// </summary>

        /// <returns></returns>

        public ActionResult CheckCode()

        {

            //首先实例化验证码的类

            KenceryValidateCode validateCode = new KenceryValidateCode();

            //生成验证码指定的长度

            string code = validateCode.CreateValidateCode(5);

            //将验证码赋值给Session变量

            Session["ValidateCode"] = code;

            //创建验证码的图片

            byte[] bytes = validateCode.CreateValidateGraphic(code);

            //最后将验证码返回

            return File(bytes, @"image/jpeg");

        }
        //判断用户输入的信息是否正确

        [HttpPost]

        public ActionResult CheckUserInfo(UserInfo userInfo, string Code)

        {

            //首先我们拿到系统的验证码

            string sessionCode = this.Session["ValidateCode"] == null

                                     ? new Guid().ToString()

                                     : this.Session["ValidateCode"].ToString();

            //然后我们就将验证码去掉，避免了暴力破解

            this.Session["ValidateCode"] = new Guid();

            //判断用户输入的验证码是否正确

            if (sessionCode != Code)

            {

                return Content("验证码输入不正确");

            }

            //调用业务逻辑层（BLL）去校验用户是否正确

            var loginUserInfo = _userInfoService.CheckUserInfo(userInfo);

            if (loginUserInfo != null)

            {

                return Content("OK");

            }

            else

            {

                return Content("用户名密码错误");

            }

        }
    }
}