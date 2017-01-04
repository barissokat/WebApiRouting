using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiRouting.Models;

namespace WebApiRouting.Controllers
{
    public class TeacherApiController : ApiController
    {
        private List<Lesson> _lessons = new List<Lesson>
        {
            new Lesson { Id = 1, Code = "BM101", Teacher = "bsokat" },
            new Lesson { Id = 2, Code = "BM102", Teacher = "bsokat" },
            new Lesson { Id = 3, Code = "EEM101", Teacher = "fsokat" },
            new Lesson { Id = 4, Code = "EEM102", Teacher = "fsokat" },
            new Lesson { Id = 5, Code = "BM201", Teacher = "dsokat" },
            new Lesson { Id = 6, Code = "BM202", Teacher = "dsokat" }
        };

        [HttpGet]
        [Route("teacher/{name}/lessons")]
        public IEnumerable<Lesson> Lessons(string name)
        {
            return _lessons.Where(d => d.Teacher == name);
        }
    }
}
