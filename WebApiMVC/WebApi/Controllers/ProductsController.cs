using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebApi.Controllers
{
    public class ProductsController : ApiController
    {
        private SPX_ProductDetailsEntities db = new SPX_ProductDetailsEntities();

        // GET: api/Products
        public IQueryable<Product> GetProducts()
        {
            return db.Products;
        }

        // GET: api/Products/5
        [ResponseType(typeof(Review))]
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetProduct(int id)
        {

            IEnumerable<Review> preview = db.Reviews.Where(e => e.Product_Id == id).ToList();
            if (preview == null)
            {
                return NotFound();
            }

            return Ok(preview);
        }

        // PUT: api/Products/5
        [ResponseType(typeof(Review))]
        public IHttpActionResult PutProduct(int id, Review customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != customer.Reviews_Id)
            {
                return BadRequest();
            }

            db.Entry(customer).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.OK);
        }

        // POST: api/Products
        [ResponseType(typeof(Review))]
        public IHttpActionResult PostProduct(Review customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Reviews.Add(customer);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = customer.Product_Id }, customer);
        }

        // DELETE: api/Products/5
        [ResponseType(typeof(Review))]
        public IHttpActionResult DeleteProduct(int id)
        {
            Review customer = db.Reviews.Find(id);
            if (customer == null)
            {
                return NotFound();
            }

            db.Reviews.Remove(customer);
            db.SaveChanges();

            return Ok(customer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductExists(int id)
        {
            return db.Products.Count(e => e.Product_Id == id) > 0;
        }
    }
}