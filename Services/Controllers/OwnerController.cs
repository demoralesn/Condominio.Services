using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServicesDataAccess;
using System.Data.Entity;

namespace Services.Controllers
{
    public class OwnerController : ApiController
    {
        private CONDOMINIOEntities dbContext = new CONDOMINIOEntities();

        [HttpGet]
        public IEnumerable<owner> Get()
        {
            using (CONDOMINIOEntities entities = new CONDOMINIOEntities())
            {
                return entities.owner.ToList();
            }
        }

        [HttpGet]
        public owner Get(int id)
        {
            using (CONDOMINIOEntities entities = new CONDOMINIOEntities())
            {
                return entities.owner.FirstOrDefault(e => e.owner_id == id);
            }
        }

        [HttpPost]
        public IHttpActionResult AddOwner([FromBody]owner own)
        {
            if (ModelState.IsValid)
            {
                dbContext.owner.Add(own);
                dbContext.SaveChanges();
                return Ok(own);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IHttpActionResult UpdateOwner(int id, [FromBody] owner own)
        {
            if(ModelState.IsValid)
            {
                var ownerExists = dbContext.owner.Count(c => c.owner_id == id) > 0;

                if(ownerExists)
                {
                    dbContext.Entry(own).State = EntityState.Modified;
                    dbContext.SaveChanges();

                    return Ok(own);
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IHttpActionResult DeleteOwner(int id)
        {
            var own = dbContext.owner.Find(id);

            if (own != null)
            {
                dbContext.owner.Remove(own);
                dbContext.SaveChanges();

                return Ok(own);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
