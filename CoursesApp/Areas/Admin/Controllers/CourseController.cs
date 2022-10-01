using CoursesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoursesApp.Areas.Admin.Controllers
{
    public class CourseController : Controller
    {
        // GET: Admin/Course
        public ActionResult Index()
        {
            var lstcourses = new List<CourseModel>
        {
            new CourseModel
            {
                Id=1,
                Tilte="xamarian c# ",
                Description="This description for xamarin course 111"
            },

            new CourseModel
            {
                Id=1,
                Tilte="xamarian c# 2 ",
                Description="This description for xamarin course 222"
            }
        };
            return View(lstcourses);
        }
    }
}