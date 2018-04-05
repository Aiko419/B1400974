using Model1.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
        public class AccountModel
        {
            private ThucHanh3DbContext context = null;
            public AccountModel()
            {
                context = new ThucHanh3DbContext();
            }
            public bool Login(string UserName, string Password)
            {
                object[] sqlParas = {
                new SqlParameter("@UserName", UserName),
                new SqlParameter("@Password", Password),
            };
                //Gọi thủ tục đã tạo có tên "Sp_Account_Login" sử dụng SingleOrDefault() để trả về giá trị duy nhất, 
                var res = context.Database.SqlQuery<bool>("Sp_Account_Login @UserName, @Password", sqlParas).SingleOrDefault();
                return res;
            }

        }

    }
