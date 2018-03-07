using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataLink
{
   public class ComplainTransition
    {
        public static void AddComplain(string Uname, string CDoc, string CNur, string CAcco, string CHelp, string CBill)
        {
            var context = new ContextDb();

            context.Complaints.Add(new Complaint()
            {
                UserName = Uname,
                ComplainDoctor = CDoc,
                ComplainNurse = CNur,
                ComplainAccomodation = CAcco,
                ComplainHelp = CHelp,
                ComplainBilling =  CBill
                

            });
            context.SaveChanges();
        }
    }
}
