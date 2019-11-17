using LokFramework.Service.Account;
using LokFramework.ToolSet.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LokFramework.Web.Controllers
{
    public class TestController : Controller
    {
        private readonly IBaseUserService _baseUserService;
        public TestController(IBaseUserService baseUserService)
        {
            this._baseUserService = baseUserService;
        }
        public ActionResult CreateUser()
        {
            string username = "lok";
            string password = Encrypt.MD5Encrypt("123456", true);
            this._baseUserService.CreateUser(username, password);
            return Content("Insert completed");
        }
    }
}