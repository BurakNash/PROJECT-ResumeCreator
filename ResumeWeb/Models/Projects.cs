using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResumeWeb.Models
{
    public class Projects
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
    }
}