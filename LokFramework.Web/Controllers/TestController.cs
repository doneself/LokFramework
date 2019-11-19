using LokFramework.Service.Account;
using LokFramework.ToolSet.Utils;
using LokFramework.Web.IdentityConfig;
using LokFramework.Web.IdentityConfig.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<string> AddUser()
        {
            ApplicationUser user;
            ApplicationUserStore Store = new ApplicationUserStore(new ApplicationDbContext());
            ApplicationUserManager userManager = new ApplicationUserManager(Store);
            user = new ApplicationUser
            {
                UserName = "lok",
                Email = "lok@test.com"
            };

            var result = await userManager.CreateAsync(user);
            if (!result.Succeeded)
            {
                return result.Errors.First();
            }
            return "User Added";
        }

        [Authorize]
        public ActionResult AuthPage()
        {
            return Content("this is admin page.");
        }
    }
}