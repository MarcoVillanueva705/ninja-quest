using Microsoft.AspNetCore.Mvc;

namespace NinjaQuest.Controllers
{
    //magic strings[controller]
    [Route("api/[controller")]
    [ApiController]
    public class NinjasController: ControllerBase
    {
        //RESTful Standards

        //Get All
        [HttpGet]
        //method set as void b/c not returning anything
        public void Get()
        {

        }
        //Get One usually by ID
        //{id} is a route parameter
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