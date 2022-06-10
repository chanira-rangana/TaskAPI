using System;
using System.Collections.Generic;
using TaskAPI.Models;

namespace TaskAPI.Services
{
    public class TodoService
    {
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get Goods for school",
                Description = "Get SOme text books school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.NEW
            };

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Get Paints for school",
                Description = "Get paints school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.COMPLETED
            };

            todos.Add(todo1);
            todos.Add(todo2);

            return todos;
        }
    }
}
