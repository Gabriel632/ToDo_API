using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDo.Infra.Interfaces;
using ToDo.Models;
using ToDo.Domain.Enums;
using ToDo.Application.Interfaces;

namespace ToDo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ToDoListController : Controller
    {
        private readonly IToDoListService _toDoListService;

        public ToDoListController(IToDoListService toDoListService)
        {
            _toDoListService = toDoListService;
        }

        [HttpGet("GetList")]
        public ActionResult<List<ToDoListModel>> GetList()
        {
            try
            {
                List<ToDoListModel> toDoListModel = _toDoListService.Get();
                return Ok(toDoListModel);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{id:int}")]
        public ActionResult<ToDoListModel> GetById(int id)
        {
            ToDoListModel toDoListModel = _toDoListService.Get(id);
            return Ok(toDoListModel);
        }

        [HttpPost("Create")]
        public ActionResult<ToDoListModel> Create(ToDoListModel toDoListModel)
        {
            _toDoListService.Create(toDoListModel);
            return Ok(toDoListModel);
        }

        [HttpPatch("Update")]
        public ActionResult<ToDoListModel> Update(ToDoListModel toDoListModel)
        {          
            _toDoListService.Update(toDoListModel);
            return Ok(toDoListModel);
        }

        [HttpDelete("Delete")]
        public ActionResult Delete(int id)
        {
            ToDoListModel toDoListModel = _toDoListService.Remove(id);
            return Ok(toDoListModel);
        }
    }
}
