using Microsoft.AspNetCore.Mvc;

namespace NinjaQuest.Controllers
{
    [Route("api/[controller")]
    [ApiController]
    public class NinjasController: ControllerBase
    {
        //RESTful Standards

        //Get All
        [HttpGet]
        public void Get()
        {

        }
        //Get One usually by ID
        [HttpGet("{id}")]
        public void Get(int id)
        {

        }
        //Create One
        [HttpPost]
        public void Create()
        {

        }
        //Edit One
        [HttpPut("{id}")]
        public void Update(int id)
        {

        }
        //Delete One
        [HttpDelete("{id}")]
        public void Delete (int id)
        {

        }
    }
}