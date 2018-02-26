using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialSiteAPI.Data;

namespace SocialSiteAPI.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly DataContext _context;

        //inject data
        public ValuesController(DataContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            // get the items in the database to a list
            var values = await _context.Values.ToListAsync();
            // return values with an OK code
            return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            // get the item that matches the id or default
            var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
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
    }
}

