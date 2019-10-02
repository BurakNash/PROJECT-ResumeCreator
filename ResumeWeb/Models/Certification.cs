using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWeb.Models
{
    public class Certification
    {
        public int ID { get; set; }
        public string StartDate { get; set; }
        public string StopDate { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Where { get; set; }
        public string Explanation { get; set; }
    }
}