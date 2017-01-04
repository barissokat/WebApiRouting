using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiRouting.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Teacher { get; set; }
        public string Code { get; set; }
    }
}