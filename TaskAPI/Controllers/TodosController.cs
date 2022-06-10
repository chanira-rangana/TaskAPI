using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")] //class level attribute
    [ApiController]
    public class TodosController : ControllerBase
    {

        private TodoService _todoService;

        public TodosController()
        {
            _todoService = new TodoService();   
        }

        //method level attribute
        //action method
        [HttpGet("{id?}")]
        public IActionResult GetToDos(int? id)
        {
            if (id == null)
                return Ok(_todoService.AllTodos());
         
            var todo = _todoService.AllTodos().Where(i => i.Id == id);

            return Ok(todo);
        }

        
    }
}