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
    public class AdminController : ControllerBase
    {

        EcommerceContext db;
        public AdminController(EcommerceContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<AdminDetail> Get()
        {
            return db.AdminDetails;
        }

        [HttpPost]
        public string Post([FromBody] AdminDetail adminDetail)
        {
            db.AdminDetails.Add(adminDetail);
            db.SaveChanges();
            return "success";
        }
    }
}
