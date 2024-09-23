using Microsoft.AspNetCore.Mvc;
using StudentProtal.Data;
using StudentProtal.Models;
using StudentProtal.Models.Entity;

namespace StudentProtal.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public StudentsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]   
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModal viewModel)
        {
            var student = new Student
            {
                name=viewModel.name,
                email=viewModel.email,
                phone=viewModel.phone,
                Subscribe = viewModel.Subscribe
            };
            await dbContext.students.AddAsync(student);
            await dbContext.SaveChangesAsync();
            return View();
        }
    }
}
