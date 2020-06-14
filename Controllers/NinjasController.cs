using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NinjaQuest.Models;
using NinjaQuest.Services;

namespace NinjaQuest.Controllers
{
    //in the route brackets, data attribute for the route
    //magic strings[controller]
    [Route("api/[controller")]
    [ApiController]
    public class NinjasController: ControllerBase
    {
        private readonly NinjasService _service;

        //RESTful Standards

        //Get All
        [HttpGet]
    //Get all ninjas
        public ActionResult<IEnumerable<Ninja>> Get()
        {
            return Ok(_service.Find());
        }
        //method set as void b/c not returning anything

        // public void Get();
       
       //If you're going to return an ActionResult,
       //you have to state what type it's going to be
       //Here we want to iterate through type Quest, which
       //is an array of objects
        // public ActionResult <IEnumerable<Quest>> Get()
        // {
            // return an array of type Quests
            //return Quests[]

            //returns status code 200, acccepts dynamic object
            //of any type
        //     return Ok(new Quest[] { new Quest() });
        // }
        //Get One usually by ID
        //{id} is a route parameter
        [HttpGet("{id}")]
        public ActionResult<Ninja> Get(int id)
        {
            return Ok(_service.FindById(id));
        }
        //Create One
        //Post route
        [HttpPost]
        public ActionResult<Ninja> Create([FromBody] Ninja ninja)
        {
            return Ok(_service.Create(ninja.Name));
            {
                
            }
            //create failed
            //bad data
            // BadRequest(new { error = "bad data"});

        }
        //Edit One
        [HttpPut("{id}")]
        public void Update(int id)
        {
            Unauthorized("you did not create this ojbect");
        }
        //Delete One
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete (int id)
        {
            return Ok(_service.Delete(id));
        }//SQL connection

        public NinjasController(NinjasService service)
        {
           _service = service; 
        }
    }
}
