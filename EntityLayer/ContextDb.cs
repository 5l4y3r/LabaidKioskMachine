using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   
        public class ContextDb : DbContext
    {
        public ContextDb() : base("Name=LabaidHealthKioskDb")
        {
            
        }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Complaint> Advertisements { get; set; }
        public DbSet<Feedback> Questions { get; set; }
  
    }
    
}
