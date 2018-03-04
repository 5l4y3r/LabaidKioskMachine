namespace EntityLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class icantseesharp1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Complaints",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        ComplainDoctor = c.String(),
                        ComplainNurse = c.String(),
                        ComplainAccomodation = c.String(),
                        ComplainHelp = c.String(),
                        ComplainBilling = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        HelpDeskExecutive = c.String(),
                        CoOperation = c.String(),
                        InformationCommunication = c.String(),
                        ConsultantCoOperation = c.String(),
                        PresenceOfConsultant = c.String(),
                        AssistanceForGivingMedicine = c.String(),
                        PECP = c.String(),
                        ESSP = c.String(),
                        COR = c.String(),
                        COW = c.String(),
                        CBCO = c.String(),
                        POHA = c.String(),
                        TTFS = c.String(),
                        QNOF = c.String(),
                        QLOF = c.String(),
                        BSP = c.String(),
                        OnP = c.String(),
                        EmployeeLike = c.String(),
                        EmployeeDislike = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        MobileNo = c.String(),
                        Relation = c.String(),
                        Age = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserInfoes");
            DropTable("dbo.Feedbacks");
            DropTable("dbo.Complaints");
        }
    }
}
