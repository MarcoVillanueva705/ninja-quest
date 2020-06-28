using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NinjaQuest.Models;
using NinjaQuest.Services;

namespace NinjaQuest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class QuestsController: ControllerBase
    {
        private readonly QuestsService _service;

        //Get all
        [HttpGet]
        public ActionResult<IEnumerable<Quest>> Get()
        {
            return Ok(_service.Find());
            //implement appropriate methods in quests service
        }

        //Get one by ID
        [HttpGet("{id}")]
        public void Get(int id)
        {
            //need post and put
        }
        [HttpPost]
        public void Create()
        {

        }

        [HttpPut("{id}")]
        public void Update(int id)
        {
            
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
        public QuestsController (QuestsService service)
        {
            _service = service;
        }
    }

}
