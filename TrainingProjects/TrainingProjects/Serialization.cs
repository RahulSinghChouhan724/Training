using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace TrainingProjects
{
    public class Serialization
    { 
        public string serialization(Student s)
        {
            string St1 = JsonConvert.SerializeObject(s);
            dynamic data = JsonConvert.DeserializeObject(St1);
           // return ((dynamic)JsonConvert.DeserializeObject(St1));
            return data.Name;
        }


    }
}
