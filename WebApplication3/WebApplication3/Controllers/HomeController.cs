using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]


        public List<Sample> Get()
        {
            SampleDBContext db = new SampleDBContext();
            return db.Samples.ToList();
        }
        [HttpPost]
        public string Post([FromBody] string sample)
        {
            SampleDBContext db = new SampleDBContext();
            Sample s = new Sample();
            s.Fname = sample;
            db.Samples.Add(s);
            db.SaveChanges();
            return "Success";
        }

        [HttpDelete]
        public string Delete([FromBody] int sample)
        {
            SampleDBContext db = new SampleDBContext();
            Sample s = new Sample();
            s.Id = sample;
            db.Samples.Remove(s);
            db.SaveChanges();
            return "Success";
        }

        [HttpPut]
        public string Put([FromBody] Sample sample)
        {
            SampleDBContext db = new SampleDBContext();
            var ss = db.Samples.Where(x => x.Id == sample.Id);
            if (ss != null)
            {
                db.Samples.Update(sample);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }








    }
}
