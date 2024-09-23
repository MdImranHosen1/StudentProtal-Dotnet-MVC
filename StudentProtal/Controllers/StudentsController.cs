using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


        [HttpGet]
        public async Task<IActionResult>  List() { 

            var students=await dbContext.students.ToListAsync();
            return View(students);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var student=await dbContext.students.FindAsync(id);
            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Student viewModel)
        {
            var student = await dbContext.students.FindAsync(viewModel.id);
            if (student is not null)
            {
                student.name = viewModel.name;
                student.email = viewModel.email;
                student.phone = viewModel.phone;
                student.Subscribe = viewModel.Subscribe;

                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List","Students");
                

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id)
        {
            var student = await dbContext.students.FindAsync(id);
            if (student is not null)
            {
                dbContext.students.Remove(student);
                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Students");
        }

    }
}
