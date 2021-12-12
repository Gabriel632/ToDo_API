using System.Collections.Generic;
using System.Linq;
using ToDo.Application.DTOs;
using ToDo.Domain.Enums;
using ToDo.Infra.Interfaces;
using ToDo.Models;

namespace ToDo.Infra
{
    public class ToDoListRepository : IToDoListRepository
    {
        private readonly ToDoDbContext _context;

        public ToDoListRepository(ToDoDbContext context)
        {
            _context = context;
        }

        public ToDoList Create(ToDoList toDoListItem)
        {
            ToDoListDTO toDoListDTO = new();
            toDoListDTO.Id = toDoListItem.Id;
            toDoListDTO.Text = toDoListItem.Text;
            toDoListDTO.Status = (int)toDoListItem.Status;

            _context.ToDoList.Add(toDoListDTO);
            _context.SaveChanges();

            ToDoList return_toDoList = new(toDoListDTO.Id, toDoListDTO.Text, (ToDoState)toDoListDTO.Status);

            return return_toDoList;
        }

        public List<ToDoList> Get()
        {
            List<ToDoListDTO> todosDTO = _context.ToDoList.ToList();

            List<ToDoList> todos = new();
            foreach (var todoDTO in todosDTO)
            {
                ToDoList todo = new(todoDTO.Id, todoDTO.Text, (ToDoState)todoDTO.Status);
                todos.Add(todo);
            }

            return todos;
        }

        public ToDoList Get(int id)
        {
            ToDoListDTO todoDTO = _context.ToDoList.Find(id);

            ToDoList todo = new(todoDTO.Id, todoDTO.Text, (ToDoState)todoDTO.Status);

            return todo;
        }

        public ToDoList Update(ToDoList toDoList)
        {
            ToDoListDTO toDoListDTO = new();
            toDoListDTO.Id = toDoList.Id;
            toDoListDTO.Text = toDoList.Text;
            toDoListDTO.Status = (int)toDoList.Status;

            _context.ToDoList.Update(toDoListDTO);
            _context.SaveChanges();

            return toDoList;
        }

        public ToDoList Remove(int id)
        {
            ToDoListDTO todoDTO = _context.ToDoList.Find(id);

            _context.Remove(todoDTO);
            _context.SaveChangesAsync();

            ToDoList todo = new(todoDTO.Id, todoDTO.Text, (ToDoState)todoDTO.Status);

            return todo;
        }
    }
}
