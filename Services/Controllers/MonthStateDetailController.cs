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
    public class MonthStateDetailController : ApiController
    {
        [HttpGet]
        public IEnumerable<sp_c_month_state_Result> Get(int period_id)
        {
            using (CONDOMINIOEntities entities = new CONDOMINIOEntities())
            {
                return entities.sp_c_month_state(period_id).ToList();
            }
        }
    }
}
