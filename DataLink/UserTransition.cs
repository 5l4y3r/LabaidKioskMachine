using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
namespace DataLink
{
   public class UserTransition
    {
        public static void AddUser(string Uname, string UMobile, string URelation, string Uage, string uEmail)
        {
            var context = new ContextDb();

            context.UserInfos.Add(new UserInfo()
            {
                UserName = Uname,
                MobileNo = UMobile,
                Relation = URelation,
                Age = Uage,
                Email = uEmail
               
            });
            context.SaveChanges();
        }
    }
}
