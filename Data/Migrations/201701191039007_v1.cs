namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Backlogs",
                c => new
                    {
                        BacklogId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Duree = c.Single(nullable: false),
                        Start_Date_Real = c.DateTime(nullable: false),
                        Start_Date_Estimated = c.DateTime(nullable: false),
                        End_Date_Real = c.DateTime(nullable: false),
                        End_Date_Estimated = c.DateTime(nullable: false),
                        Status = c.String(),
                        Remarks = c.String(),
                        Feature_FeaturesId = c.Int(),
                    })
                .PrimaryKey(t => t.BacklogId)
                .ForeignKey("dbo.Features", t => t.Feature_FeaturesId)
                .Index(t => t.Feature_FeaturesId);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeaturesId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Duree = c.Single(nullable: false),
                        Start_Date_Real = c.DateTime(nullable: false),
                        Start_Date_Estimated = c.DateTime(nullable: false),
                        End_Date_Real = c.DateTime(nullable: false),
                        End_Date_Estimated = c.DateTime(nullable: false),
                        Remarks = c.String(),
                        Status = c.String(),
                        project_ProjectId = c.Int(),
                    })
                .PrimaryKey(t => t.FeaturesId)
                .ForeignKey("dbo.Projects", t => t.project_ProjectId)
                .Index(t => t.project_ProjectId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Start_Date_Real = c.DateTime(nullable: false),
                        Start_Date_Estimated = c.DateTime(nullable: false),
                        End_Date_Real = c.DateTime(nullable: false),
                        End_Date_Estimated = c.DateTime(nullable: false),
                        Remarks = c.String(),
                        Status = c.String(),
                        Responsable_personId = c.Int(),
                        Team_TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.ProjectId)
                .ForeignKey("dbo.people", t => t.Responsable_personId)
                .ForeignKey("dbo.Teams", t => t.Team_TeamId)
                .Index(t => t.Responsable_personId)
                .Index(t => t.Team_TeamId);
            
            CreateTable(
                "dbo.people",
                c => new
                    {
                        personId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        JobTitle = c.String(),
                        DateNaissance = c.DateTime(nullable: false),
                        Statut = c.String(),
                    })
                .PrimaryKey(t => t.personId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        teamLeader_personId = c.Int(),
                    })
                .PrimaryKey(t => t.TeamId)
                .ForeignKey("dbo.people", t => t.teamLeader_personId)
                .Index(t => t.teamLeader_personId);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        TasksId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Duree = c.Single(nullable: false),
                        Start_Date_Real = c.DateTime(nullable: false),
                        Start_Date_Estimated = c.DateTime(nullable: false),
                        End_Date_Real = c.DateTime(nullable: false),
                        End_Date_Estimated = c.DateTime(nullable: false),
                        Remarks = c.String(),
                        Status = c.String(),
                        Backlog_BacklogId = c.Int(),
                        project_ProjectId = c.Int(),
                    })
                .PrimaryKey(t => t.TasksId)
                .ForeignKey("dbo.Backlogs", t => t.Backlog_BacklogId)
                .ForeignKey("dbo.Projects", t => t.project_ProjectId)
                .Index(t => t.Backlog_BacklogId)
                .Index(t => t.project_ProjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "project_ProjectId", "dbo.Projects");
            DropForeignKey("dbo.Tasks", "Backlog_BacklogId", "dbo.Backlogs");
            DropForeignKey("dbo.Backlogs", "Feature_FeaturesId", "dbo.Features");
            DropForeignKey("dbo.Features", "project_ProjectId", "dbo.Projects");
            DropForeignKey("dbo.Projects", "Team_TeamId", "dbo.Teams");
            DropForeignKey("dbo.Teams", "teamLeader_personId", "dbo.people");
            DropForeignKey("dbo.Projects", "Responsable_personId", "dbo.people");
            DropIndex("dbo.Tasks", new[] { "project_ProjectId" });
            DropIndex("dbo.Tasks", new[] { "Backlog_BacklogId" });
            DropIndex("dbo.Teams", new[] { "teamLeader_personId" });
            DropIndex("dbo.Projects", new[] { "Team_TeamId" });
            DropIndex("dbo.Projects", new[] { "Responsable_personId" });
            DropIndex("dbo.Features", new[] { "project_ProjectId" });
            DropIndex("dbo.Backlogs", new[] { "Feature_FeaturesId" });
            DropTable("dbo.Tasks");
            DropTable("dbo.Teams");
            DropTable("dbo.people");
            DropTable("dbo.Projects");
            DropTable("dbo.Features");
            DropTable("dbo.Backlogs");
        }
    }
}
