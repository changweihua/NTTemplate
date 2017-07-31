using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lance.Repository.EF;
using Lance.Model.DomainModel;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Lance.API.Controllers
{
    /// <summary>
    /// Todo Controller
    /// </summary>
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        #region DI

        public ITodoRepository iTodoRepository { get; set; }

        public TodoController(ITodoRepository todoRepository)
        {
            iTodoRepository = todoRepository;
        }

        #endregion


        /// <summary>
        ///  api/values
        /// </summary>
        /// <returns></returns>
        /// <response code="200">成功执行查询</response>  
        /// <response code="401">未通过权限认证</response>
        /// <response code="500">未知异常</response>
        [ProducesResponseType(typeof(TodoItem), 201)]
        [ProducesResponseType(typeof(TodoItem), 400)]
        [HttpGet]
        public IEnumerable<TodoItem> Get()
        {
            return iTodoRepository.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpPost]
        public IActionResult Create([FromBody] TodoItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            iTodoRepository.Add(item);
            return CreatedAtRoute("GetTodo", new { controller = "Todo", id = item.Key }, item);
        }
    }
}
