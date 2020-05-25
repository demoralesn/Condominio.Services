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
    public class ExpenseController : ApiController
    {
        private CONDOMINIOEntities dbContext = new CONDOMINIOEntities();

        [HttpGet]
        [Route("api/expense/concept")]
        public IEnumerable<expense_concept> Concept()
        {
            using (CONDOMINIOEntities entities = new CONDOMINIOEntities())
            {
                return entities.expense_concept.ToList();
            }
        }

        [HttpGet]
        [Route("api/expense/entity")]
        public IEnumerable<expense_entity> Entity()
        {
            using (CONDOMINIOEntities entities = new CONDOMINIOEntities())
            {
                return entities.expense_entity.ToList();
            }
        }

        [HttpPost]
        //[Route("api/expense/add")]
        public IHttpActionResult AddExpense([FromBody]expense exp)
        {
            if (ModelState.IsValid)
            {
                dbContext.expenses.Add(exp);
                dbContext.SaveChanges();
                return Ok(exp);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
