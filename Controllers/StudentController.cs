using Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab3.Controllers
{
    [Route("Student")]
    public class StudentController : Controller
    {

        private List<Student> listStudents = new List<Student>();
        private static int nextId = 105;

        public StudentController()
        {
            listStudents = new List<Student>()
            {
                new Student() {Id = 101, Name = "Tùng", Branch = Branch.IT,
                    Gender = Gender.Male, IsRegular = false, Score = 10.0,
                    Address = "A1 - 2018", Email = "tung@.com",
                    DateOfBirth = new DateTime(2003, 9, 6)},
                new Student() {Id = 101, Name = "Sang", Branch = Branch.IT,
                    Gender = Gender.Male, IsRegular = true, Score = 5.0,
                    Address = "A2 - 2018", Email = "sang@.com",
                    DateOfBirth = new DateTime(2002, 5, 15)},
                new Student() {Id = 101, Name = "Hải", Branch = Branch.IT,
                    Gender = Gender.Female, IsRegular = true, Score = 7.0,
                    Address = "A3 - 2018", Email = "hai@.com",
                    DateOfBirth = new DateTime(2004, 1, 22)},
                new Student() {Id = 101, Name = "Nhi", Branch = Branch.IT,
                    Gender = Gender.Female, IsRegular = false, Score = 5.6,
                    Address = "A4 - 2018", Email = "nhi@.com",
                    DateOfBirth = new DateTime(2003, 11, 30)}
            };
        }

        [HttpGet("Add")]
        public IActionResult ViewAdd()
        {
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = new List<SelectListItem>()
            {
                new SelectListItem { Text = "IT", Value = "1" },
                new SelectListItem { Text = "BE", Value = "2" },
                new SelectListItem { Text = "CE", Value = "3" },
                new SelectListItem { Text = "EE", Value = "4" }
            };
            return View();
        }

        [HttpPost("Create")]
        public IActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                s.Id = listStudents.Last<Student>().Id + 1;
                listStudents.Add(s);
                return View("Index", listStudents);
            }
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = new List<SelectListItem>()
            {
                new SelectListItem { Text = "IT", Value = "1" },
                new SelectListItem { Text = "BE", Value = "2" },
                new SelectListItem { Text = "CE", Value = "3" },
                new SelectListItem { Text = "EE", Value = "4" }
            };
            return View("ViewAdd");
        }

        [HttpGet("List")]
        public IActionResult Index()
        {
            return View(listStudents);
        }
    }
}
