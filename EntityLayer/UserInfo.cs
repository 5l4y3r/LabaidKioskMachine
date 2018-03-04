using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class UserInfo
    {
        public UserInfo() { }

        public int? Id { get; set; }
        public string UserName { get; set; }
        public string MobileNo { get; set; }

        [DefaultValue("NULL")]
        public string Relation { get; set; }
        public string Age { get; set; }

        [DefaultValue("NULL")]
        public string Email { get; set; }

    }
}
