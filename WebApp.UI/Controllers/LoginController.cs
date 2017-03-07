using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Common;

namespace WebApp.UI.Controllers
{
    public class LoginController : Controller
    {
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
    }
}