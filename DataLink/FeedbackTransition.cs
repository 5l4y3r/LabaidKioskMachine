using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataLink
{
   public class FeedbackTransition
    {
        public static void AddFeedback(string Uname, List<string> rating, string tLike, string tDislike)
        {
            var context = new ContextDb();

            context.Feedbacks.Add(new Feedback()
            {
                UserName = Uname,
                HelpDeskExecutive = rating[0],
                CoOperation = rating[1],
                InformationCommunication = rating[2],
                ConsultantCoOperation = rating[3],
                PresenceOfConsultant = rating[4],
                AssistanceForGivingMedicine = rating[5],
                PECP = rating[6],
                ESSP = rating[7],
                COR = rating[8],
                COW = rating[9],
                CBCO = rating[10],
                POHA = rating[11],
                TTFS = rating[12],
                QNOF = rating[13],
                QLOF = rating[14],
                BSP = rating[15],
                OnP = rating[16],
                EmployeeLike = tLike,
                EmployeeDislike = tDislike

            });
            context.SaveChanges();
        }
    }
}
