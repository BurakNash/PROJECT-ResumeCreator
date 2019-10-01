using CvSitesiDeneme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeCreator.Models
{
    public class AllOf
    {
        public int Id { get; set; }
        public virtual List<AboutMe> Aboutme { get; set; }
        public virtual List<Certification> Certificated { get; set; }
        public virtual List<Entry> Entry { get; set; }
        public virtual List<Education> Education { get; set; }
        public virtual List<Skill> Skills { get; set; }
        public virtual List<Experience> Experiance { get; set; }

    }
}