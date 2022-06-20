using E_Commerce_Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        EcommerceContext db;
        public ProductsController(EcommerceContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<ProductDetail> Get()
        {
            return db.ProductDetails;
        }

        [HttpPost]
        public string Post([FromBody] ProductDetail productDetail)
        {
            db.ProductDetails.Add(productDetail);
            db.SaveChanges();
            return "success";
        }
    }
}
