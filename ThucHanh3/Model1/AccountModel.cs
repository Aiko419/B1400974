
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Model1.EntityFramework;
using PagedList;

namespace Model1
{
        public class AccountModel
        {
            private Model11 context = null;
            public AccountModel()
            {
                context = new Model11();
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
            public IEnumerable<Book> ListAllPage(int page, int rowLimit)
            {
                return context.Books.OrderByDescending(x => x.Title).ToPagedList(page, rowLimit);
            }







    }

}
