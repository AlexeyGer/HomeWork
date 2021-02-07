using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Student
    {
        public int Id { set; get; }
        public string Name { set; get; }
        //
        public List<Discipline> Disciplines { set; get; }
    }
}
