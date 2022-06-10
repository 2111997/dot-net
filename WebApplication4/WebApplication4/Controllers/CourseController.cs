using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        SampleDBContext db = new SampleDBContext();
        [HttpGet]
        public List<Course> Get()
        {
            return db.Courses.ToList();
        }
        [HttpPost]
        public string Post([FromBody] string coursename)
        {
            Course s = new Course();
            s.Course1 = coursename;
            db.Courses.Add(s);
            db.SaveChanges();
            return "Success";
        }
        [HttpPut]
        public string Put([FromBody] Course Course)
        {
            var tblsampleObj = db.Courses.Where(x => x.Id == Course.Id);
            if (tblsampleObj != null)
            {
                db.Courses.Update(Course);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            var tblsampleObj = db.Courses.Where(x => x.Id == Id).FirstOrDefault();
            if (tblsampleObj != null)
            {
                db.Courses.Remove(tblsampleObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
    }
}
