using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")] //class level attribute
    [ApiController]
    public class TaskController : ControllerBase
    {
        //method level attribute
        //action method
        [HttpGet]
        public IActionResult Tasks()
        {
            var tasks = new string[] { "Task 1", "Task 2", "Task 3", "Task 4", "Task 5" };
            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult NewTask()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTask()
        {
            var somethingwentwrong = true;
            if(somethingwentwrong)
                return BadRequest();

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTask()
        {
            return Ok();
        }
    }
}