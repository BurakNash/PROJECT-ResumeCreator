using ResumeWeb.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace ResumeWeb.Controllers
{
    public class HomeController : Controller
    {
        ModelMigrations context = new ModelMigrations();


        AllOf all = new AllOf();


        // GET: Home
        public ActionResult Index()
        {
            all.AboutMe = context.AboutMes.ToList();
            all.Certification = context.Certifications.ToList();
            all.Contact = context.Contacts.ToList();
            all.Education = context.Educations.ToList();
            all.Experience = context.Experiences.ToList();
            all.Entry = context.entries.ToList();
            all.Skills = context.Skills.ToList();

            return View(all);
        }
        [HttpPost]
        public ActionResult Index(Contact model)
        {
            all.AboutMe = context.AboutMes.ToList();
            all.Certification = context.Certifications.ToList();
            all.Contact = context.Contacts.ToList();
            all.Education = context.Educations.ToList();
            all.Experience = context.Experiences.ToList();
            all.Entry = context.entries.ToList();
            all.Skills = context.Skills.ToList();
            string server = ConfigurationManager.AppSettings["server"];
            int port = int.Parse(ConfigurationManager.AppSettings["port"]);
            bool ssl = ConfigurationManager.AppSettings["ssl"].ToString() == "1" ? true : false;

            string from = ConfigurationManager.AppSettings["from"];
            string password = ConfigurationManager.AppSettings["password"];
            string fromname = ConfigurationManager.AppSettings["fromname"];
            string to = ConfigurationManager.AppSettings["to"];

            var client = new SmtpClient();
            client.Host = server;
            client.Port = port;
            client.EnableSsl = ssl;
            client.UseDefaultCredentials = true;
            client.Credentials = new System.Net.NetworkCredential(from, password);

            var email = new MailMessage();
            email.From = new MailAddress(from, fromname);
            email.To.Add(to);

            email.Subject = model.Subject;
            email.IsBodyHtml = true;
            email.Body = $"Full Name : {model.Name} \n Subject : {model.Subject} \n Message : {model.Message} \n E-mail : {model.Email}";
            try
            {
                client.Send(email);
                ViewData["result"] = true;
            }
            catch
            {
                ViewData["result"] = false;
            }
            return View(all);
        }
        public ActionResult AboutMe()
        {
            return View();
        }

        public ActionResult Entry()
        {
            return View();
        }
        public ActionResult AdminPanel()
        {
            return View();
        }

        public ActionResult Certification()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }


        public ActionResult Education()
        {
            return View();
        }

        public ActionResult Experience()
        {
            return View();
        }

        public ActionResult Skill()
        {
            return View();
        }


    }
}