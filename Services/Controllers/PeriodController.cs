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
    public class PeriodController : ApiController
    {
        [HttpGet]
        public IEnumerable<period> Get()
        {
            using (CONDOMINIOEntities entities = new CONDOMINIOEntities())
            {
                return entities.period.ToList();
            }
        }
    }
}
