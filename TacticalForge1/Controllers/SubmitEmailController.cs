using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace TacticalForge1.Controllers
{
    public class SubmitEmailController : Controller
    {
        //// GET: SubmitEmail
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public void submitEmail(string email)
        {
            Console.WriteLine(email);
            //string path = @"C:\Users\Mitch\Desktop\Email List\Emails.txt";
            //var Email = email;

            //// This text is added only once to the file.
            //if (!System.IO.File.Exists(path))
            //{
            //    // Create a file to write to.
            //    using (StreamWriter sw = System.IO.File.CreateText(path))
            //    {
            //        sw.WriteLine("File created {0}", DateTime.Now);
            //    }
            //}

            //// This text is always added, making the file longer over time

            //if (System.IO.File.Exists(path))
            //{
            //    using (StreamWriter sw = System.IO.File.AppendText(path))
            //    {
            //        sw.WriteLine(Email);
            //        Console.WriteLine("Thank you! Your email has been added to the list.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Save file not found");
            //}
        }
    }
}