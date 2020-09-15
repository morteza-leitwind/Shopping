using NHibernate;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace OnlineShop.Controllers
{
 
    public class CartController : ApiController
    {
        private readonly ISession _session;

        public CartController()
        {
            _session = NHsession.OpenSession();
        }

        // GET api/values
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            IList<Cart> cart = new List<Cart>();
            using (var tx = _session.BeginTransaction())
            {
                var query = await _session.QueryOver<Cart>().ListAsync();
                cart = query;
            }

            return Ok(cart);
        }

        // POST api/values
        [HttpPost]
       
        public async Task<IHttpActionResult> Post([FromBody]int  id)
        {
            using (var tx = _session.BeginTransaction())
            {
                var p = await _session.GetAsync<Product>(id);
                var c = await _session.QueryOver<Cart>().Where(x => x.ProductId == id).SingleOrDefaultAsync();

                if (p != null)
                {
                    if (c == null)
                    {
                        Cart cItem = new Cart
                        {
                            Name = p.Name,
                            Picture = p.Picture,
                            Price = p.Price,
                            Quantity = 1,
                            ProductId = p.Id,
                        };
                        await _session.SaveAsync(cItem);
                    }
                    else
                    {
                        c.Quantity = c.Quantity + 1;

                        await _session.SaveAsync(c);
                    }
                }

                await tx.CommitAsync();

                return Ok();
            }
        }

        // DELETE api/values/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            using (var tx = _session.BeginTransaction())
            {
                var cart = await _session.QueryOver<Cart>().Where(x => x.ProductId == id).SingleOrDefaultAsync();
                if (cart != null)
                    await _session.DeleteAsync(cart);

                await tx.CommitAsync();
            }
            return Ok();
        }
    }
}
