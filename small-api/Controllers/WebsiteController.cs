using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using small_api.Models;
using small_api.Data;

namespace small_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebsiteController : ControllerBase
    {
        protected readonly MyDbContext _db;

        public WebsiteController(MyDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return NotFound();
        }

        [HttpGet("{id}")]
        public ActionResult<Website> Get(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            IQueryable<Website> website = _db.websites.AsQueryable().Where(x => x.Id == id);

            if (website.Count() == 0)
            {
                return NotFound("No website found with this index");
            }

            return Ok(website.First());
        }

        [HttpPost]
        public ActionResult Post(Website website)
        {
            if (website == null)
            {
                return NotFound();
            }

            _db.Add(website);
            _db.SaveChanges();
            return Ok("New website posted");
        }

        [HttpPut]
        public ActionResult Put(Website website)
        {
            return NotFound();
        }

        [HttpDelete]
        public ActionResult Delete(Website website)
        {
            return NotFound();
        }
    }
}

