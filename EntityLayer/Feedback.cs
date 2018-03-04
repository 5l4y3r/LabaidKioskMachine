using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class Feedback
    {
        public Feedback() { }

        public int? Id { get; set; }
        public string UserName { get; set; }
        [DefaultValue("NULL")]
        public string HelpDeskExecutive { get; set; }
        [DefaultValue("NULL")]
        public string CoOperation { get; set; }
        [DefaultValue("NULL")]
        public string InformationCommunication { get; set; }
        [DefaultValue("NULL")]
        public string ConsultantCoOperation { get; set; }
        [DefaultValue("NULL")]
        public string PresenceOfConsultant { get; set; }
        [DefaultValue("NULL")]
        public string AssistanceForGivingMedicine { get; set; }
        [DefaultValue("NULL")]
        public string PECP { get; set; }
        [DefaultValue("NULL")]
        public string ESSP { get; set; }
        [DefaultValue("NULL")]
        public string COR { get; set; }
        [DefaultValue("NULL")]
        public string COW { get; set; }
        public string CBCO { get; set; }
        [DefaultValue("NULL")]
        public string POHA { get; set; }
        [DefaultValue("NULL")]
        public string TTFS { get; set; }
        [DefaultValue("NULL")]
        public string QNOF { get; set; }
        [DefaultValue("NULL")]
        public string QLOF { get; set; }
        public string BSP{ get; set; }
        [DefaultValue("NULL")]
        public string OnP { get; set; }
        [DefaultValue("NULL")]
        public string EmployeeLike { get; set; }
        [DefaultValue("NULL")]
        public string EmployeeDislike { get; set; }
        

    }
}
