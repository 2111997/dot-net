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
    public class StudentController : ControllerBase
    {
        SampleDBContext db = new SampleDBContext();

        [HttpGet]
        public List<StudentDatum> Get()
        {
            return db.StudentData.ToList();
        }

        [HttpGet]
        [Route("Class")]
        public List<Class> GetStudentsWithCourse()
        {
            return db.StudentData.Join(db.Courses, x => x.Courseid, y => y.Id, (x, y) => new Class { Course1 = y.Course1, Name = x.Name, RollNo = x.RollNo, Id = x.Id }).ToList();
        }
        [HttpPost]
        public string Post([FromBody] StudentDatum student)
        {
            StudentDatum s = new StudentDatum();
            s.Name = student.Name;
            s.RollNo = student.RollNo;
            s.Courseid = student.Courseid;
            db.StudentData.Add(s);
            db.SaveChanges();
            return "Success";
        }
        [HttpPut]
        public string Put([FromBody] StudentDatum StudentDatum)
        {
            var tblsampleObj = db.StudentData.Where(x => x.Id == StudentDatum.Id);
            if (tblsampleObj != null)
            {
                db.StudentData.Update(StudentDatum);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            var tblsampleObj = db.StudentData.Where(x => x.Id == Id).FirstOrDefault();
            if (tblsampleObj != null)
            {
                db.StudentData.Remove(tblsampleObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";



        }
    }
}
