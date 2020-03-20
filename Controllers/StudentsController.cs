using System;
using APBD03.DAL;
using APBD03.Models;
using Microsoft.AspNetCore.Mvc;

namespace APBD03.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService) 
        {
            _dbService = dbService;
        }


        [HttpGet]
        public IActionResult GetStudents(string orderBy)
        {
            return Ok(_dbService.GetStudents());
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Kochanowski");
            }
            else if (id == 2)
            {
                return Ok("Mickieiwcz");
            }
            else if (id == 3)
            {
                return Ok("Prus");
            }
            return NotFound("Nie znaleziono id");
        }

        [HttpPost]
        public IActionResult CreateStudent(Students student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult PutStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Aktualizacja");
            }
            return NotFound("Nie znaleziono id");

        }

        [HttpDelete("{id}")]
        public IActionResult RemoveStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Usunieto");
            }
            return NotFound("Nie znaleziono id");
        }

    }
}