using System.Collections.Generic;
using ToDo.Models;

namespace ToDo.Application.Interfaces
{
    public interface IToDoListService
    {
        List<ToDoListModel> Get();
        ToDoListModel Get(int id);
        ToDoListModel Create(ToDoListModel toDoListModel);
        ToDoListModel Update(ToDoListModel toDoListModel);
        ToDoListModel Remove(int id);
    }
}
