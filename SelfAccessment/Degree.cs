using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAccessment
{
    class Degree
    {
        public Degree(string namee)
        {
            degname = namee;
        }
        private string Degname;
        private List<Course> cour;
        public string degname
        {
            get { return Degname; }
            set { Degname = value; }
        }
        public List< Course> Cour
        {
            get { return cour; }
            set { cour = value; }
        }
    }
}
