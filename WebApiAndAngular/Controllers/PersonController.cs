using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiAndAngular.Models;
using System.Data.Entity; 

namespace WebApiAndAngular.Controllers
{
    public class PersonController : ApiController
    {
        private WebApiAndAngularDBEntities myEntity = new WebApiAndAngularDBEntities();
        // GET: api/Person
        public IEnumerable<tbl_Subscribers> Get()
        {
            return myEntity.tbl_Subscribers.AsEnumerable();
        }

        // GET: api/Person/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Person
        public void Post(tbl_Subscribers sub)
        {
            if (ModelState.IsValid)
            {
                myEntity.tbl_Subscribers.Add(sub);
                myEntity.SaveChanges();
            }
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
