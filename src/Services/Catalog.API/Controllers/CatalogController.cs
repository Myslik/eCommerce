using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Catalog.API.Models;
using Microsoft.AspNetCore.Authorization;

namespace Catalog.API.Controllers
{
    [Route("api/v1/[controller]")]
    [Authorize]
    public class CatalogController : Controller
    {
        private readonly IEnumerable<CatalogItem> items = new List<CatalogItem>
        {
            new CatalogItem { Id = 1, Name = "Hugo Boss" },
            new CatalogItem { Id = 2, Name = "Calvin Klein" }
        };

        [HttpGet]
        public IEnumerable<CatalogItem> Get()
        {
            return items;
        }

        [HttpGet("{id}")]
        public CatalogItem Get(int id)
        {
            return items.Where(ci => ci.Id == id).Single();
        }

        [HttpPost]
        public void Post([FromBody]CatalogItem item)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]CatalogItem item)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
