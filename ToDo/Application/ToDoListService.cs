using System.Collections.Generic;
using ToDo.Application.Interfaces;
using ToDo.Domain.Enums;
using ToDo.Infra.Interfaces;
using ToDo.Models;

namespace ToDo.Application
{
    public class ToDoListService : IToDoListService
    {
        private readonly IToDoListRepository _toDoListRepository;

        public ToDoListService(IToDoListRepository toDoListRepository)
        {
            _toDoListRepository = toDoListRepository;
        }

        public ToDoListModel Create(ToDoListModel toDoListModel)
        {
            ToDoList toDoList = new(toDoListModel.Id, toDoListModel.Text, (ToDoState)toDoListModel.Status);

            toDoList = _toDoListRepository.Create(toDoList);
            toDoListModel.Id = toDoList.Id;

            return toDoListModel;
        }

        public List<ToDoListModel> Get()
        {
            List<ToDoList> todos = _toDoListRepository.Get();

            List<ToDoListModel> toDoListModel = new();
            foreach (var todo in todos)
            {
                ToDoListModel todoDTO = new();
                todoDTO.Id = todo.Id;
                todoDTO.Text = todo.Text;
                todoDTO.Status = (int)todo.Status;

                toDoListModel.Add(todoDTO);
            }

            return toDoListModel;
        }

        public ToDoListModel Get(int id)
        {
            ToDoList todo = _toDoListRepository.Get(id);

            ToDoListModel toDoListModel = new();
            toDoListModel.Id = todo.Id;
            toDoListModel.Text = todo.Text;
            toDoListModel.Status = (int)todo.Status;

            return toDoListModel;
        }

        public ToDoListModel Remove(int id)
        {
            ToDoList todo = _toDoListRepository.Remove(id);

            ToDoListModel toDoListModel = new();
            toDoListModel.Id = todo.Id;
            toDoListModel.Text = todo.Text;
            toDoListModel.Status = (int)todo.Status;

            return toDoListModel;
        }

        public ToDoListModel Update(ToDoListModel toDoListModel)
        {
            ToDoList toDoList = new(toDoListModel.Id, toDoListModel.Text, (ToDoState)toDoListModel.Status);

            _toDoListRepository.Update(toDoList);

            return toDoListModel;
        }
    }
}
