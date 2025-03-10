using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnzelleStudyGroup.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult ListStudent()
        {
            List<Models.StudentModel> students = new List<Models.StudentModel>();

            students.Add(new Models.StudentModel { StudentNumber = "u23563908", Name = "Anzelle", Surname = "van Beek", EmailAddress = "u23563908@tuks.co.za", myLink = Url.Content("~/HTML/AnzelleVanBeek.html") });
            students.Add(new Models.StudentModel { StudentNumber = "u23648156", Name = "Riya", Surname = "Naidoo", EmailAddress = "u23648156@tuks.co.za", myLink = Url.Content("~/HTML/RiyaNaidoo.html") });
            students.Add(new Models.StudentModel { StudentNumber = "u23819767", Name = "Cynthia", Surname = "Mashaba", EmailAddress = "u23819767@tuks.co.za", myLink = Url.Content("~/HTML/CynthiaMashaba.html") });
            students.Add(new Models.StudentModel { StudentNumber = "u23585073", Name = "Lwandiso", Surname = "Thanda", EmailAddress = "u23585073@tuks.co.za", myLink = Url.Content("~/HTML/LwandisoThanda.html") });
            students.Add(new Models.StudentModel { StudentNumber = "u22750802", Name = "Ntsika", Surname = "Mgijima", EmailAddress = "u22750802@tuks.co.za", myLink = Url.Content("~/HTML/NtsikaMgijima.html") });

            return View(students);
        }
    }
}