using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TrainingProjects
{
    public class Serializatio
    {
        public static void record(int id, string name)
        {
            Student St = new Student(id,name);
            St.Id = id;
            St.Name = name;
        }
        public static void serialization(Student St)
        {
            string json = JsonConvert.SerializeObject(St);
        }

    }
}
