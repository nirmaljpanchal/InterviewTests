using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    public class Student : IStudent
    {
        public int Id { get; set; }
        public ICourse[] Courses { get; set; }
        public STANDING Standing { get; set; } = STANDING.None;
    }
}
