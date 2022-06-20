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

    public class UsersController : ControllerBase
    {
        EcommerceContext db;
        public UsersController(EcommerceContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<UserDetail> Get()
        {
            return db.UserDetails;
        }

        [HttpPost]
        public string Post([FromBody] UserDetail userDetail)
        {
            db.UserDetails.Add(userDetail);
            db.SaveChanges();
            return "success";
        }
    }
}
