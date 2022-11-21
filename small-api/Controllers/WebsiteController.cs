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
        protected readonly MyDbContext db;

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

            return new Website
            {
                Id = id,
                Name = "Microsoft",
                Url = "https://microsoft.com",
                Category = "Favorites",
                Favicon = "var/www/images/26342hdfbcn23.ico"
            };
        }

        [HttpPost]
        public ActionResult Post(Website website)
        {
            return NotFound();
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

