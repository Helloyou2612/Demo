using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoModel.Models;

namespace DemoModel.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var students = new List<Student>()
            {
                new Student()
                {
                    StudentId = 1,
                    Fullname = "Nguyễn Văn Anh",
                    Gender = "Nam",
                    Email = "anhnv@gmail.com",
                    Mobile = "0979797979",
                    Address = "Hà Nội"
                },
                new Student()
                {
                    StudentId = 2,
                    Fullname = "Trần Thị Bắc",
                    Gender = "Nữ",
                    Email = "bactt@gmail.com",
                    Mobile = "0986868686",
                    Address = "Hà Nam"
                }
            };
            var data = new StudentRoom();
            data.Students.AddRange(students);
            return View(data);
        }
    }
}