using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    public class Diploma : IDiploma
    {
        public int Id { get; set; }
        public int Credits { get; set; }
        public IRequirement[] Requirements { get; set; }
    }
}
