using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectManager _subjectManager;

        public SubjectController(ISubjectManager subjectManager)
        {
            _subjectManager = subjectManager;
        }
        // GET: api/<SubjectController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SubjectController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }

        // POST api/<SubjectController>
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {

            return Created("", value);
        }

        // PUT api/<SubjectController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return NoContent();
        }

        // DELETE api/<SubjectController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
