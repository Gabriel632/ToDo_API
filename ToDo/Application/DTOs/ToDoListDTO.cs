using System.ComponentModel.DataAnnotations;

namespace ToDo.Application.DTOs
{
    public class ToDoListDTO
    {
        [Key]       
        public int Id { get; set; }
        public string Text { get; set; }
        public int Status { get; set; }
    }
}
