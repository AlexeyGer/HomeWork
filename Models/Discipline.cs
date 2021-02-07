using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Discipline
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Annotation { set; get; }
        public int TeacherId { set; get; }
        //
        public List<Student> Students { set; get; }
        public Teacher Teacher { set; get; }
    }
}
