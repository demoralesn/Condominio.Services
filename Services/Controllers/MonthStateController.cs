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
    public class MonthStateController : ApiController
    {
        [HttpGet]
        public IEnumerable<vw_month_state_list> Get()
        {
            using (CONDOMINIOEntities entities = new CONDOMINIOEntities())
            {
                return entities.vw_month_state_list.ToList();
            }
        }
    }
}
