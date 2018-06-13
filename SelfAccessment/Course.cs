using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAccessment
{
    class Course
    {
        internal Course(string name)
        {
            this.CourName = name;
        }
        private string courname;
        private List<Student> stds;
        private List<Teacher> teach; 
        public string CourName
        {
            get { return courname; }
            set{ courname = value; }
        }
        public List<Student> Stds
        {
            get { return stds; }
            set { stds = value; }
        }
        public List<Teacher> Teach
        {
            get { return teach; }
            set { teach = value; }
        }
    }
}
