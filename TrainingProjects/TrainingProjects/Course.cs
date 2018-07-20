using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProjects
{
    public class Course
    {
        public int Id;
        public String Name;
        public String Desc;

        public Course(int id, String name, String desc)
        {
            this.Id = id;
            this.Name = name;
            this.Desc = desc;
        }
    }
}
