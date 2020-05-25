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
    public class IncomeController : ApiController
    {
        private CONDOMINIOEntities dbContext = new CONDOMINIOEntities();

        [HttpGet]
        [Route("api/income/concept")]
        public IEnumerable<income_concept> Concept()
        {
            using (CONDOMINIOEntities entities = new CONDOMINIOEntities())
            {
                return entities.income_concept.ToList();
            }
        }

        [HttpPost]
        //[Route("api/expense/add")]
        public IHttpActionResult AddIncome([FromBody]income inc)
        {
            if (ModelState.IsValid)
            {
                dbContext.incomes.Add(inc);
                dbContext.SaveChanges();
                return Ok(inc);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
