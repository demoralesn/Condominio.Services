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
    public class PropertyController : ApiController
    {
        [HttpGet]
        public IEnumerable<sp_c_property_Result> Get()
        {
            using (CONDOMINIOEntities entities = new CONDOMINIOEntities())
            {
                return entities.sp_c_property().ToList();
            }
        }
    }
}
