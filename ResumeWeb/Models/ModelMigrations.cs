using System;
using System.Collections.Generic;
using System.Configuration;
using ResumeWeb.Migrations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ResumeWeb.Models
{
    public class ModelMigrations : DbContext
    {
        public ModelMigrations() : base("ModelMigrations")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ModelMigrations, Migrations.Configuration>("ModelMigrations"));
        }

        public System.Data.Entity.DbSet<ResumeWeb.Models.AllOf> AllOfs { get; set; }

        public System.Data.Entity.DbSet<ResumeWeb.Models.AboutMe> AboutMes { get; set; }

        public System.Data.Entity.DbSet<ResumeWeb.Models.Certification> Certifications { get; set; }

        public System.Data.Entity.DbSet<ResumeWeb.Models.Contact> Contacts { get; set; }

        public System.Data.Entity.DbSet<ResumeWeb.Models.Education> Educations { get; set; }

        public System.Data.Entity.DbSet<ResumeWeb.Models.Entry> Enteries { get; set; }

        public System.Data.Entity.DbSet<ResumeWeb.Models.Experience> Experiances { get; set; }

        public System.Data.Entity.DbSet<ResumeWeb.Models.Skill> Skills { get; set; }
    }
}