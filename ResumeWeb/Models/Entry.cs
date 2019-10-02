using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWeb.Models
{
    public class Entry
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string JobFirstName { get; set; }
        public string JobLastName { get; set; }
        public string Introduction { get; set; }
    }
}