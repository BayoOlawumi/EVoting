using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAccessment
{
    class Teacher:Person
    {
        private List<Student> stds;
        public List<Student> Stds
        {
            get { return stds; }
            set { stds = value; }
        }
        public void GradeTest()
        {

        }
    }
}
