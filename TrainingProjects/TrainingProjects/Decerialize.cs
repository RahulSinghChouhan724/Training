using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProjects
{
    public class Decerialize
    {
        public static void DeserializeObject(Student St)
        {
            Student deserializeStd = JsonConvert.DeserializeObject<Student>(St);
        }
    }
}
