using NHibernate;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace OnlineShop.Controllers
{
    public class ProductController : ApiController
    {
        private readonly ISession _session;

        public ProductController()
        {
            _session = NHsession.OpenSession();
        }

        // GET api/values
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            IList<Product> product = new List<Product>();
            using (var tx = _session.BeginTransaction())
            {
                var query = await _session.QueryOver<Product>().ListAsync();
                product = query;
            }

            return Ok(product);
        }
    }
}
