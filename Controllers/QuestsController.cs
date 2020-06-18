using Microsoft.AspNetCore.Mvc;

namespace NinjaQuest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class QuestsController: ControllerBase
    {
        //Get all
        [HttpGet]
        public void Get()
        {

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
    }

}
