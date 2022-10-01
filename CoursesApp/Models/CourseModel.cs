using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoursesApp.Models
{
    public class CourseModel
    {
        public int Id { get; set; }
        public string Tilte { get; set; }
        public string Description { get; set; }
        public int categoryId { get; set; }
        public CategoryModel Category { get; set; }
    }
}