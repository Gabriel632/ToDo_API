using System;
using ToDo.Domain.Enums;

namespace ToDo.Models
{
    public class ToDoList
    {
        public int Id { get; private set; }
        public string Text { get; private set; }
        public ToDoState Status { get; private set; }

        public ToDoList(int id, string text, ToDoState status)
        {
            ValidateToDo(id, text, status);

            Id = id;
            Text = text;
            Status = status;
        }

        private static void ValidateToDo(int id, string text, ToDoState status)
        {
            if (text.Length > 254)
                throw new ArgumentOutOfRangeException("Text", text, "Text is to much longuer");

            if (status != ToDoState.Todo && status != ToDoState.Done)
                throw new ArgumentException();
        }
    }
}
