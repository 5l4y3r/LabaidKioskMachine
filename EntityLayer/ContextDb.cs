﻿using System;
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
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());
        }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
  
    }
    
}
