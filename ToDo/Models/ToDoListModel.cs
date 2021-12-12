using System.ComponentModel.DataAnnotations;

namespace ToDo.Models
{
    public class ToDoListModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Status { get; set; }
    }
}
