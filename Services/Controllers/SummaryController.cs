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
    public class SummaryController : ApiController
    {
        [HttpGet]
        public IEnumerable<sp_c_summary_by_period_Result> Get(int period_id)
        {
            using (CONDOMINIOEntities entities = new CONDOMINIOEntities())
            {
                return entities.sp_c_summary_by_period(period_id).ToList();
            }
        }
    }
}
