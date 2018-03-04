using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Complaint
    {
        public Complaint() { }

        public int? Id { get; set; }
        public string UserName { get; set; }

        [DefaultValue("NULL")]
        public string ComplainDoctor { get; set; }
        [DefaultValue("NULL")]
        public string ComplainNurse { get; set; }
        [DefaultValue("NULL")]
        public string ComplainAccomodation { get; set; }
        [DefaultValue("NULL")]
        public string ComplainHelp { get; set; }
        [DefaultValue("NULL")]
        public string ComplainBilling { get; set; }
       
    }
}
