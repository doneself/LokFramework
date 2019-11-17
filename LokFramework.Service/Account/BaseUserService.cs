using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace LokFramework.Service.Account
{
    public class BaseUserService : IBaseUserService
    {
        private static string connString = System.Configuration.ConfigurationManager.ConnectionStrings["BaseConn"].ToString();
        public void CreateUser(string username, string password)
        {
            using(var conn = new SqlConnection(connString))
            {
                string sql = "INSERT INTO BaseUser (UserName, Password) VALUES (@UserName, @Password)";
                var affectedRows = conn.Execute(sql, new { UserName = username, Password = password });
                Debug.Write($"affectedRow:{affectedRows}");
            }
        }
    }
}
