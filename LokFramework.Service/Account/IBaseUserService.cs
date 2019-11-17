using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LokFramework.Service.Account
{
    public interface IBaseUserService:IService
    {
        void CreateUser(string username, string password);
    }
}
