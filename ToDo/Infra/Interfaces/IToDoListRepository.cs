using System.Collections.Generic;
using ToDo.Models;

namespace ToDo.Infra.Interfaces
{
    public interface IToDoListRepository
    {
        List<ToDoList> Get();
        ToDoList Get(int id);
        ToDoList Create(ToDoList toDoList);
        ToDoList Update(ToDoList toDoList);
        ToDoList Remove(int id);
    }
}
