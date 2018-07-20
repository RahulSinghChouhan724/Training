using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProjects
{
    public class Course
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Desc { get; set; }

        public Course()
        {

        }

        public Course(int id, String name, String desc)
        {
            this.Id = id;
            this.Name = name;
            this.Desc = desc;
        }
    }
}
